using TipoProducto.Domain.Enums;

namespace CategoriaProducto.Domain.Modelos;

public class Producto
{
    public Guid Id { get; set; }
    public double Valor { get; set; }
    public TipoCategoria Categoria { get; set; }
}
