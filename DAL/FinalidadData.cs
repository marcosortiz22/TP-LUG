using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FinalidadData
    {
        public List<Finalidad> ObtenerFinalidadesDB()
        {
			List<Finalidad> Lfinalidad = new List<Finalidad>();	
			try
			{
				using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
				{
					conexion.Open();
					string queryObtenerFinalidades = "SELECT COD_FINALIDAD,DESCRIPCION,ACTIVO FROM FINALIDAD";
					using(SqlCommand command = new SqlCommand(queryObtenerFinalidades, conexion))
					{
						using(SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								Finalidad finalidad = new Finalidad();
								finalidad = FinalidadMap.MapFinalidad(reader);
								Lfinalidad.Add(finalidad);
							}
						}
					}
                }
				return Lfinalidad;
			}
			catch (Exception ex)
			{

				throw;
			}
        }

		public Finalidad ObtenerFinalidadPorMatricula(string codigo)
		{
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryObtenerAeronavePorMatricula = " SELECT COD_FINALIDAD,DESCRIPCION,ACTIVO FROM FINALIDAD WHERE COD_FINALIDAD = @codFinalidad";
                    using (SqlCommand command = new SqlCommand(queryObtenerAeronavePorMatricula, conexion))
                    {
                        command.Parameters.AddWithValue("@codFinalidad", codigo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Finalidad finalidad = new Finalidad();
                                finalidad = FinalidadMap.MapFinalidad(reader);
                                return finalidad;
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
