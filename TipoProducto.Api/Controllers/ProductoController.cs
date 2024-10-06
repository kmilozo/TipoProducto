using TipoProducto.Application.Carateristicas.Comandos.Productos.ProductoConImpuesto;
using TipoProducto.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TipoProducto.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly ILogger<ProductoController> _logger;

    public ProductoController(
        ILogger<ProductoController> logger
        , IMediator mediator
    )
    {
        _logger = logger;
        this.mediator = mediator;
    }

    [HttpPost(Name = "impuesto")]
    public async Task<IActionResult> Get(
        double valorProducto
        , TipoCategoria categoria)
    {
        var request = new ProductoConImpuestoCommand(
            valorProducto
            , categoria
        );

        return Ok(await mediator.Send(request));
    }
}