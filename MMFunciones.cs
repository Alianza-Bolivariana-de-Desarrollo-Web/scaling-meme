using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_meme
{
    class MMFunciones
    {
        static int[] FechaActual = { 10, 04, 2022 };
        /// <summary>
        /// funcion que calcula los años entre 1 fecha dada y la actual
        /// </summary>
        /// <param name="fecha">array que contiene la fecha</param>
        /// <returns></returns>
        public static int CalcularEdadAños(int[] fecha)
        {
            const int posicionAño = 2; 
             int año = fecha[posicionAño];
            int Edad = año - FechaActual[posicionAño];

            return Edad;
        }
    }
}
