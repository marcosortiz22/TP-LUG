using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PagoBLL
    {
          
        private readonly PagoData pagoData = new PagoData();

        public void CrearPago(Pago pago)
        {
            try
            {
                ValidarPago(pago);

                pago.CalcularMonto(pago.ValorHora, pago.CantidadHoras);

                pagoData.CrearPago(pago);
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
                if (nroFactura <= 0)
                {
                    throw new ArgumentException("El número de factura debe ser mayor a 0.");
                }

                return pagoData.ObtenerPagoPorId(nroFactura)
                       ?? throw new Exception($"No se encontró un pago con el número de factura {nroFactura}.");
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
                return pagoData.ObtenerTodosLosPagos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de pagos: " + ex.Message, ex);
            }
        }

        private void ValidarPago(Pago pago)
        {
        }
    }
}
    

