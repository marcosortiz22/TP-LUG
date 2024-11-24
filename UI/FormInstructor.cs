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
    public partial class FormInstructor : Form
    {
        InstructorBLL instructorBLO = new InstructorBLL();
        FormVuelos formVuelos = new FormVuelos();
        public FormInstructor(FormVuelos formVuelosPpal)
        {
            InitializeComponent();
            formVuelos = formVuelosPpal;
        }

        private void FormInstructor_Load(object sender, EventArgs e)
        {
            CargarGillaInstructor();
        }

        public void CargarGillaInstructor()
        {
            try
            {
                dgv_Instructor.DataSource = null;
                if (instructorBLO.ObtenerTodosLosActivos().Count > 0)
                {
                    dgv_Instructor.DataSource = instructorBLO.ObtenerTodosLosActivos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AltaInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                Instructor instructorAlta = new Instructor();
                FormInstructorAlta_Mod formALtaMod = new FormInstructorAlta_Mod(this, instructorAlta);
                formALtaMod.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ModficarInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Instructor.Rows.Count < 1) throw new Exception("No hay instructores para modificar");
                if (dgv_Instructor.SelectedRows.Count < 1) throw new Exception("Debe seleccionar un instructor a modificar");
                if (!int.TryParse((dgv_Instructor.SelectedRows[0].Cells[0].Value).ToString(), out int id)) throw new Exception("Error al obtener el id de la grilla");
                Instructor instructorMod = new Instructor();
                instructorMod = instructorBLO.ObtenerInstructorPorId(id);
                FormInstructorAlta_Mod FormAltaMod = new FormInstructorAlta_Mod(this, instructorMod);
                FormAltaMod.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_EliminarInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Instructor.Rows.Count < 1) throw new Exception("No hay  instructores para eliminar");
                if (dgv_Instructor.SelectedRows.Count < 1) throw new Exception("Debe seleccionar un instructor a eliminar");
                if (!int.TryParse(dgv_Instructor.SelectedRows[0].Cells[0].Value.ToString(), out int id)) throw new Exception("Error al obtener el id de la grilla");
                instructorBLO.EliminarInstructor(id);
                CargarGillaInstructor();
                MessageBox.Show("El instructor ha sido eliminado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
