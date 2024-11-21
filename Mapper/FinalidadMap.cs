using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class FinalidadMap
    {
        public static Finalidad MapFinalidad(SqlDataReader reader)
        {
			Finalidad finalidad = new Finalidad();
			try
			{
				finalidad.CodigoFinalidad = reader["COD_FINALIDAD"].ToString();
				finalidad.Descripcion = reader["DESCRIPCION"].ToString();
				finalidad.Activo = Convert.ToBoolean(reader["ACTIVO"].ToString()); 
				return finalidad;
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
