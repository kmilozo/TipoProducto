using TipoProducto.Domain.Enums;
using TipoProducto.Domain.Modelos;
using TipoProducto.Domain.Ports;

namespace TipoProducto.Domain.Servicios;

public sealed class ProductoServicio
{
    private const double BASE_PORCENTAJE = 100;
    private readonly IEnumerable<IImpuesto> impuestos;

    public ProductoServicio(
        IEnumerable<IImpuesto> impuestos
    )
    {
        this.impuestos = impuestos;
    }

    private double ImpuestoDelProducto(
        double valorProducto
        , TipoCategoria categoria)
    {
        var impuesto = impuestos
            .Where(impu => impu.Categoria == categoria)
            .FirstOrDefault();

        double porcentaje = impuesto!.Impuesto();

        return valorProducto * porcentaje / BASE_PORCENTAJE;
    }

    private static double ValorFinalConImpuesto(
        double valorProducto
        , double impuestoDelProducto)
    {
        return valorProducto + impuestoDelProducto;
    }

    public RespuestaProducto RespuestaProducto(
        double valorProducto
        , TipoCategoria categoria 
    )
    {
        var impuesto = ImpuestoDelProducto(
            valorProducto
            , categoria
        );

        var valorFinalConImpuesto = ValorFinalConImpuesto(
            valorProducto
            , impuesto
        );

        return new RespuestaProducto(
            valorProducto
            , impuesto
            , valorFinalConImpuesto
        );
    } 
}
