using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vuelo
    {
        public int Cod_Vuelo { get; set; }
        public DateTime FechaVuelo { get; set; }
        public Instructor InstructorVuelo { get; set; }
        public Cliente ClientVuelo { get; set; }
        public Aeronave AeronaveVuelo { get; set; }
        public Finalidad FinalidadVuelo { get; set; }
        public TimeOnly HoraPM { get; set; }
        public TimeOnly HoraCorte { get; set; }

        private decimal _tv;
        public decimal TV
        {
            get { return _tv; }
            set
            {
                int diferenciaMinutos;
                if (HoraCorte > HoraPM)
                {
                    diferenciaMinutos = (HoraCorte.Hour - HoraPM.Hour) * 60 + (HoraCorte.Minute - HoraPM.Minute);
                }
                else
                {
                    diferenciaMinutos = (24 - HoraPM.Hour + HoraCorte.Hour) * 60 + (HoraCorte.Minute - HoraPM.Minute);
                }

              
                int horasCompletas = diferenciaMinutos / 60;
                int minutosResiduales = diferenciaMinutos % 60;

        
                decimal ajuste = 0;
                if (minutosResiduales< 0 && minutosResiduales <=2) ajuste = 0;
                else if (minutosResiduales <= 8) ajuste = 0.1m;
                else if (minutosResiduales <= 14) ajuste = 0.2m;
                else if (minutosResiduales <= 20) ajuste = 0.3m;
                else if (minutosResiduales <= 26) ajuste = 0.4m;
                else if (minutosResiduales <= 33) ajuste = 0.5m;
                else if (minutosResiduales <= 39) ajuste = 0.6m;
                else if (minutosResiduales <= 45) ajuste = 0.7m;
                else if (minutosResiduales <= 51) ajuste = 0.8m;
                else if (minutosResiduales <= 57) ajuste = 0.9m;
                else ajuste = 1;

                
                _tv = horasCompletas + ajuste;
            }
            
        }

        public decimal HubInicial { get; set; }

        public decimal HubFinal { get; set; }

        private decimal _hubdiff;

        public decimal HubDiff
        {
            get { return _hubdiff; }
            set 
            {
                _hubdiff = HubFinal - HubInicial;
            }
        }

    }

}
