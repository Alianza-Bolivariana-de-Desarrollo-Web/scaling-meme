using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Text;

namespace clui.scaling_meme
{
    class MMFunciones
    {
    
        /// <summary>
        /// funcion que calcula los años entre 1 fecha dada y la actual
        /// </summary>
        /// <param name="fecha">array que contiene la fecha</param>
        /// <returns></returns>
        public static int CalcularEdadAnios(DateTime fecha1, DateTime fecha2)
        {
            int restaAnios = fecha1.Year - fecha2.Year;
            return restaAnios;
        }

        public static int CalcularEdadDias(DateTime fecha1, DateTime fecha2)
        {
            int restaDias = fecha1.DayOfYear - fecha2.DayOfYear;
            return restaDias;
        }
        public static int[] CalcularDiferencia(DateTime fecha1, DateTime fecha2)
        {
            int[] diferenciaAniosDias = new int[2];
            DateDiff restaFecha = new DateDiff(fecha1, fecha2);
            diferenciaAniosDias[1] = restaFecha.Years;
            diferenciaAniosDias[2] = restaFecha.Days;
            return diferenciaAniosDias;
        }
    }
}
