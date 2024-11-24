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
        command.Parameters.AddWithValue("@MatriculaAeronave", vuelo.AeronaveVuelo?.Matricula ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@CodFinalidad", vuelo.FinalidadVuelo?.CodigoFinalidad ?? (object)DBNull.Value);
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
            InstructorVuelo = InstructorMap.MapearDesdeReader(reader),
            ClientVuelo = ClienteMap.MapearDesdeReader(reader),
            AeronaveVuelo = AeronaveMap.MapAeronave(reader),
            FinalidadVuelo = FinalidadMap.MapFinalidad(reader),
            HoraPM = TimeOnly.Parse(reader.GetTimeSpan(reader.GetOrdinal("HORA_PM")).ToString()),
            HoraCorte = TimeOnly.Parse(reader.GetTimeSpan(reader.GetOrdinal("HORA_CORTE")).ToString()),
            HubInicial = reader.GetDecimal(reader.GetOrdinal("HUB_INICIAL")),
            HubFinal = reader.GetDecimal(reader.GetOrdinal("HUB_FINAL"))
        };
    }

    public static VistaVuelo MapearVistaDesdeReader(SqlDataReader reader)
    {
        return new VistaVuelo
        {
            CodVuelo = reader.GetInt32(reader.GetOrdinal("COD_VUELO")),
            FechaVuelo = reader.GetDateTime(reader.GetOrdinal("FECHA_VUELO")),
            CodFinalidad = reader.IsDBNull(reader.GetOrdinal("COD_FINALIDAD")) ? string.Empty : reader.GetString(reader.GetOrdinal("COD_FINALIDAD")),
            HoraPM = TimeOnly.Parse(reader.GetTimeSpan(reader.GetOrdinal("HORA_PM")).ToString()),
            HoraCorte = TimeOnly.Parse(reader.GetTimeSpan(reader.GetOrdinal("HORA_CORTE")).ToString()),
            TV = reader.GetDecimal(reader.GetOrdinal("TV")),
            HubInicial = reader.IsDBNull(reader.GetOrdinal("HUB_INICIAL")) ? 0 : reader.GetDecimal(reader.GetOrdinal("HUB_INICIAL")),
            HubFinal = reader.IsDBNull(reader.GetOrdinal("HUB_FINAL")) ? 0 : reader.GetDecimal(reader.GetOrdinal("HUB_FINAL")),
            MatriculaAeronave = reader["MATRICULA_AERONAVE"].ToString(),
            IdCliente = reader.GetInt32(reader.GetOrdinal("ID_CLIENTE")),
            ClienteDNI = reader.IsDBNull(reader.GetOrdinal("ClienteDNI")) ? 0 : reader.GetInt32(reader.GetOrdinal("ClienteDNI")),
            ClienteNombreApellido = reader.IsDBNull(reader.GetOrdinal("ClienteNombreApellido")) ? string.Empty : reader.GetString(reader.GetOrdinal("ClienteNombreApellido")),
            IdInstructor = reader.IsDBNull(reader.GetOrdinal("ID_INSTRUCTOR")) ? 0 : reader.GetInt32(reader.GetOrdinal("ID_INSTRUCTOR")),
            InstructorDNI = reader.IsDBNull(reader.GetOrdinal("InstructorDNI")) ? 0 : reader.GetInt32(reader.GetOrdinal("InstructorDNI")),
            InstructorNombreApellido = reader.IsDBNull(reader.GetOrdinal("InstructorNombreApellido")) ? string.Empty : reader.GetString(reader.GetOrdinal("InstructorNombreApellido"))
        };
    }

}
