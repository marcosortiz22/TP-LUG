using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private ClienteBLL clienteBLL;
        public Form1()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            Form1_Load();
        }

        private void Form1_Load()
        {
            ActualizarDgvClientes();
        }

        private void ActualizarDgvClientes()
        {
            dataGridView1.DataSource = clienteBLL.ObtenerTodosLosClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliente NuevoCliente = new AltaCliente();
            NuevoCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActualizarCliente ModiCliente = new ActualizarCliente();
            ModiCliente.Show();
        }


    }
}
