using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_meme
{
    class MMFunciones
    {
    
        /// <summary>
        /// funcion que calcula los años entre 1 fecha dada y la actual
        /// </summary>
        /// <param name="fecha">array que contiene la fecha</param>
        /// <returns></returns>
        public static int CalcularEdadAños(DateTime fecha1,DateTime fecha2)
        {


             int restaFecha = fecha1.Year-fecha2.Year;


            return restaFecha;
        }

        public static int CalcularEdadDias(DateTime fecha1, DateTime fecha2)
        {

            int restaFecha = fecha1.DayOfYear - fecha2.DayOfYear;


            return restaFecha;
        }


        public static void CalcularAños()
        {

        }
    }
}
