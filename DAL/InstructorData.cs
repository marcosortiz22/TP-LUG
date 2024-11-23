using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructorData
    {
        string conexionDB = ConfigationDB.ObtenerConexionDB().ToString();
        public void AgregarInstructor(Instructor instructor)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "INSERT INTO INSTRUCTOR (DNI, NOMBRE, APELLIDO, BREVET, ACTIVO) " +
                                   "VALUES (@Dni, @Nombre, @Apellido, @Brevet, @Activo)";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        InstructorMap.MapearInstructor(command, instructor);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar instructor: " + ex.Message, ex);
            }
        }

        public Instructor ObtenerInstructorPorId(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "SELECT ID_INSTRUCTOR, DNI, NOMBRE, APELLIDO, BREVET, ACTIVO " +
                                   "FROM INSTRUCTOR WHERE ID_INSTRUCTOR = @Id";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return InstructorMap.MapearDesdeReader(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener instructor por ID: " + ex.Message, ex);
            }
        }

        public List<Instructor> ObtenerTodos()
        {
            try
            {
                List<Instructor> instructores = new List<Instructor>();

                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "SELECT ID_INSTRUCTOR, DNI, NOMBRE, APELLIDO, BREVET, ACTIVO " +
                                   "FROM INSTRUCTOR";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var instructor = InstructorMap.MapearDesdeReader(reader);
                                instructores.Add(instructor);
                            }
                        }
                    }
                }
                return instructores;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los instructores: " + ex.Message, ex);
            }
        }
        public List<Instructor> ObtenerActivos()
        {
            try
            {
                List<Instructor> instructores = new List<Instructor>();

                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "SELECT ID_INSTRUCTOR, DNI, NOMBRE, APELLIDO, BREVET, ACTIVO " +
                                   "FROM INSTRUCTOR WHERE ACTIVO=1";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var instructor = InstructorMap.MapearDesdeReader(reader);
                                instructores.Add(instructor);
                            }
                        }
                    }
                }
                return instructores;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los instructores: " + ex.Message, ex);
            }
        }

        public void EliminarInstructor(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "UPDATE INSTRUCTOR SET ACTIVO = 0 WHERE ID_INSTRUCTOR = @Id";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar instructor: " + ex.Message, ex);
            }
        }

        public void ActualizarInstructor(Instructor instructor)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "UPDATE INSTRUCTOR SET DNI = @Dni, NOMBRE = @Nombre, APELLIDO = @Apellido, " +
                                   "BREVET = @Brevet, ACTIVO = @Activo " +
                                   "WHERE ID_INSTRUCTOR = @Id";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        InstructorMap.MapearInstructor(command,instructor);
                        command.Parameters.AddWithValue("@Id",instructor.IdInstructor);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar instructor: " + ex.Message, ex);
            }
        }

        public Instructor ObtenerInstrctorPorDNI(int dni)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "SELECT ID_INSTRUCTOR, DNI, NOMBRE, APELLIDO, BREVET, ACTIVO " +
                                   "FROM INSTRUCTOR WHERE DNI = @DNI";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@DNI",dni);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return InstructorMap.MapearDesdeReader(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener instructor por DNI: " + ex.Message, ex);
            }
        }
    }
}
