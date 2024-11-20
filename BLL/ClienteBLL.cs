using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        private readonly ClienteData clienteData = new ClienteData();

        public void CrearCliente(Cliente cliente)
        {
            try
            {
                ValidarCliente(cliente);

                cliente.Activo = true;

                clienteData.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el cliente: " + ex.Message, ex);
            }
        }

        public Cliente ObtenerClientePorId(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del cliente debe ser un número positivo.");
                }

                var cliente = clienteData.ObtenerClientePorId(id);

                if (cliente == null)
                {
                    throw new Exception("Cliente no encontrado.");
                }

                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente por ID: " + ex.Message, ex);
            }
        }

        public List<Cliente> ObtenerTodosLosClientes()
        {
            try
            {
                return clienteData.ObtenerTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de clientes: " + ex.Message, ex);
            }
        }

        public void ActualizarCliente(Cliente cliente)
        {
            try
            {
                if (cliente == null || cliente.IdCliente <= 0)
                {
                    throw new ArgumentException("El cliente no es válido para la actualización.");
                }

                ValidarCliente(cliente);

                clienteData.ActualizarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el cliente: " + ex.Message, ex);
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("El ID del cliente debe ser un número positivo.");
                }

                clienteData.EliminarCliente(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message, ex);
            }
        }

        private void ValidarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
            }

            if (cliente.Dni <= 0)
            {
                throw new ArgumentException("El DNI debe ser un número positivo.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new ArgumentException("El apellido no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                throw new ArgumentException("El teléfono no puede estar vacío.");
            }

            if (!IsEmailValido(cliente.Email))
            {
                throw new ArgumentException("El email no tiene un formato válido.");
            }
        }

        private bool IsEmailValido(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
