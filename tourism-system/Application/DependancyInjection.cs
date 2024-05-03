using tourism_system.Application.Abstraction;
using tourism_system.Application.CQRS.TourismLocationFeatures.AddTourismLocation;
using tourism_system.Application.Services;

namespace tourism_system.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(typeof(DependancyInjection).Assembly);

            });

            services.AddAutoMapper(typeof(DependancyInjection));



            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<CreateTourismLocationCommandHandler>();



            return services;
        }
    }
}
