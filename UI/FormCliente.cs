using BLL;
using Entity;

namespace UI
{
    public partial class FormCliente : Form
    {
        private ClienteBLL clienteBLL;
        FormVuelos formVuelo;

        public FormCliente(FormVuelos formVueloPpal)
        {
            formVuelo = formVueloPpal;
            InitializeComponent();
            clienteBLL = new ClienteBLL();

            this.Load += Form1_Load;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDgvClientes();
        }

        public void ActualizarDgvClientes()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            var clientes = clienteBLL.ObtenerTodosLosClientes();
            dataGridView1.DataSource = clientes;

            dataGridView1.ClearSelection();

            Bajabtn.Enabled = clientes.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClienteAlta NuevoCliente = new FormClienteAlta(this);
            NuevoCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un cliente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idValue = dataGridView1.SelectedRows[0].Cells["IdCliente"].Value;
                if (idValue == null || !int.TryParse(idValue.ToString(), out int idCliente))
                {
                    MessageBox.Show("El ID del cliente seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cliente clienteSeleccionado = clienteBLL.ObtenerClientePorId(idCliente);

                FormClienteActualizar actualizarForm = new FormClienteActualizar(clienteSeleccionado)
                {
                    Owner = this
                };
                actualizarForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Bajabtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idValue = dataGridView1.SelectedRows[0].Cells["IdCliente"].Value;
                if (idValue == null || !int.TryParse(idValue.ToString(), out int idCliente))
                {
                    MessageBox.Show("El ID del cliente seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas desactivar este cliente?", "Confirmar desactivacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    clienteBLL.DesactivarCliente(idCliente);

                    ActualizarDgvClientes();

                    MessageBox.Show("Cliente desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
