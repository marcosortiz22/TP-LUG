﻿using BLL;
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
                MessageBox.Show("Service Exitoso");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Service Realizado Correctamente");
            }
        }
    }
}
