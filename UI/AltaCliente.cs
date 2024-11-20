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
    public partial class AltaCliente : Form
    {
        private ClienteBLL clienteBLL;

        public AltaCliente()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
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
                    TelefonoEmergencia = textTelEmergencia.Text
                };

                clienteBLL.CrearCliente(nuevoCliente);

                MessageBox.Show("Cliente creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
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
