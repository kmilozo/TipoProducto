using TipoProducto.Domain.Modelos;
using TipoProducto.Domain.Servicios;
using MediatR;

namespace TipoProducto.Application.Carateristicas.Comandos.Productos.ProductoConImpuesto;

internal sealed record class ProductoConImpuestoCommandHandler
    : IRequestHandler<ProductoConImpuestoCommand, RespuestaProducto>
{
    private readonly ProductoServicio productoServicio;

    public ProductoConImpuestoCommandHandler(
        ProductoServicio productoServicio)
    {
        this.productoServicio = productoServicio;
    }

    public Task<RespuestaProducto> Handle(
        ProductoConImpuestoCommand request
        , CancellationToken cancellationToken
    )
    {

        return Task.FromResult(
            productoServicio.RespuestaProducto(
                request.ValorProducto
                , request.TipoCategoria
            ));
    }
}
