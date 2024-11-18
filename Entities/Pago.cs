namespace Entities;

public class Pago
{
    public int NroFactura { get; set; }
    public Cliente Cliente { get; set; }
    public int? CantidadHoras { get; set; }
    public decimal? ValorHora { get; set; }
    public decimal? MontoPago { get; set; }
}
