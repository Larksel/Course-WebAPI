using ReserveiAPI.Repositories.Interfaces;
using ReserveiAPI.Repositories.Entities;
using ReserveiAPI.Services.Interfaces;
using ReserveiAPI.Services.Entities;

namespace ReserveiAPI.Services.Server
{
    public static class DependenciesInjection
    {
        public static void AddUserDependencies(this IServiceCollection services)
        {
            // Dependencia: Usuário
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
