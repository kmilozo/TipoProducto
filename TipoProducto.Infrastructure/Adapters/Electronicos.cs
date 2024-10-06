using TipoProducto.Domain.Enums;
using TipoProducto.Domain.Options;
using TipoProducto.Domain.Ports;
using Microsoft.Extensions.Options;

namespace TipoProducto.Infrastructure.Adapters;

internal sealed record class Electronicos : IImpuesto
{
    private readonly ImpuestoOptions impuestoOptions;

    public Electronicos(IOptions<ImpuestoOptions> impuestoOptions)
    {
        this.impuestoOptions = impuestoOptions.Value;
    }

    public TipoCategoria Categoria => TipoCategoria.Electronicos;

    public double Impuesto() => impuestoOptions.Electronicos;

}

