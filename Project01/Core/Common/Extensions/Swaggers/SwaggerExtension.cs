using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Project01.Core.Common.Extensions.Swaggers
{
    public static class SwaggerExtension
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //var swaggerBasicAuthConfiguration = configuration
            //    .GetSection(SwaggerBasicAuthConfiguration.Key)
            //    .Get<SwaggerBasicAuthConfiguration>();

            //if (swaggerBasicAuthConfiguration?.Username == null || swaggerBasicAuthConfiguration.Password == null)
            //{
            //    throw new Exception("Section 'SwaggerBasicAuth' configuration settings are not found in settings file");
            //}

            //services.AddSingleton(swaggerBasicAuthConfiguration);

            services.AddApiVersioning(options =>
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

            services.AddSwaggerGen(options =>
            {
                var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerDoc
                    (
                        $"{description.GroupName}", new OpenApiInfo()
                        {
                            Title = "My Project API ",
                            Version = description.ApiVersion.ToString()
                        }
                    );
                }

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                        {
                           Reference = new OpenApiReference
                           {
                             Type = ReferenceType.SecurityScheme,
                             Id = "Bearer"
                           }
                        },
                    Array.Empty<string>()
                }
            });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            var provider = app.ApplicationServices.GetService<IApiVersionDescriptionProvider>()!;

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.DocExpansion(DocExpansion.None);

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        "My Project API " + description.ApiVersion.ToString());
                }
            });
        }
    }
}
