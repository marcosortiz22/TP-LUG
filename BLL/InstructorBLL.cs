using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InstructorBLL
    {
        private readonly InstructorData instructorData=new InstructorData();

        public void CrearInstructor(Instructor instructor)
        {
            try
            {
                ValidarInstructor(instructor);

                instructor.Activo= true;

                instructorData.AgregarInstructor(instructor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el instructor: " + ex.Message, ex);
            }
        }

        public Instructor ObtenerInstructorPorId(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del instructor debe ser un número positivo.");
                }

                var instructor = instructorData.ObtenerInstructorPorId(id);

                if (instructor == null)
                {
                    throw new Exception("Instructor no encontrado.");
                }

                return instructor;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el instructor por ID: " + ex.Message, ex);
            }
        }

        public List<Instructor> ObtenerTodosLosInstructores()
        {
            try
            {
                return instructorData.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de instructores: " + ex.Message, ex);
            }
        }

        public void ActualizarInstructor(Instructor instructor)
        {
            try
            {
                if (instructor == null || instructor.IdInstructor <= 0)
                {
                    throw new ArgumentException("El instructor no es válido para la actualización.");
                }

                ValidarInstructor(instructor);

               instructorData.ActualizarInstructor(instructor);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el instructor: " + ex.Message, ex);
            }
        }

        public void EliminarInstructor(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del insructor debe ser un número positivo.");
                }

               instructorData.EliminarInstructor(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el instructor: " + ex.Message, ex);
            }
        }

        private void ValidarInstructor(Instructor instructor)
        {
            if (instructor == null)
            {
                throw new ArgumentNullException(nameof(instructor), "El instructor no puede ser nulo.");
            }

            if (instructor.Dni <= 0)
            {
                throw new ArgumentException("El DNI debe ser un número positivo.");
            }

            if (string.IsNullOrWhiteSpace(instructor.Nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(instructor.Apellido))
            {
                throw new ArgumentException("El apellido no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(instructor.Brevet))
            {
                throw new ArgumentException("El Brevet no puede estar vacío.");
            }
        }

        
    }
}

