using DAL.Helpers;
using Entities;
using Mapper;

namespace DAL;

public class AeronaveDao
{
    public void Agregar(Aeronave aeronave)
    {
        using (var connection = DataAccessHelper.GetConnection())
        {
            connection.Open();
            string query = "INSERT INTO AERONAVE (MATRICULA_AERONAVE, MARCA_AERONAVE, MODELO_AERONAVE, REVISION_100HS, FECHA_REVISION_ANUAL) " +
                            "VALUES (@MatriculaAeronave, @MarcaAeronave, @ModeloAeronave, @Revision100Hs, @FechaRevisionAnual)";
            var parametros = AeronaveMapper.MapAeronaveAParametros(aeronave);
            using (var command = DataAccessHelper.GetCommand(query, connection, parametros))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void Actualizar(Aeronave aeronave)
    {
        using (var connection = DataAccessHelper.GetConnection())
        {
            connection.Open();
            string query = "UPDATE AERONAVE SET MARCA_AERONAVE = @MarcaAeronave, MODELO_AERONAVE = @ModeloAeronave, REVISION_100HS = @Revision100Hs, " +
                            "FECHA_REVISION_ANUAL = @FechaRevisionAnual WHERE MATRICULA_AERONAVE = @MatriculaAeronave";
            var parametros = AeronaveMapper.MapAeronaveAParametros(aeronave);
            using (var command = DataAccessHelper.GetCommand(query, connection, parametros))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Aeronave> ObtenerTodos()
    {
        string query = "SELECT MATRICULA_AERONAVE, MARCA_AERONAVE, MODELO_AERONAVE, REVISION_100HS, FECHA_REVISION_ANUAL FROM AERONAVE";
        using (var connection = DataAccessHelper.GetConnection())
        {
            using (var command = DataAccessHelper.GetCommand(query, connection))
            {
                using (var reader = DataAccessHelper.GetDataReader(command))
                {
                    var aeronaves = new List<Aeronave>();
                    while (reader.Read())
                    {
                        aeronaves.Add(AeronaveMapper.MapReaderAAeronave(reader));
                    }
                    return aeronaves;
                }
            }
        }

    }
}
