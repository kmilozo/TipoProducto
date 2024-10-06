using TipoProducto.Domain.Enums;
using TipoProducto.Domain.Modelos;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TipoProducto.Application.Carateristicas.Comandos.Productos.ProductoConImpuesto;

public record ProductoConImpuestoCommand(
    [Required] double ValorProducto
    , [Required] TipoCategoria TipoCategoria
) : IRequest<RespuestaProducto>;
