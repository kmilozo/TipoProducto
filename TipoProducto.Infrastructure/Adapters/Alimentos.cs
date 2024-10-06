using TipoProducto.Domain.Enums;
using TipoProducto.Domain.Options;
using TipoProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace TipoProducto.Infrastructure.Adapters
{
    internal record class Alimentos : IImpuesto
    {
        private readonly ImpuestoOptions impuestoOptions;

        public Alimentos(IOptions<ImpuestoOptions> impuestoOptions)
        {
            this.impuestoOptions = impuestoOptions.Value;
        }

        public TipoCategoria Categoria => TipoCategoria.Alimentos;

        public double Impuesto() => impuestoOptions.Alimento;
    }
}
