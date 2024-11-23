using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class InstructorMap
    {
        public static void MapearInstructor(SqlCommand command, Instructor instructor)
        {
            command.Parameters.AddWithValue("@Dni", instructor.Dni);
            command.Parameters.AddWithValue("@Nombre", instructor.Nombre);
            command.Parameters.AddWithValue("@Apellido", instructor.Apellido);
            command.Parameters.AddWithValue("@Brevet", instructor.Brevet ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Activo", instructor.Activo);
        }

        public static Instructor MapearDesdeReader(SqlDataReader reader)
        {
            return new Instructor
            {
                IdInstructor = reader.GetInt32(reader.GetOrdinal("ID_INSTRUCTOR")),
                Dni = reader.GetInt32(reader.GetOrdinal("DNI")),
                Nombre = reader.IsDBNull(reader.GetOrdinal("NOMBRE")) ? string.Empty : reader.GetString(reader.GetOrdinal("NOMBRE")),
                Apellido = reader.IsDBNull(reader.GetOrdinal("APELLIDO")) ? string.Empty : reader.GetString(reader.GetOrdinal("APELLIDO")),             
                Brevet = reader.IsDBNull(reader.GetOrdinal("BREVET")) ? null : reader.GetString(reader.GetOrdinal("BREVET")),
                Activo = reader.IsDBNull(reader.GetOrdinal("ACTIVO")) ? false : reader.GetBoolean(reader.GetOrdinal("ACTIVO"))
            };
        }

    }
}
