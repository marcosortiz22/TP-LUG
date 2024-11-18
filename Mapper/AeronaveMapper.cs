using Entities;
using System.Data.SqlClient;

namespace Mapper;

public static class AeronaveMapper
{
    public static Aeronave MapReaderAAeronave(SqlDataReader reader)
    {
        return new Aeronave
        {
            MatriculaAeronave = reader["MATRICULA_AERONAVE"].ToString(),
            MarcaAeronave = reader["MARCA_AERONAVE"].ToString(),
            ModeloAeronave = reader["MODELO_AERONAVE"].ToString(),
            Revision100Hs = reader["REVISION_100HS"] as int?,
            FechaRevisionAnual = reader["FECHA_REVISION_ANUAL"] as DateTime?
        };
    }

    public static Dictionary<string, object> MapAeronaveAParametros(Aeronave aeronave)
    {
        return new Dictionary<string, object>
            {
                { "@MatriculaAeronave", aeronave.MatriculaAeronave },
                { "@MarcaAeronave", aeronave.MarcaAeronave },
                { "@ModeloAeronave", aeronave.ModeloAeronave },
                { "@Revision100Hs", aeronave.Revision100Hs },
                { "@FechaRevisionAnual", aeronave.FechaRevisionAnual }
            };
    }
}