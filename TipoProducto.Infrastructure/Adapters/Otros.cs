using TipoProducto.Domain.Enums;
using TipoProducto.Domain.Options;
using TipoProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace TipoProducto.Infrastructure.Adapters
{
    public sealed record class Otros : IImpuesto
    {
        private readonly ImpuestoOptions impuestoOptions;

        public Otros(IOptions<ImpuestoOptions> impuestoOptions)
        {
            this.impuestoOptions = impuestoOptions.Value;
        }

        public TipoCategoria Categoria => TipoCategoria.Otros;
        public double Impuesto() => impuestoOptions.Otro;
    }
}
