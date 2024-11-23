using Entity;
using System;
using System.Data.SqlClient;

namespace Mapper;

public class VueloMap
{
    public static void MapearVuelo(SqlCommand command, Vuelo vuelo)
    {
        command.Parameters.AddWithValue("@FechaVuelo", vuelo.FechaVuelo);
        command.Parameters.AddWithValue("@IdInstructor", vuelo.InstructorVuelo?.IdInstructor ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@IdCliente", vuelo.ClientVuelo?.IdCliente ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@MatriculaAeronave", vuelo.AeronaveVuelo?.MatriculaAeronave ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@CodFinalidad", vuelo.FinalidadVuelo?.CodFinalidad ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@HoraPM", vuelo.HoraPM.ToString("HH:mm:ss"));
        command.Parameters.AddWithValue("@HoraCorte", vuelo.HoraCorte.ToString("HH:mm:ss"));
        command.Parameters.AddWithValue("@HubInicial", vuelo.HubInicial);
        command.Parameters.AddWithValue("@HubFinal", vuelo.HubFinal);
    }

    public static Vuelo MapearDesdeReader(SqlDataReader reader)
    {
        return new Vuelo
        {
            CodVuelo = reader.GetInt32(reader.GetOrdinal("COD_VUELO")),
            FechaVuelo = reader.GetDateTime(reader.GetOrdinal("FECHA_VUELO")),
            InstructorVuelo = InstructorMap.MapearDesdeReaderVuelo(reader),
            ClientVuelo = ClienteMap.MapearDesdeReaderVuelo(reader),
            AeronaveVuelo = AeronaveMap.MapAeronave(reader),
            FinalidadVuelo = FinalidadMap.MapFinalidad(reader),
            HoraPM = TimeOnly.Parse(reader.GetTimeSpan(reader.GetOrdinal("HORA_PM")).ToString()),
            HoraCorte = TimeOnly.Parse(reader.GetTimeSpan(reader.GetOrdinal("HORA_CORTE")).ToString()),
            HubInicial = reader.GetDecimal(reader.GetOrdinal("HUB_INICIAL")),
            HubFinal = reader.GetDecimal(reader.GetOrdinal("HUB_FINAL"))
        };
    }
}
