using TipoProducto.Domain.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TipoProducto.Application
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services
        )
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(options => 
                options
                .RegisterServicesFromAssemblies(
                    assembly
                ));

            services.AddTransient<ProductoServicio>();

            return services;
        }
    }
}

