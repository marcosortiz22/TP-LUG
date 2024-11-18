namespace Entities;

public class Vuelo
{
    public int CodVuelo { get; set; }
    public DateTime? FechaVuelo { get; set; }
    public Instructor Instructor { get; set; }
    public Cliente Cliente { get; set; }
    public Aeronave Aeronave { get; set; }
    public Finalidad Finalidad { get; set; }
    public TimeSpan HoraPm { get; set; }
    public TimeSpan HoraCorte { get; set; }
    public decimal? HubInicial { get; set; }
    public decimal? HubFinal { get; set; }
    public decimal? HubDiff { get; set; }
    public double? Tv { get; set; }
}