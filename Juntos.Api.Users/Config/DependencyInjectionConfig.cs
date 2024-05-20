using Juntos.Api.Users.Domain.Interfaces;
using Juntos.Api.Users.Infrastructure.Interfaces;
using Juntos.Api.Users.Infrastructure.Repository;
using Juntos.Api.Users.Services;

namespace Life.API.Proposal.App.Config
{
    public static class DependencyInjectionConfig
    {
        public static void AddConfigurationDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
