using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class AeronaveMap
    {
        public static Aeronave MapAeronave(SqlDataReader reader)
        {
			Aeronave aeronave = new Aeronave();
			try
			{
				aeronave.Matricula = reader["MATRICULA_AERONAVE"].ToString();
				aeronave.Marca = reader["MARCA_AERONAVE"].ToString();
                aeronave.Modelo = reader["MODELO_AERONAVE"].ToString();
                aeronave.Revision100Hs = Convert.ToDecimal(reader["REVISION_100HS"].ToString());
                aeronave.FechaRevisionAnual =Convert.ToDateTime(reader["FECHA_REVISION_ANUAL"].ToString());
                aeronave.Activo =  Convert.ToBoolean(reader["ACTIVO"].ToString());
             
                return aeronave;    
            }
			catch (Exception ex)
			{

				throw;
			}

        }

    }
}
