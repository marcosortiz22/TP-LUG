using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

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
                if (instructorData.ObtenerInstrctorPorDNI(instructor.Dni) != null) throw new Exception("El dni que desea dar alta ya se encuentra registrado");
                instructor.Activo= true;
                using (TransactionScope trx = new TransactionScope())
                {
                    instructorData.AgregarInstructor(instructor);
                     trx.Complete();
                }

               
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
        public List<Instructor> ObtenerTodosLosActivos()
        {
            try
            {
                return instructorData.ObtenerActivos();
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
                if (instructorData.ObtenerInstructorPorId(instructor.IdInstructor) == null) throw new Exception("No se encontro el instructor en la base de datos para modificar");
                ValidarInstructor(instructor);
                using (TransactionScope trx = new TransactionScope())
                {
                    instructorData.ActualizarInstructor(instructor);
                    trx.Complete();
                }
               
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
                if(instructorData.ObtenerInstructorPorId(id)==null) throw new Exception("No se encontro el instructor en la base de datos para eliminar");

                using (TransactionScope trx = new TransactionScope())
                {
                    instructorData.EliminarInstructor(id);
                    trx.Complete();
                }
               
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
            if (!Regex.IsMatch(instructor.Dni.ToString(), @"^\d{1,8}$"))
            {
                throw new ArgumentException("El DNI debe ser un número positivo y tener como máximo 8 dígitos.");
            }

            if (string.IsNullOrWhiteSpace(instructor.Nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
            if (!Regex.IsMatch(instructor.Nombre, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("El nombre no puede contener numeros ni signos");
            }

            if (string.IsNullOrWhiteSpace(instructor.Apellido))
            {
                throw new ArgumentException("El apellido no puede estar vacío.");
            }
            if (!Regex.IsMatch(instructor.Apellido, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("El apellido no puede contener numeros ni signos");
            }

            if (string.IsNullOrWhiteSpace(instructor.Brevet))
            {
                throw new ArgumentException("El Brevet no puede estar vacío.");
            }
            if (!Regex.IsMatch(instructor.Brevet, @"^B\d+$")) throw new Exception("Formato de brevet erroneo, debe comenzar con la letra B y luego ser numerico");
        }

        
    }
}

