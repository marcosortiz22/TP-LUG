using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class VueloMap
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
