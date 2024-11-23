namespace Entity;

public class VistaVuelo
{
    public int CodVuelo { get; set; }
    public DateTime FechaVuelo { get; set; }
    public string CodFinalidad { get; set; }
    public string MatriculaAeronave { get; set; }
    public TimeOnly HoraPM { get; set; }
    public TimeOnly HoraCorte { get; set; }
    public decimal HubInicial { get; set; }
    public decimal HubFinal { get; set; }
    public int IdCliente { get; set; }
    public int ClienteDNI { get; set; }
    public string ClienteNombreApellido { get; set; }
    public int IdInstructor { get; set; }
    public int InstructorDNI { get; set; }
    public string InstructorNombreApellido { get; set; }
}