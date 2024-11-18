using DAL.Helpers;
using Entities;
using Mapper;

namespace DAL;

public class ClienteDao
{
    public void Agregar(Cliente cliente)
    {
        using (var connection = DataAccessHelper.GetConnection())
        {
            connection.Open();
            string query = "INSERT INTO CLIENTE (DNI, APELLIDO, NOMBRE, TELEFONO, TELEFONO_EMERGENCIA, EMAIL, BREVET, SALDO_HORAS) " +
                           "VALUES (@Dni, @Apellido, @Nombre, @Telefono, @TelefonoEmergencia, @Email, @Brevet, @SaldoHoras)";
            var parametros = ClienteMapper.MapClienteAParametros(cliente);
            using (var command = DataAccessHelper.GetCommand(query, connection, parametros))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void Actualizar(Cliente cliente)
    {
        using (var connection = DataAccessHelper.GetConnection())
        {
            connection.Open();
            string query = "UPDATE CLIENTE SET DNI = @Dni, APELLIDO = @Apellido, NOMBRE = @Nombre, TELEFONO = @Telefono, " +
                           "TELEFONO_EMERGENCIA = @TelefonoEmergencia, EMAIL = @Email, BREVET = @Brevet, SALDO_HORAS = @SaldoHoras " +
                           "WHERE ID_CLIENTE = @IdCliente";
            var parametros = ClienteMapper.MapClienteAParametros(cliente);
            using (var command = DataAccessHelper.GetCommand(query, connection, parametros))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Cliente> ObtenerTodos()
    {
        string query = "SELECT ID_CLIENTE, DNI, APELLIDO, NOMBRE, TELEFONO, TELEFONO_EMERGENCIA, EMAIL, BREVET, SALDO_HORAS FROM CLIENTE WHERE Activo = 1";
        using (var connection = DataAccessHelper.GetConnection())
        {
            connection.Open();
            using (var command = DataAccessHelper.GetCommand(query, connection))
            {
                using (var reader = DataAccessHelper.GetDataReader(command))
                {
                    var clientes = new List<Cliente>();
                    while (reader.Read())
                    {
                        clientes.Add(ClienteMapper.MapReaderACliente(reader));
                    }
                    return clientes;
                }
            }
        }
    }

    public void BajaLogica(int idCliente)
    {
        using (var connection = DataAccessHelper.GetConnection())
        {
            connection.Open();
            string query = "UPDATE CLIENTE SET Activo = 0 WHERE ID_CLIENTE = @IdCliente";
            var parametros = new Dictionary<string, object>
            {
                { "@IdCliente", idCliente }
            };
            using (var command = DataAccessHelper.GetCommand(query, connection, parametros))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
