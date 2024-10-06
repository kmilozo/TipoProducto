namespace TipoProducto.Domain.Options;

public class ImpuestoOptions
{
    public int Alimento { get; set; }
    public int Medicamentos { get; set; }
    public int Electronicos { get; set; }
    public int Otro { get; set; }

    public static class Fact
    {
        public static string SectionName { get => "Impuesto"; }
    }
}
