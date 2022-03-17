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
        public static int CalcularEdadAños(DateTime añoDado)
        {
            DateTime diaActual = DateTime.Today;
            const int posicionAño = 2; 
             DateTime añoDevolver = diaActual-añoDado;
            int Edad = año - FechaActual[posicionAño];

            return Edad;
        }
    }
}
