using TipoProducto.Domain.Enums;

namespace TipoProducto.Domain.Ports;

public interface IImpuesto
{
    public TipoCategoria Categoria { get; }
    public double Impuesto();
}

