using System;
using System.Collections.Generic;
using System.Text;


namespace tema3tarea2
{
     public class CosasFechas
    {
        #region Atributos

        public DateTime fechahoy = DateTime.Today;

        

        #endregion

        #region Constructor
        public CosasFechas(DateTime hoy)
        {
            fechahoy = hoy;
        }
        #endregion
        #region Metodos


        /// <summary>
        /// Nos comunica el dia de la semana en el que estamos (lunes, martes, miercoles, etc).
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public string DiaSemana(DateTime fecha)
        {
            return fecha.DayOfWeek.ToString();

        }
        /// <summary>
        /// Este metodo nos va a comunicar cuantos días faltan para nuestro proximo cumpleaños
        /// </summary>
        /// <returns></returns>
        public string CuantoFalta()
        {
            int diaCumple = 4;
            int mesCumple = 4; 
            int anyoCumple = 1984; 
            DateTime fechaNacimiento = new DateTime(anyoCumple, mesCumple, diaCumple);

            DateTime proximoCumple;//Define el proximo Cumple
            //En caso de que el mes sea menor al Mes Actual se busca el Próxima fecha que seria del año que viene
            //es por ello el AddYear(1)
            //En caso de ser mayor se toma el año actual
            if (DateTime.Now.Month <= mesCumple && DateTime.Now.Day <= diaCumple)
            {
                proximoCumple = new DateTime(DateTime.Now.AddYears(1).Year, mesCumple, diaCumple);
            }
            else 
            {
                proximoCumple = new DateTime(DateTime.Now.Year, mesCumple, diaCumple);

            }

            //Definiremos los dias faltantes para el proximo cumple
            TimeSpan faltan = proximoCumple.Subtract(DateTime.Now);

            //Ahora Elaboramos el Mensaje
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Faltan {0} Días para tu proximo Cumpleaños.", faltan.Days);

            return sb.ToString();
        }

       

        #endregion



    }
}
