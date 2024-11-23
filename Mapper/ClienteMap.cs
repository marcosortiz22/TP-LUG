using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class ClienteMap
    {
        public static void MapearCliente(SqlCommand command, Cliente cliente)
        {
            command.Parameters.AddWithValue("@Dni", cliente.Dni);
            command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            command.Parameters.AddWithValue("@TelefonoEmergencia", cliente.TelefonoEmergencia);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Brevet", cliente.Brevet ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Activo", cliente.Activo);

            if (command.CommandText.Contains("UPDATE"))
            {
                command.Parameters.AddWithValue("@SaldoHoras", cliente.SaldoHoras);
            }
        }

        public static Cliente MapearDesdeReader(SqlDataReader reader)
        {
            return new Cliente
            {
                IdCliente = reader.GetInt32(reader.GetOrdinal("ID_CLIENTE")),
                Dni = reader.GetInt32(reader.GetOrdinal("DNI")),
                Nombre = reader.IsDBNull(reader.GetOrdinal("NOMBRE")) ? string.Empty : reader.GetString(reader.GetOrdinal("NOMBRE")),
                Apellido = reader.IsDBNull(reader.GetOrdinal("APELLIDO")) ? string.Empty : reader.GetString(reader.GetOrdinal("APELLIDO")),
                Telefono = reader.IsDBNull(reader.GetOrdinal("TELEFONO")) ? string.Empty : reader.GetString(reader.GetOrdinal("TELEFONO")),
                TelefonoEmergencia = reader.IsDBNull(reader.GetOrdinal("TELEFONO_EMERGENCIA")) ? string.Empty : reader.GetString(reader.GetOrdinal("TELEFONO_EMERGENCIA")),
                Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? string.Empty : reader.GetString(reader.GetOrdinal("EMAIL")),
                Brevet = reader.IsDBNull(reader.GetOrdinal("BREVET")) ? null : reader.GetString(reader.GetOrdinal("BREVET")),
                Activo = reader.IsDBNull(reader.GetOrdinal("ACTIVO")) ? false : reader.GetBoolean(reader.GetOrdinal("ACTIVO")),
                SaldoHoras = reader.IsDBNull(reader.GetOrdinal("SALDO_HORAS")) ? 0 : reader.GetDecimal(reader.GetOrdinal("SALDO_HORAS"))
            };
        }
    }
}
