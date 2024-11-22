using BLL;
using DAL;
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
    public partial class FormModificarAeronave : Form
    {
        Aeronave aeronaveModifcar = new Aeronave();
        FormAeronaves FormAeronavePpal = new FormAeronaves();
        AeronaveBLL aeronmaveBLO = new AeronaveBLL();   
        public FormModificarAeronave(FormAeronaves formAeronaves, Aeronave aeronaveMod)
        {
            FormAeronavePpal = formAeronaves;
            aeronaveModifcar = aeronaveMod;
            InitializeComponent();
        }

        private void FormModificarAeronave_Load(object sender, EventArgs e)
        {
            txt_Matricula.Text = aeronaveModifcar.Matricula;
            txt_Marca.Text = aeronaveModifcar.Marca;
            txt_Modelo.Text = aeronaveModifcar.Modelo;
            txt_Revision100Hs.Text = aeronaveModifcar.Revision100Hs.ToString();
            dateTimePickerRevisionAnual.Value = aeronaveModifcar.FechaRevisionAnual;
            checkBoxActivo.Checked = aeronaveModifcar.Activo;

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                aeronaveModifcar.Matricula= txt_Matricula.Text;
                aeronaveModifcar.Marca= txt_Marca.Text;
                aeronaveModifcar.Modelo= txt_Modelo.Text;
                if (!decimal.TryParse(txt_Revision100Hs.Text, out decimal horasRevision)) throw new Exception("La cantidad de horas de la revision debe ser un valor decimal");
                aeronaveModifcar.Revision100Hs = horasRevision;
                aeronaveModifcar.FechaRevisionAnual = Convert.ToDateTime(dateTimePickerRevisionAnual.Value).Date;
                aeronaveModifcar.Activo = checkBoxActivo.Checked;
                aeronmaveBLO.ModificarAeronave(aeronaveModifcar);
                
                
                FormAeronavePpal.CargarGrillaAeronaves();
                FormAeronavePpal.CargarGrillaAeronavesTaller();
                FormAeronavePpal.CargarCmBoxAeronavesDisp();
                MessageBox.Show("Modificacion Exitosa");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
