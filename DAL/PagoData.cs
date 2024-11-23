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
    public class PagoData
    {
        
        
            private readonly string conexionDB = ConfigationDB.ObtenerConexionDB().ToString();

            public void CrearPago(Pago pago)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(conexionDB))
                    {
                        conexion.Open();

                        string query = "INSERT INTO PAGO (ID_CLIENTE, CANTIDAD_HORAS, VALOR_HORA, MONTO_PAGO) " +
                                       "VALUES (@IdCliente, @CantidadHoras, @ValorHora, @MontoPago)";

                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            PagoMap.MapearPago(command, pago);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el pago: " + ex.Message, ex);
                }
            }

            public Pago ObtenerPagoPorId(int nroFactura)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(conexionDB))
                    {
                        conexion.Open();

                        string query = "SELECT NRO_FACTURA, ID_CLIENTE, CANTIDAD_HORAS, VALOR_HORA, MONTO_PAGO " +
                                       "FROM PAGO WHERE NRO_FACTURA = @NroFactura";

                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            command.Parameters.AddWithValue("@NroFactura", nroFactura);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return PagoMap.MapearDesdeReader(reader);
                                }
                            }
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el pago por ID: " + ex.Message, ex);
                }
            }

            public List<Pago> ObtenerTodosLosPagos()
            {
                try
                {
                    List<Pago> pagos = new List<Pago>();

                    using (SqlConnection conexion = new SqlConnection(conexionDB))
                    {
                        conexion.Open();

                        string query = "SELECT NRO_FACTURA, ID_CLIENTE, CANTIDAD_HORAS, VALOR_HORA, MONTO_PAGO " +
                                       "FROM PAGO";

                        using (SqlCommand command = new SqlCommand(query, conexion))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var pago = PagoMap.MapearDesdeReader(reader);
                                    pagos.Add(pago);
                                }
                            }
                        }
                    }
                    return pagos;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener todos los pagos: " + ex.Message, ex);
                }
            }
        }
    }


