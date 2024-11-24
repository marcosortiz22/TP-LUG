using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormAeronavesAlta : Form
    {
        FormAeronaves FAeronavePpal;
        List<Aeronave> LBorrador = new List<Aeronave>();
        AeronaveBLL aeronaveBLO = new AeronaveBLL();
        public FormAeronavesAlta(FormAeronaves formAeronaves)
        {
            FAeronavePpal = formAeronaves;
            InitializeComponent();
        }

        private void FormAeronaveAlta_Load(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                Aeronave aeronaveAlta = new Aeronave();
                aeronaveAlta.Matricula = txt_Matricula.Text;
                aeronaveAlta.Marca = txt_Marca.Text;
                aeronaveAlta.Modelo = txt_Modelo.Text;
                if (!decimal.TryParse(txt_Revision100Hs.Text, out decimal horasRevision)) throw new Exception("La cantidad de horas de la revision debe ser un valor decimal");
                aeronaveAlta.Revision100Hs = horasRevision;
                aeronaveAlta.FechaRevisionAnual = Convert.ToDateTime(dateTimePickerRevisionAnual.Value).Date;
                aeronaveBLO.AltaAeronave(aeronaveAlta);

                MessageBox.Show("Alta Exitosa");
                LimpiarTxt();
                FAeronavePpal.CargarGrillaAeronaves();
                FAeronavePpal.CargarGrillaAeronavesTaller();
                FAeronavePpal.CargarCmBoxAeronavesDisp();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarTxt()
        {
            txt_Marca.Text = null;
            txt_Matricula.Text = null;
            txt_Modelo.Text = null;
            txt_Revision100Hs.Text = null;
        }

        private void btn_AltaBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                Aeronave aeronaveAlta = new Aeronave();
                aeronaveAlta.Matricula = txt_Matricula.Text;
                aeronaveAlta.Marca = txt_Marca.Text;
                aeronaveAlta.Modelo = txt_Modelo.Text;
                if (!decimal.TryParse(txt_Revision100Hs.Text, out decimal horasRevision)) throw new Exception("La cantidad de horas de la revision debe ser un valor decimal");
                aeronaveAlta.Revision100Hs = horasRevision;
                aeronaveAlta.FechaRevisionAnual = Convert.ToDateTime(dateTimePickerRevisionAnual.Value).Date;
                LBorrador.Add(aeronaveAlta);
                ActualizarGrillaBorrador();
                LimpiarTxt();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarGrillaBorrador()
        {
            try
            {
                dgv_ListaBorrador.DataSource = null;
                if (LBorrador.Count > 0)
                {
                    dgv_ListaBorrador.DataSource = LBorrador;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ConfirmarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBorrador.Count < 1) throw new Exception("La lista borrador no tiene elementos para dar alta");
                aeronaveBLO.AltaListaBorrador(LBorrador);
                LBorrador.Clear();
                ActualizarGrillaBorrador();
                FAeronavePpal.CargarGrillaAeronaves();
                FAeronavePpal.CargarGrillaAeronavesTaller();
                FAeronavePpal.CargarCmBoxAeronavesDisp();
                MessageBox.Show("Alta de lista borrador Exitosa");
            }
            catch (Exception ex)
            {
                LBorrador.Clear();
                ActualizarGrillaBorrador();
                MessageBox.Show(ex.Message);

                MessageBox.Show(" Se ha limpiado la lista borrador");
            }
        }
    }
}
