using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UserService.IdentityCommunication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIdentityCommunication(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IdentityServerApiClient>();
            return services;
        }
    }
}

