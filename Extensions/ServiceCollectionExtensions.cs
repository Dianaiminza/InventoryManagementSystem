using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InventoryManagementSystem.Extensions
{
    public static  class ServiceCollectionExtensions
    {
       
        public static IServiceCollection AddDatabaseContext(
      this IServiceCollection services,
      IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var enableLogging = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

            services.AddDbContext<ApplicationDbContext>(
                dbContextOptions => dbContextOptions
                    .UseSqlServer(connectionString, options =>
                    {
                      
                    })
                    .EnableSensitiveDataLogging(enableLogging)
                    .EnableDetailedErrors(enableLogging));

            return services;
        }
    }
}
