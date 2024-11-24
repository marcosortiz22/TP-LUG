﻿using BLL;
using Entity;
using System;
using System.Security.AccessControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UI
{
    public partial class FormVuelosABM : Form
    {
        AeronaveBLL _aeronaveBLO = new AeronaveBLL();
        VueloBLL _vueloBLO = new VueloBLL();
        ClienteBLL _clienteBLO = new ClienteBLL();
        InstructorBLL _instructorBLO = new InstructorBLL();
        FinalidadBLL _finalidadBLO = new FinalidadBLL();
        FormVuelos formVuelos;
        VistaVuelo vueloSeleccionado;
        Vuelo vuelo;
        public FormVuelosABM( FormVuelos formVuelosPpal,VistaVuelo vistaVuelo = null)
        {
            InitializeComponent();
            CargarCmbAeronavesDisp();
            CargarCmbClientes();
            CargarCmbInstructor();
            CargarCmbFinalidad();
            formVuelos = formVuelosPpal;
            if (vistaVuelo != null)
            {
                vueloSeleccionado = vistaVuelo;
                dtpFechaVuelo.Value = vistaVuelo.FechaVuelo;
                cmbInstructor.SelectedValue = vistaVuelo.IdInstructor;
                cmbCliente.SelectedValue = vistaVuelo.IdCliente;
                cmbAeronavesDisp.SelectedValue = vistaVuelo.MatriculaAeronave;
                cmbFinalidad.SelectedValue = vistaVuelo.CodFinalidad;
                dtpHoraPM.Value = DateTime.Now.Date.AddTicks(vistaVuelo.HoraPM.Ticks);
                dtpHoraCorte.Value = DateTime.Now.Date.AddTicks(vistaVuelo.HoraCorte.Ticks);
                nddHubInicial.Value = vistaVuelo.HubInicial;
                nddHubFinal.Value = vistaVuelo.HubFinal;
            }
        }

        public void CargarCmbAeronavesDisp()
        {
            try
            {
                cmbAeronavesDisp.DataSource = null;
                var aeronavesDisp = _aeronaveBLO.AeronavesDispoibles(_aeronaveBLO.ObtenerAeronaves());
                if (aeronavesDisp.Count() > 0)
                {
                    cmbAeronavesDisp.DataSource = aeronavesDisp;
                    cmbAeronavesDisp.ValueMember = "Matricula";
                    cmbAeronavesDisp.Format += (sender, e) =>
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

        public void CargarCmbClientes()
        {
            try
            {
                cmbCliente.DataSource = null;
                cmbCliente.DataSource = _clienteBLO.ObtenerTodosLosClientes().Where(x => x.Activo).ToList();
                cmbCliente.ValueMember = "IdCliente";
                cmbCliente.Format += (sender, e) =>
                {
                    if (e.ListItem is Cliente cliente)
                    {
                        e.Value = $"{cliente.Dni} - {cliente.Nombre} {cliente.Apellido}";
                    }
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCmbInstructor()
        {
            try
            {
                cmbInstructor.DataSource = null;
                cmbInstructor.DataSource = _instructorBLO.ObtenerTodosLosInstructores().Where(x => x.Activo).ToList();
                cmbInstructor.ValueMember = "IdInstructor";
                cmbInstructor.Format += (sender, e) =>
                {
                    if (e.ListItem is Instructor instructor)
                    {
                        e.Value = $"{instructor.Dni} - {instructor.Nombre} {instructor.Apellido}";
                    }
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCmbFinalidad()
        {
            try
            {
                cmbFinalidad.DataSource = null;
                cmbFinalidad.DataSource = _finalidadBLO.ObtenerFinalidades().Where(x => x.Activo).ToList();
                cmbFinalidad.ValueMember = "CodigoFinalidad";
                cmbFinalidad.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            vuelo = new Vuelo
            {
                FechaVuelo = dtpFechaVuelo.Value, // Obtener el valor del DateTimePicker
                InstructorVuelo = cmbInstructor.SelectedItem is Instructor instructor ? instructor : null,
                ClientVuelo = cmbCliente.SelectedItem is Cliente cliente ? cliente : null,
                AeronaveVuelo = cmbAeronavesDisp.SelectedItem is Aeronave aeronave ? aeronave : null,
                FinalidadVuelo = cmbFinalidad.SelectedItem is Finalidad finalidad ? finalidad : null,
                HoraPM = TimeOnly.FromDateTime(dtpHoraPM.Value), // Convertir DateTime a TimeOnly
                HoraCorte = TimeOnly.FromDateTime(dtpHoraCorte.Value),
                HubInicial = (decimal)nddHubInicial.Value,
                HubFinal = (decimal)nddHubFinal.Value
            };

            if (vueloSeleccionado != null)
            {
                vuelo.CodVuelo = vueloSeleccionado.CodVuelo;

                try
                {
                    _vueloBLO.ActualizarVuelo(vuelo);
                    MessageBox.Show("Modificacion de vuelo exitosa");
                    formVuelos.ActualizarGrillaVuelos();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el vuelo");
                }
                
            }
            else
            {
                try
                {
                    _vueloBLO.CrearVuelo(vuelo);
                    MessageBox.Show("Alta de vuelo exitosa");
                    formVuelos.ActualizarGrillaVuelos();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al insertar el vuelo");
                }
            }


        }
    }
}