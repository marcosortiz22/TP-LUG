using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entity;
using Mapper;

namespace DAL
{
    public class ClienteData
    {
            string conexionDB = ConfigationDB.ObtenerConexionDB().ToString();
        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "INSERT INTO CLIENTE (DNI, NOMBRE, APELLIDO, TELEFONO, TELEFONO_EMERGENCIA, EMAIL, BREVET, ACTIVO) " +
                                   "VALUES (@Dni, @Nombre, @Apellido, @Telefono, @TelefonoEmergencia, @Email, @Brevet, @Activo)";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        ClienteMap.MapearCliente(command, cliente);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar cliente: " + ex.Message, ex);
            }
        }

        public Cliente ObtenerClientePorId(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "SELECT ID_CLIENTE, DNI, NOMBRE, APELLIDO, TELEFONO, TELEFONO_EMERGENCIA, EMAIL, BREVET, ACTIVO " +
                                   "FROM CLIENTE WHERE ID_CLIENTE = @Id";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return ClienteMap.MapearDesdeReader(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente por ID: " + ex.Message, ex);
            }
        }

        public List<Cliente> ObtenerTodos()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();

                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "SELECT ID_CLIENTE, DNI, NOMBRE, APELLIDO, TELEFONO, TELEFONO_EMERGENCIA, EMAIL, BREVET, ACTIVO " +
                                   "FROM CLIENTE";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var cliente = ClienteMap.MapearDesdeReader(reader);
                                clientes.Add(cliente);
                            }
                        }
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los clientes: " + ex.Message, ex);
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @Id";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message, ex);
            }
        }

        public void ActualizarCliente(Cliente cliente)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "UPDATE CLIENTE SET DNI = @Dni, NOMBRE = @Nombre, APELLIDO = @Apellido, TELEFONO = @Telefono, " +
                                   "TELEFONO_EMERGENCIA = @TelefonoEmergencia, EMAIL = @Email, BREVET = @Brevet, ACTIVO = @Activo " +
                                   "WHERE ID_CLIENTE = @Id";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        ClienteMap.MapearCliente(command, cliente);
                        command.Parameters.AddWithValue("@Id", cliente.IdCliente);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message, ex);
            }
        }

        public void ActualizarSaldoHoras(int id, decimal saldoHoras)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(conexionDB))
                {
                    conexion.Open();

                    string query = "UPDATE CLIENTE SET SALDO_HORAS = @SaldoHoras WHERE ID_CLIENTE = @Id";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@SaldoHoras", saldoHoras);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar horas cliente: " + ex.Message, ex);
            }
        }
    }
}
