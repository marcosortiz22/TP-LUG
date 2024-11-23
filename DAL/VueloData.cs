using Entity;
using Mapper;
using System.Data.SqlClient;

namespace DAL;

public class VueloData
{
    private readonly string conexionDB = ConfigationDB.ObtenerConexionDB().ToString();

    public void AgregarVuelo(Vuelo vuelo)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(conexionDB))
            {
                conexion.Open();

                string query = "INSERT INTO VUELO (FECHA_VUELO, ID_INSTRUCTOR, ID_CLIENTE, MATRICULA_AERONAVE, COD_FINALIDAD, HORA_PM, HORA_CORTE, HUB_INICIAL, HUB_FINAL) " +
                               "VALUES (@FechaVuelo, @IdInstructor, @IdCliente, @MatriculaAeronave, @CodFinalidad, @HoraPM, @HoraCorte, @HubInicial, @HubFinal)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    VueloMap.MapearVuelo(command, vuelo);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al agregar vuelo: " + ex.Message, ex);
        }
    }

    public Vuelo ObtenerVueloPorCod(int cod)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(conexionDB))
            {
                conexion.Open();

                string query = " SELECT COD_VUELO, FECHA_VUELO, ID_INSTRUCTOR, MATRICULA_AERONAVE, COD_FINALIDAD, HORA_PM, HORA_CORTE, HUB_INICIAL, HUB_FINAL, " +
                               " ID_CLIENTE, DNI, NOMBRE, APELLIDO, TELEFONO, TELEFONO_EMERGENCIA, EMAIL, BREVET, ACTIVO " +
                               " FROM VUELO V INNER JOIN CLIENTE C ON V.ID_CLIENTE = C.ID_CLIENTE " +
                               " WHERE COD_VUELO = @Cod ";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Cod", cod);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return VueloMap.MapearDesdeReader(reader);
                        }
                    }
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener vuelo por ID: " + ex.Message, ex);
        }
    }

    public List<Vuelo> ObtenerTodos()
    {
        try
        {
            List<Vuelo> vuelos = new List<Vuelo>();

            using (SqlConnection conexion = new SqlConnection(conexionDB))
            {
                conexion.Open();

                string query = @"SELECT V.COD_VUELO, V.FECHA_VUELO, V.ID_INSTRUCTOR, V.ID_CLIENTE, V.MATRICULA_AERONAVE, V.COD_FINALIDAD, 
                                        V.HORA_PM, V.HORA_CORTE, V.HUB_INICIAL, V.HUB_FINAL,
                                        C.DNI AS ClienteDNI, C.NOMBRE AS ClienteNombre, C.APELLIDO AS ClienteApellido, 
                                        C.TELEFONO AS ClienteTelefono, C.EMAIL AS ClienteEmail, C.BREVET AS ClienteBrevet,
                                        I.DNI AS InstructorDNI, I.NOMBRE AS InstructorNombre, I.APELLIDO AS InstructorApellido, I.BREVET AS InstructorBrevet,
                                        A.MARCA_AERONAVE, A.MODELO_AERONAVE, A.REVISION_100HS,
                                        F.DESCRIPCION
                                    FROM VUELO V
                                    LEFT JOIN CLIENTE C ON V.ID_CLIENTE = C.ID_CLIENTE
                                    LEFT JOIN INSTRUCTOR I ON V.ID_INSTRUCTOR = I.ID_INSTRUCTOR
                                    LEFT JOIN AERONAVE A ON V.MATRICULA_AERONAVE = A.MATRICULA_AERONAVE
                                    LEFT JOIN FINALIDAD F ON V.COD_FINALIDAD = F.COD_FINALIDAD";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var vuelo = VueloMap.MapearDesdeReader(reader);
                            vuelos.Add(vuelo);
                        }
                    }
                }
            }
            return vuelos;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener todos los vuelos: " + ex.Message, ex);
        }
    }

    public void EliminarVuelo(int cod)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(conexionDB))
            {
                conexion.Open();

                string query = "DELETE FROM VUELO WHERE COD_VUELO = @Cod";
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Cod", cod);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar vuelo: " + ex.Message, ex);
        }
    }

    public void ActualizarVuelo(Vuelo vuelo)
    {
        try
        {
            using (SqlConnection conexion = new SqlConnection(conexionDB))
            {
                conexion.Open();

                string query = "UPDATE VUELO SET FECHA_VUELO = @FechaVuelo, ID_INSTRUCTOR = @IdInstructor, ID_CLIENTE = @IdCliente, " +
                               "MATRICULA_AERONAVE = @MatriculaAeronave, COD_FINALIDAD = @CodFinalidad, HORA_PM = @HoraPM, " +
                               "HORA_CORTE = @HoraCorte, HUB_INICIAL = @HubInicial, HUB_FINAL = @HubFinal " +
                               "WHERE COD_VUELO = @CodVuelo";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    VueloMap.MapearVuelo(command, vuelo);
                    command.Parameters.AddWithValue("@CodVuelo", vuelo.CodVuelo);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al actualizar vuelo: " + ex.Message, ex);
        }
    }
}
