using Project01.Core.Common.Configurations;
using Project01.Core.Common.Extensions.Swaggers;
using Project01.Infrastructure;
using System.Reflection;

namespace Project01.Core.Common
{
    public static class ServiceCollection
    {
        public static void AddServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddMemoryCache();
            service.AddControllers();
            service.AddEndpointsApiExplorer();
            service.AddApplicationLayer(configuration);
            service.AddSwaggerConfiguration(configuration);
            service.AddApplicationPersistence(configuration);
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static void AddConfigurations(this IServiceCollection service, IConfiguration configuration)
        {
            var xorConfiguration = configuration
                .GetSection(XorConfiguration.Key)
                .Get<XorConfiguration>();

            if (xorConfiguration.PayloadKey == null || xorConfiguration.SecretKey == null)
                throw new Exception("Section 'Xor' configuration settings are not found in settings file");

            service.AddSingleton(xorConfiguration);
        }

        public static void UseServices(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
                app.UseSwaggerConfiguration();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
