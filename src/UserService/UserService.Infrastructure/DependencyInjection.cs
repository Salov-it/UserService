using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Interface;

namespace UserService.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["DbConnection"];

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<IContext>(provider => provider.GetService<Context>());
            return services;
        }
    }
}
