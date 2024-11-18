namespace Entities;

public class Cliente
{
    public int IdCliente { get; set; }
    public int? Dni { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string TelefonoEmergencia { get; set; }
    public string Email { get; set; }
    public string Brevet { get; set; }
    public int? SaldoHoras { get; set; }
}

