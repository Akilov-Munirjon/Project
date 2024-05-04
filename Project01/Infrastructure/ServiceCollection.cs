using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;
using System.Reflection;

namespace Project01.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString, c => c.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });
        }

        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
