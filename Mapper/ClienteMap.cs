using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            command.Parameters.AddWithValue("@TelefonoEmergencia", cliente.TelefonoEnergencia);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Brevet", cliente.Brevet);
        }

        public static Cliente MapearDesdeReader(SqlDataReader reader)
        {
            return new Cliente
            {
                IdCliente = reader.GetInt32(reader.GetOrdinal("ID_CLIENTE")),
                Dni = reader.GetInt32(reader.GetOrdinal("DNI")),
                Nombre = reader.GetString(reader.GetOrdinal("NOMBRE")),
                Apellido = reader.GetString(reader.GetOrdinal("APELLIDO")),
                Telefono = reader.GetString(reader.GetOrdinal("TELEFONO")),
                TelefonoEnergencia = reader.GetString(reader.GetOrdinal("TELEFONO_EMERGENCIA")),
                Email = reader.GetString(reader.GetOrdinal("EMAIL")),
                Brevet = reader.GetString(reader.GetOrdinal("BREVET")),
                Activo = reader.GetBoolean(reader.GetOrdinal("ACTIVO"))
            };
        }
    }
}
