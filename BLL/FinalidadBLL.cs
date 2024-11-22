using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FinalidadBLL
    {
		FinalidadData finalidadBLO = new FinalidadData();
        public List<Finalidad>  ObtenerFinalidades()
        {

			try
			{
				return finalidadBLO.ObtenerFinalidadesDB();

			}
			catch (Exception ex)
			{

				throw;
			}
        }
		
		public List<Finalidad> ObtenerFinalidadesActivas(List<Finalidad> LFinalidades)
		{
			List<Finalidad> LFinalidadesActivas = new List<Finalidad>();
			try
			{
				foreach (var f in LFinalidades )
				{
					if (f.Activo ==true)
					{
						LFinalidadesActivas.Add(f);
					}
				}
				return LFinalidadesActivas;
			}
			catch (Exception ex)
			{

				throw;
			}
		}
    }	
}
