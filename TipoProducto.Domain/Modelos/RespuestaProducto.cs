namespace TipoProducto.Domain.Modelos;

public record RespuestaProducto(
    double ValorProducto
    , double Impuesto
    , double ValorFinalConImpuesto
);