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
    public class AeronaveData
    {
        public void ActualizarServicePorMatriculaDB(string matricula, decimal revision100Hs)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryAltaAeronave = " UPDATE AERONAVE SET REVISION_100HS = @revision100Hs WHERE MATRICULA_AERONAVE =@Matricula";
                    using (SqlCommand command = new SqlCommand(queryAltaAeronave, conexion))
                    {
                        command.Parameters.AddWithValue("@revision100Hs", revision100Hs);
                        command.Parameters.AddWithValue("@Matricula", matricula);
                        command.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void AltaAeronaveDB(Aeronave aeronave)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryAltaAeronave = "INSERT INTO AERONAVE VALUES (@Matricula,@Marca,@Modelo,@Revision100Hs,@FechaRevisionAnual,@Activo) ";
                    using (SqlCommand command = new SqlCommand(queryAltaAeronave, conexion))
                    {
                        command.Parameters.AddWithValue("@Matricula", aeronave.Matricula);
                        command.Parameters.AddWithValue("@Marca", aeronave.Marca);
                        command.Parameters.AddWithValue("@Modelo", aeronave.Modelo);
                        command.Parameters.AddWithValue("@Revision100Hs", aeronave.Revision100Hs);
                        command.Parameters.AddWithValue("@FechaRevisionAnual", aeronave.FechaRevisionAnual.Date);
                        command.Parameters.AddWithValue("@Activo", aeronave.Activo);

                        command.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Aeronave BuscarAeronavePorMatricula(string Matricula)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryObtenerAeronavePorMatricula = " SELECT MATRICULA_AERONAVE,MARCA_AERONAVE,MODELO_AERONAVE,REVISION_100HS,FECHA_REVISION_ANUAL,ACTIVO FROM AERONAVE WHERE MATRICULA_AERONAVE = @Matricula ";
                    using (SqlCommand command = new SqlCommand(queryObtenerAeronavePorMatricula, conexion))
                    {
                        command.Parameters.AddWithValue ("@Matricula", Matricula);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Aeronave aeronave = new Aeronave();
                                aeronave = AeronaveMap.MapAeronave(reader);
                                return aeronave;
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

        public void EliminarAeronavePorMatriculaDB(string matricula)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryAltaAeronave = " UPDATE AERONAVE SET ACTIVO = 0 WHERE MATRICULA_AERONAVE =@Matricula";
                    using (SqlCommand command = new SqlCommand(queryAltaAeronave, conexion))
                    {
                        command.Parameters.AddWithValue("@Matricula", matricula);
                        command.ExecuteNonQuery();
                    }


                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ModificarAeronaveDB(Aeronave aeronaveModifcar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryAltaAeronave = "UPDATE AERONAVE SET MARCA_AERONAVE = @Marca,MODELO_AERONAVE = @Modelo,REVISION_100HS = @Revision100Hs,FECHA_REVISION_ANUAL = @FechaRevisionAnual,ACTIVO = @Activo WHERE MATRICULA_AERONAVE = @Matricula ";
                    using (SqlCommand command = new SqlCommand(queryAltaAeronave, conexion))
                    {

                        command.Parameters.AddWithValue("@Marca",aeronaveModifcar.Marca);
                        command.Parameters.AddWithValue("@Modelo",aeronaveModifcar.Modelo);
                        command.Parameters.AddWithValue("@Revision100Hs",aeronaveModifcar.Revision100Hs);
                        command.Parameters.AddWithValue("@FechaRevisionAnual",aeronaveModifcar.FechaRevisionAnual.Date);
                        command.Parameters.AddWithValue("@Activo",aeronaveModifcar.Activo);
                        command.Parameters.AddWithValue("@Matricula",aeronaveModifcar.Matricula);
                        command.ExecuteNonQuery();
                    }


                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Aeronave> ObtenerAeronavesDB()
        {
            List<Aeronave> LAernoaves = new List<Aeronave>();
            try
            {

                using (SqlConnection conexion = new SqlConnection(ConfigationDB.ObtenerConexionDB()))
                {
                    conexion.Open();
                    string queryObtenerAeronaves = "SELECT MATRICULA_AERONAVE,MARCA_AERONAVE,MODELO_AERONAVE,REVISION_100HS,FECHA_REVISION_ANUAL,ACTIVO FROM AERONAVE";
                    using(SqlCommand command = new SqlCommand(queryObtenerAeronaves, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Aeronave aeronave = new Aeronave();
                                aeronave = AeronaveMap.MapAeronave(reader);
                                LAernoaves.Add(aeronave);
                            }  
                        }
                    }
                }


                    return LAernoaves;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
