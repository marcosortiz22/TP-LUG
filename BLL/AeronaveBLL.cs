using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class AeronaveBLL
    {
		AeronaveData aeronaveDao = new AeronaveData();
        public List<Aeronave> ObtenerAeronaves()
        {			
			try
			{
				return aeronaveDao.ObtenerAeronavesDB();
			}
			catch (Exception ex)
			{

				throw;
			}
        }

		public List<Aeronave> AeronavesDispoibles(List<Aeronave> Laernoaves)
		{
			List<Aeronave> LAeroDisp = new List<Aeronave>();
			try
			{
				foreach (Aeronave aeronave in Laernoaves)
				{
					if (aeronave.Activo==true && aeronave.Revision100Hs<100)
					{
						LAeroDisp.Add(aeronave);
					}
				}
				return LAeroDisp;
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public List<Aeronave> AeronavesService(List<Aeronave> Laernoaves)
		{
			List<Aeronave> LAeroService = new List<Aeronave>();	
			try
			{
                foreach (Aeronave aeronave in Laernoaves)
                {
                    if (aeronave.Activo == true && aeronave.Revision100Hs >= 100)
                    {
                        LAeroService.Add(aeronave);
                    }
                }
                return  LAeroService;
            }
			catch (Exception ex)
			{

				throw;
			}
		}
		public void AltaAeronave(Aeronave aeronave)
		{
			try
			{

                ValidacionesAeronave(aeronave);
                if (aeronaveDao.BuscarAeronavePorMatricula(aeronave.Matricula) != null) throw new Exception(" La matricula de la Aeronave ya existe");
                if (aeronave.FechaRevisionAnual < DateTime.Now) throw new Exception("La fecha de la revision anual al momento dle alta no puede ser anterior a la fecha de hoy");
                aeronave.Activo = true;
                using (TransactionScope trx = new TransactionScope())
				{

					aeronaveDao.AltaAeronaveDB(aeronave);
					trx.Complete();
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}

        private void ValidacionesAeronave(Aeronave aeronave)
		{
			try
			{

                if (aeronave.Matricula.Length < 4) throw new Exception("La matricula debe contener al menos 4 caracteres");
                if (!Regex.IsMatch(aeronave.Matricula, "^[a-zA-Z0-9-]+$")) throw new Exception("La matricula debe ser alfanumerica");
                if (string.IsNullOrEmpty(aeronave.Marca)) throw new Exception("Debe ingresar una marca");
                if (string.IsNullOrEmpty(aeronave.Modelo)) throw new Exception("Debe ingresar un modelo");
				if (aeronave.Revision100Hs < 0) throw new Exception("El valor de la horas debe ser mayor a 0");
				
            }
			catch (Exception ex)
			{

				throw;
			}

        }

        public void AltaListaBorrador(List<Aeronave> lBorrador)
        {
			try
			{

				using (TransactionScope trx = new TransactionScope())
				{
					foreach (var aeronave in lBorrador)
					{
						AltaAeronave(aeronave);
					}

					trx.Complete();
				}
			}
			catch (Exception ex)
			{

				throw;
			}
        }

        public void ModificarAeronave(Aeronave aeronaveModifcar)
        {
			try
			{
                if (aeronaveDao.BuscarAeronavePorMatricula(aeronaveModifcar.Matricula) == null) throw new Exception("La Aeronave no se encontro en la base de datos para modificar");
				ValidacionesAeronave(aeronaveModifcar);
                using (TransactionScope trx = new TransactionScope ())
				{
					aeronaveDao.ModificarAeronaveDB(aeronaveModifcar);
					trx.Complete();
				}

			}
			catch (Exception ex)
			{

				throw;
			}
        }

        public void EliminarAeronavePorMatricula(string matricula)
        {
            try
            {
                if (aeronaveDao.BuscarAeronavePorMatricula(matricula) == null) throw new Exception("La Aeronave no se encontro en la base de datos para eliminar");
                
                using (TransactionScope trx = new TransactionScope())
                {
                    aeronaveDao.EliminarAeronavePorMatriculaDB(matricula);
                    trx.Complete();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ActualizarService100Hs(string matricula, decimal revision100Hs)
        {
			try
			{
                if (aeronaveDao.BuscarAeronavePorMatricula(matricula) == null) throw new Exception("La Aeronave no se encontro en la base de datos para realizar el service");

                using (TransactionScope trx = new TransactionScope())
                {
                    aeronaveDao.ActualizarServicePorMatriculaDB(matricula,revision100Hs);
                    trx.Complete();
                }
            }
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
