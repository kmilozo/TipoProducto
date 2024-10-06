using TipoProducto.Domain.Enums;
using TipoProducto.Domain.Options;
using TipoProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace TipoProducto.Infrastructure.Adapters
{
    internal sealed record class Medicamentos : IImpuesto
    {
        private readonly ImpuestoOptions impuestoOptions;

        public Medicamentos(IOptions<ImpuestoOptions> impuestoOptions)
        {
            this.impuestoOptions = impuestoOptions.Value;
        }

        public TipoCategoria Categoria => TipoCategoria.Medicamentos;

        public double Impuesto() => impuestoOptions.Medicamentos;
    }
}
