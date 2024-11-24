using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
   
    
        public static class PagoMap
        {
            public static void MapearPago(SqlCommand command, Pago pago)
            {
                command.Parameters.AddWithValue("@NroFactura", pago.NroFactura);
                command.Parameters.AddWithValue("@IdCliente", pago.Cliente.IdCliente);
                command.Parameters.AddWithValue("@CantidadHoras", pago.CantidadHoras);
                command.Parameters.AddWithValue("@ValorHora", pago.ValorHora);
                command.Parameters.AddWithValue("@MontoPago", pago.MontoPago);
            }

            public static Pago MapearDesdeReader(SqlDataReader reader)
            {
                return new Pago
                {
                    NroFactura = reader.GetInt32(reader.GetOrdinal("NRO_FACTURA")),
                    Cliente = new Cliente { IdCliente = reader.GetInt32(reader.GetOrdinal("ID_CLIENTE")) },
                    CantidadHoras = reader.GetDecimal(reader.GetOrdinal("CANTIDAD_HORAS")),
                    ValorHora = reader.GetDecimal(reader.GetOrdinal("VALOR_HORA")),
                    MontoPago = reader.GetDecimal(reader.GetOrdinal("MONTO_PAGO"))
                };
            }
        }
    }


