using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        private ClienteBLL clienteBLL;

        public Form1()
        {
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
            AltaCliente NuevoCliente = new AltaCliente(this);
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

                ActualizarCliente actualizarForm = new ActualizarCliente(clienteSeleccionado)
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

                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    clienteBLL.EliminarCliente(idCliente);

                    ActualizarDgvClientes();

                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
