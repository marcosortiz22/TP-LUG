namespace Entity;

public class Vuelo
{
    public int CodVuelo { get; set; }
    public DateTime FechaVuelo { get; set; }
    public Instructor InstructorVuelo { get; set; }
    public Cliente ClientVuelo { get; set; }
    public Aeronave AeronaveVuelo { get; set; }
    public Finalidad FinalidadVuelo { get; set; }
    public TimeOnly HoraPM { get; set; }
    public TimeOnly HoraCorte { get; set; }
    public decimal TV => CalculateTv();

    public decimal HubInicial { get; set; }

    public decimal HubFinal { get; set; }

    public decimal HubDiff => HubFinal - HubInicial;

    private decimal CalculateTv() {
        // Calcular la diferencia de tiempo considerando la posibilidad de cambio de día
        var horaCorteTimeSpan = HoraCorte.ToTimeSpan();
        var horaPmTimeSpan = HoraPM.ToTimeSpan();
        var diferenciaMinutos = (horaCorteTimeSpan - horaPmTimeSpan).TotalMinutes;

                if (diferenciaMinutos< 0) // Si la hora de corte es el día siguiente
                {
                    diferenciaMinutos += TimeSpan.FromDays(1).TotalMinutes;
                }

                var horasCompletas = (int)diferenciaMinutos / 60;
        var minutosResiduales = (int)diferenciaMinutos % 60;

        var ajuste = minutosResiduales switch
        {
            <= 2 => 0m,
            <= 8 => 0.1m,
            <= 14 => 0.2m,
            <= 20 => 0.3m,
            <= 26 => 0.4m,
            <= 33 => 0.5m,
            <= 39 => 0.6m,
            <= 45 => 0.7m,
            <= 51 => 0.8m,
            <= 57 => 0.9m,
            _ => 1m
        };

        return horasCompletas + ajuste;
    }

}
