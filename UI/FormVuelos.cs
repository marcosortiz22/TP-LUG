using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormVuelos : Form
    {
        private VueloBLL _vueloBLO;
        public FormVuelos()
        {
            _vueloBLO = new VueloBLL();
            InitializeComponent();
        }

        private void FormVuelos_Load(object sender, EventArgs e)
        {
            var vuelos = _vueloBLO.ObtenerTodosVista();
            dgvVuelos.DataSource = vuelos;
        }
        public void ActualizarGrillaVuelos()
        {
            var vuelos = _vueloBLO.ObtenerTodosVista();
            dgvVuelos.DataSource = vuelos;
        }

        private void btnNuevoVuelo_Click(object sender, EventArgs e)
        {
            using (var form = new FormVuelosABM())
            {
                form.Text = "Alta de vuelo";
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Se cerró el formulario con OK.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowsSeleccionadas;

            rowsSeleccionadas = dgvVuelos.SelectedRows;
            if (rowsSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un vuelo.");
                return;
            }

            try
            {
                var vuelo = (VistaVuelo)rowsSeleccionadas[0].DataBoundItem;

                using (var form = new FormVuelosABM(vuelo))
                {
                    form.Text = "Modificación de vuelo";
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ActualizarGrillaVuelos();
                    }
                    form.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar cargar el vuelo.");
            }

        }

        private void btn_FormClientes_Click(object sender, EventArgs e)
        {
            try
            {
                FormCliente formCliente = new FormCliente(this);
                formCliente.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_FormInstructores_Click(object sender, EventArgs e)
        {
            try
            {
                FormInstructor formInstructor = new FormInstructor(this);
                formInstructor.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_FormAeronaves_Click(object sender, EventArgs e)
        {
            try
            {
                FormAeronaves formAeronaves = new FormAeronaves(this);
                formAeronaves.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_FormPagos_Click(object sender, EventArgs e)
        {
            try
            {
                FormPago formPago = new FormPago(this);
                formPago.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowsSeleccionadas;
            rowsSeleccionadas = dgvVuelos.SelectedRows;
            if (rowsSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un vuelo.");
                return;
            }

            try
            {
                var vuelo = (VistaVuelo)rowsSeleccionadas[0].DataBoundItem;

                using (var form = new FormVuelosABM(vuelo,true))
                {
                    form.Text = "Eliminar vuelo";
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ActualizarGrillaVuelos();
                    }
                    form.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar cargar el vuelo.");
            }

        }

    }
}
