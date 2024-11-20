using BLL;
using Entity;


namespace UI
{
    public partial class ActualizarCliente : Form
    {
        private Cliente clienteActual;
        private ClienteBLL clienteBLL;

        public ActualizarCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteActual = cliente;
            clienteBLL = new ClienteBLL();

            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            textDNI.Text = clienteActual.Dni.ToString();
            textNombre.Text = clienteActual.Nombre;
            textApellido.Text = clienteActual.Apellido;
            textTelefono.Text = clienteActual.Telefono;
            textEmail.Text = clienteActual.Email;
            textBrevet.Text = clienteActual.Brevet;
            textHoras.Text = clienteActual.SaldoHoras.ToString();
            textTelEmergencia.Text = clienteActual.TelefonoEmergencia;
            checkBox1.Checked = clienteActual.Activo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteActual.Dni = Convert.ToInt32(textDNI.Text);
                clienteActual.Nombre = textNombre.Text;
                clienteActual.Apellido = textApellido.Text;
                clienteActual.Telefono = textTelefono.Text;
                clienteActual.Email = textEmail.Text;
                clienteActual.Brevet = textBrevet.Text;
                clienteActual.SaldoHoras = Convert.ToDecimal(textHoras.Text);
                clienteActual.TelefonoEmergencia = textTelEmergencia.Text;
                clienteActual.Activo = checkBox1.Checked;

                clienteBLL.ActualizarCliente(clienteActual);

                Form1 formPrincipal = (Form1)this.Owner;
                formPrincipal.ActualizarDgvClientes();

                this.Close();

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
