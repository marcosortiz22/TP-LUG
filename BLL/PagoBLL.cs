using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class PagoBLL
    {
          
        private readonly PagoData pagoData = new PagoData();
        private readonly ClienteBLL clienteBll = new();

        public void CrearPago(Pago pago)
        {
            try
            {
                ValidarPago(pago);

                using (TransactionScope trx = new TransactionScope())
                {
                    pago.CalcularMonto(pago.CantidadHoras, pago.ValorHora);

                    pagoData.CrearPago(pago);

                    var clienteActual = clienteBll.ObtenerClientePorId(pago.Cliente.IdCliente);
                    if (clienteActual == null)
                    {
                        throw new Exception($"No se encontró el cliente con ID {pago.Cliente.IdCliente}.");
                    }

                    decimal nuevoSaldoHoras = clienteActual.SaldoHoras + pago.CantidadHoras;

                    clienteBll.ActualizarSaldoHoras(pago.Cliente.IdCliente, nuevoSaldoHoras);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el pago y actualizar el saldo del cliente: " + ex.Message, ex);
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

        public void EliminarPago(int nroFactura)
        {
            try
            {
                if (nroFactura <= 0)
                {
                    throw new ArgumentException("El número de factura debe ser mayor a 0.");
                }

                var pago = pagoData.ObtenerPagoPorId(nroFactura);
                if (pago == null)
                {
                    throw new Exception($"No se encontró un pago con el número de factura {nroFactura}.");
                }

                var horasDescontar = pago.CantidadHoras * -1;

                using (TransactionScope trx = new TransactionScope())
                {
                    clienteBll.DevolverSaldoHoras(pago.Cliente.IdCliente, horasDescontar);

                    pagoData.EliminarPago(nroFactura);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el pago: " + ex.Message, ex);
            }
        }

        private void ValidarPago(Pago pago)
        {
            if (pago == null)
            {
                throw new ArgumentNullException(nameof(pago), "El objeto pago no puede ser nulo.");
            }

            if (pago.Cliente == null || pago.Cliente.IdCliente <= 0)
            {
                throw new ArgumentException("El cliente asociado al pago no es válido.");
            }

            if (pago.NroFactura <= 0)
            {
                throw new ArgumentException("El número de factura debe ser mayor a 0.");
            }
            var pagoExistente = pagoData.ObtenerPagoPorId(pago.NroFactura);
            if (pagoExistente != null)
            {
                throw new Exception($"Ya existe un pago con el número de factura {pago.NroFactura}.");
            }

            if (pago.ValorHora <= 0)
            {
                throw new ArgumentException("El valor por hora debe ser mayor a 0.");
            }

            var montoCalculado = pago.CantidadHoras * pago.ValorHora;
            if (montoCalculado <= 0)
            {
                throw new Exception("El monto total del pago no es válido.");
            }
        }

    }
}
    

