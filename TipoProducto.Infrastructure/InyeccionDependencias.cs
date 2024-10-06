using TipoProducto.Domain.Options;
using TipoProducto.Domain.Ports;
using TipoProducto.Infrastructure.Adapters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TipoProducto.Infrastructure
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AddInfra(
            this IServiceCollection services
            , IConfiguration configuration
        )
        {
            services.AddScoped<IImpuesto, Alimentos>();
            services.AddScoped<IImpuesto, Electronicos>();
            services.AddScoped<IImpuesto, Otros>();
            services.AddScoped<IImpuesto, Medicamentos>();


            services.Configure<ImpuestoOptions>(
                configuration.GetSection(
                    ImpuestoOptions.Fact.SectionName
                )
            );

            return services;
        }
    }
}
