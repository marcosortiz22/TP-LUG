using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPago : Form
    {
        private readonly ClienteBLL clienteBLL = new ClienteBLL();
        private readonly PagoBLL pagoBLL = new PagoBLL();
        FormVuelos formVuelos;

        public FormPago(FormVuelos formVuelosPpal)
        {
            InitializeComponent();
            formVuelos = formVuelosPpal;
            CargarClientesEnComboBox();
            CargarPagosEnGrid();

            textCantidadHora.TextChanged += TextFields_TextChanged;
            textValorHora.TextChanged += TextFields_TextChanged;
            comboCliente.SelectedIndexChanged += ComboCliente_SelectedIndexChanged;
        }

        private void CargarClientesEnComboBox()
        {
            try
            {
                var listaClientes = clienteBLL.ObtenerClientesActivos();

                listaClientes.Insert(0, new Cliente { IdCliente = 0, Nombre = "Seleccione", Apellido = "un cliente" });

                comboCliente.DataSource = listaClientes;
                comboCliente.DisplayMember = "NombreCompleto";
                comboCliente.ValueMember = "IdCliente";

                comboCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPagosEnGrid()
        {
            try
            {
                var listaPagos = pagoBLL.ObtenerTodosVistaPago();
                dataGridViewPagos.DataSource = listaPagos;

                //dataGridViewPagos.Columns["Cliente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los pagos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboCliente.SelectedValue != null && int.TryParse(comboCliente.SelectedValue.ToString(), out int idCliente) && idCliente > 0)
                {
                    var cliente = clienteBLL.ObtenerClientePorId(idCliente);
                    txtSaldoHorasCliente.Text = cliente?.SaldoHoras.ToString("F2") ?? "0.00";
                }
                else
                {
                    txtSaldoHorasCliente.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el saldo del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCrearPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textFactura.Text, out int nroFactura))
                {
                    MessageBox.Show("Por favor, ingrese un número de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboCliente.SelectedValue == null || (int)comboCliente.SelectedValue == 0)
                {
                    MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idClienteSeleccionado = (int)comboCliente.SelectedValue;

                Pago nuevoPago = new Pago
                {
                    Cliente = new Cliente { IdCliente = idClienteSeleccionado },
                    NroFactura = nroFactura,
                    CantidadHoras = Convert.ToDecimal(textCantidadHora.Text),
                    ValorHora = Convert.ToDecimal(textValorHora.Text)
                };

                nuevoPago.CalcularMonto(nuevoPago.CantidadHoras, nuevoPago.ValorHora);

                pagoBLL.CrearPago(nuevoPago);

                MessageBox.Show("Pago creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarPagosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextFields_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textCantidadHora.Text, out decimal cantidadHoras) &&
                decimal.TryParse(textValorHora.Text, out decimal valorHora))
            {
                textTotal.Text = (cantidadHoras * valorHora).ToString("F2");
            }
            else
            {
                textTotal.Clear();
            }
        }

        private void LimpiarFormulario()
        {
            textFactura.Clear();
            textCantidadHora.Clear();
            textValorHora.Clear();
            textTotal.Clear();
            comboCliente.SelectedIndex = 0;
            txtSaldoHorasCliente.Clear();
        }

        private void BtnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPagos.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewPagos.SelectedRows[0];
                    int nroFactura = (int)selectedRow.Cells["NroFactura"].Value;

                    pagoBLL.EliminarPago(nroFactura);

                    MessageBox.Show("Pago eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPagosEnGrid();
                    LimpiarFormulario();

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pago para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
