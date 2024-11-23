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

        private void btnNuevoVuelo_Click(object sender, EventArgs e)
        {
            using (var form = new FormVueloABM())
            {
                form.Text = "Alta de vuelo";
                var result = form.ShowDialog(); // Mostramos el formulario como modal
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Se cerró el formulario con OK.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var rowsSeleccionadas = dgvVuelos.SelectedRows;
            if (rowsSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un vuelo.");
                return;
            }

            try
            {
                var vuelo = (VistaVuelo)rowsSeleccionadas[0].DataBoundItem;

                using (var form = new FormVueloABM(vuelo))
                {
                    form.Text = "Modificación de vuelo";
                    var result = form.ShowDialog(); // Mostramos el formulario como modal
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Se cerró el formulario con OK.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar cargar el vuelo.");
            }

        }
    }
}
