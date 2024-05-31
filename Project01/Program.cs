using Project01.Application.Models;
using Project01.Core.Common.Extensions.Swaggers;
using Project01.Domain.Filters;
using Project01.Infrastructure;
using System.Reflection;
using static Project01.Domain.Filters.AuthorizationFilter;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<TokenService>();
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddSwaggerConfiguration(builder.Configuration);
builder.Services.AddApplicationPersistence(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseSwaggerConfiguration();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name V1");
});

app.UseRouting();
app.UseStaticFiles();
app.UseAuthorization();
app.UseHttpsRedirection();

app.UseMiddleware<AuthorizationFilter>();

app.MapControllers();

app.Run();
