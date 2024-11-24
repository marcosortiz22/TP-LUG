using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormAeronaves : Form
    {

        AeronaveBLL aeronaveBLO = new AeronaveBLL();
        FinalidadBLL finalidadBLO = new FinalidadBLL();
        FormVuelos formVuelos;
        public FormAeronaves(FormVuelos formVuelosPpal)
        {
            InitializeComponent();
            formVuelos = formVuelosPpal;
        }

        private void FormAeronaves_Load(object sender, EventArgs e)
        {
            CargarGrillaAeronaves();
            CargarGrillaAeronavesTaller();
            CargarCmBoxAeronavesDisp();
            CargarCmbBoxFinalidadTeat();
        }

        private void CargarCmbBoxFinalidadTeat()
        {
            try
            {
                comboBox1.DataSource = null;
                if (finalidadBLO.ObtenerFinalidadesActivas(finalidadBLO.ObtenerFinalidades()).Count > 0)
                {
                    comboBox1.DataSource = finalidadBLO.ObtenerFinalidadesActivas(finalidadBLO.ObtenerFinalidades());
                    comboBox1.ValueMember = "CodigoFinalidad";
                    comboBox1.Format += (sender, e) =>
                    {
                        if (e.ListItem is Finalidad finalidad)
                        {
                            e.Value = $"{finalidad.CodigoFinalidad} - {finalidad.Descripcion}";
                        }
                    };
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCmBoxAeronavesDisp()
        {
            try
            {
                cmBox_AeronavesDisp.DataSource = null;
                if (aeronaveBLO.AeronavesDispoibles(aeronaveBLO.ObtenerAeronaves()).Count() > 0)
                {
                    cmBox_AeronavesDisp.DataSource = (aeronaveBLO.AeronavesDispoibles(aeronaveBLO.ObtenerAeronaves()));
                    cmBox_AeronavesDisp.ValueMember = "Matricula";
                    cmBox_AeronavesDisp.Format += (sender, e) =>
                    {
                        if (e.ListItem is Aeronave aeronave)
                        {
                            e.Value = $"{aeronave.Matricula} - {aeronave.Modelo}";
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarGrillaAeronaves()
        {
            try
            {
                dgv_Aeronaves.DataSource = null;
                if (aeronaveBLO.ObtenerAeronaves().Count > 0)
                {
                    dgv_Aeronaves.DataSource = aeronaveBLO.ObtenerAeronaves();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CargarGrillaAeronavesTaller()
        {
            try
            {
                dgv_AeronavesTaller.DataSource = null;
                if (aeronaveBLO.AeronavesDispoibles(aeronaveBLO.ObtenerAeronaves()).Count > 0)
                {
                    dgv_AeronavesTaller.DataSource = aeronaveBLO.AeronavesService(aeronaveBLO.ObtenerAeronaves());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void btn_AltaAeronave_Click(object sender, EventArgs e)
        {
            try
            {
                FormAeronavesAlta formAltas = new FormAeronavesAlta(this);
                formAltas.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ModificarAeronave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Aeronaves.Rows.Count < 1) throw new Exception("No hay aeronaves para modificar");
                if (dgv_Aeronaves.SelectedRows.Count < 1) throw new Exception("Debe seleccionar una aeronave a modificar");
                Aeronave aeronaveMod = new Aeronave();
                aeronaveMod = dgv_Aeronaves.SelectedRows[0].DataBoundItem as Aeronave;

                FormAeronavesMod formModificarAeronave = new FormAeronavesMod(this, aeronaveMod);
                formModificarAeronave.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_EliminarAeronave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Aeronaves.Rows.Count < 1) throw new Exception("No hay aeronaves para eliminar");
                if (dgv_Aeronaves.SelectedRows.Count < 1) throw new Exception("Debe seleccionar una aeronave a eliminar");
                Aeronave aeronaveMod = new Aeronave();
                aeronaveMod = dgv_Aeronaves.SelectedRows[0].DataBoundItem as Aeronave;
                aeronaveBLO.EliminarAeronavePorMatricula(aeronaveMod.Matricula);
                CargarGrillaAeronaves();
                CargarGrillaAeronavesTaller();
                CargarCmBoxAeronavesDisp();
                MessageBox.Show("Eliminacion exitosa");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_RealizarService_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_AeronavesTaller.Rows.Count < 1) throw new Exception("No hay aeronaves para eliminar");
                if (dgv_AeronavesTaller.SelectedRows.Count < 1) throw new Exception("Debe seleccionar una aeronave a eliminar");
                Aeronave aeronaveMod = new Aeronave();
                aeronaveMod = dgv_AeronavesTaller.SelectedRows[0].DataBoundItem as Aeronave;
                aeronaveMod.Revision100Hs = 0;
                aeronaveBLO.ActualizarService100Hs(aeronaveMod.Matricula, aeronaveMod.Revision100Hs);
                CargarGrillaAeronaves();
                CargarGrillaAeronavesTaller();
                CargarCmBoxAeronavesDisp();
                MessageBox.Show("Service Exitoso");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Service Realizado Correctamente");
            }
        }
    }
}
