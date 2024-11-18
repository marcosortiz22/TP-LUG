using Entities;
using System.Data.SqlClient;

namespace Mapper;

public static class ClienteMapper
{
    public static Cliente MapReaderACliente(SqlDataReader reader)
    {
        return new Cliente
        {
            IdCliente = (int)reader["ID_CLIENTE"],
            Dni = reader["DNI"] as int?,
            Apellido = reader["APELLIDO"].ToString(),
            Nombre = reader["NOMBRE"].ToString(),
            Telefono = reader["TELEFONO"].ToString(),
            TelefonoEmergencia = reader["TELEFONO_EMERGENCIA"].ToString(),
            Email = reader["EMAIL"].ToString(),
            Brevet = reader["BREVET"].ToString(),
            SaldoHoras = reader["SALDO_HORAS"] as int?
        };
    }

    public static Dictionary<string, object> MapClienteAParametros(Cliente cliente)
    {
        return new Dictionary<string, object>
        {
            { "@IdCliente", cliente.IdCliente },
            { "@Dni", cliente.Dni },
            { "@Apellido", cliente.Apellido },
            { "@Nombre", cliente.Nombre },
            { "@Telefono", cliente.Telefono },
            { "@TelefonoEmergencia", cliente.TelefonoEmergencia },
            { "@Email", cliente.Email },
            { "@Brevet", cliente.Brevet },
            { "@SaldoHoras", cliente.SaldoHoras }
        };
    }
}
