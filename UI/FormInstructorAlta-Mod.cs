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
    public partial class FormInstructorAlta_Mod : Form
    {
        InstructorBLL instructorBlo = new InstructorBLL();
        Instructor instructor = new Instructor();
        FormInstructor formularioPpal;

        public FormInstructorAlta_Mod(FormInstructor formPpal, Instructor instructorPpal)
        {
       
            InitializeComponent();
            formularioPpal = formPpal;
            instructor = instructorPpal;
        }

        private void FormInstructorAlta_Mod_Load(object sender, EventArgs e)
        {
            if (instructor.IdInstructor != 0)
            {
                ActualizarParaMod();
            }
            else
            {
                ActualizarParaAlta();
            }
        }

        private void ActualizarParaAlta()
        {
            checkBox1.Visible = false;
            BtnAlta.Text = "Alta";
            label_Id.Visible = false;
            txt_IdInstructor.Visible = false;
            txt_IdInstructor.Enabled = true;
            txt_Dni.Enabled = true;
        }

        private void ActualizarParaMod()
        {
            BtnAlta.Text = "Modificar";
            label_Id.Visible = true;
            txt_IdInstructor.Visible = true;
            txt_IdInstructor.Text = instructor.IdInstructor.ToString();
            txt_IdInstructor.Enabled = false;
            txt_Dni.Text = instructor.Dni.ToString();
            txt_Dni.Enabled = false;
            txt_Nombre.Text = instructor.Nombre;
            txt_Apellido.Text = instructor.Apellido;
            txt_Brevet.Text = instructor.Brevet.ToString();
            checkBox1.Checked = instructor.Activo;
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (instructor.IdInstructor != 0)
                {
                    instructor.Nombre = txt_Nombre.Text;
                    instructor.Apellido = txt_Apellido.Text;
                    instructor.Brevet = txt_Brevet.Text;
                    instructor.Activo = checkBox1.Checked;

                    instructorBlo.ActualizarInstructor(instructor);
                    formularioPpal.CargarGillaInstructor();
                    this.Close();
                    MessageBox.Show("Modificacion de instructor exitosa");
                }
                else
                {
                    if (!int.TryParse(txt_Dni.Text, out int dni)) throw new Exception("El dni debe ser numerico");
                    instructor.Dni =dni;
                    instructor.Apellido =txt_Apellido.Text; 
                    instructor.Nombre=txt_Nombre.Text;
                    instructor.Brevet =txt_Brevet.Text;
                    
                    instructorBlo.CrearInstructor(instructor);
                    formularioPpal.CargarGillaInstructor();
                    MessageBox.Show("Alta de instructor exitosa");
                    LimpiarForm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txt_Dni.Text = null;
            txt_Apellido.Text = null;
            txt_Nombre.Text = null;
            txt_Brevet.Text = null;
            checkBox1.Checked = false;
        }
    }
}
