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
        public static int CalcularEdadAños(DateTime año1,DateTime año2)
        {


             int restaAños = año1.Year-año2.Year;


            return restaAños;
        }

        public static int CalcularEdadDias(DateTime año1, DateTime año2)
        {

            int restaAños = año1.DayOfYear - año2.DayOfYear;


            return restaAños;
        }
    }
}
