using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormClienteAlta : Form
    {
        private ClienteBLL clienteBLL;
        private FormCliente formPrincipal;

        public FormClienteAlta(FormCliente formPrincipal)
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            this.formPrincipal = formPrincipal;
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevoCliente = new Cliente
                {
                    Dni = Convert.ToInt32(textDNI.Text),
                    Nombre = textNombre.Text,
                    Apellido = textApellido.Text,
                    Telefono = textTelefono.Text,
                    Email = textEmail.Text,
                    Brevet = textBrevet.Text,
                    TelefonoEmergencia = textTelEmergencia.Text
                };

                clienteBLL.CrearCliente(nuevoCliente);

                MessageBox.Show("Cliente creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formPrincipal.ActualizarDgvClientes();

                LimpiarFormulario();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            textDNI.Text = string.Empty;
            textNombre.Text = string.Empty;
            textApellido.Text = string.Empty;
            textTelefono.Text = string.Empty;
            textEmail.Text = string.Empty;
            textTelEmergencia.Text = string.Empty;
        }
    }
}
