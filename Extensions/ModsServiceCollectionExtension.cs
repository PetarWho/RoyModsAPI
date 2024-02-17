using RoyModsAPI.Contracts;
using RoyModsAPI.Services;

namespace RoyModsAPI.Extensions
{
    public static class ModsServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
