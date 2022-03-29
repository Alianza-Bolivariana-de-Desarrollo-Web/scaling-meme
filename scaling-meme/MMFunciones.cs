using Itenso.TimePeriod;
using System;

namespace clui.scaling_meme
{
    /// <summary>
    /// Clase de Mario Manuel.
    /// Actualizada: 28/03/2022.
    /// </summary>
    class MMFunciones
    {
        /// <summary>
        /// Calcula la diferencia en añor entre dos fechas.
        /// </summary>
        /// <param name="primeraFecha">Primera fecha D.C.</param>
        /// <param name="segundaFecha">Segunda fecha D.C.</param>
        /// <returns>Valor entero correspondiente a la diferencia.</returns>
        public static int CalcularEdadAnios(DateTime primeraFecha, DateTime segundaFecha)
        {
            int diferenciaAnios = primeraFecha.Year - segundaFecha.Year;
            return Math.Abs(diferenciaAnios);
        }
        /// <summary>
        /// Calcula la diferencia en días entre dos fechas.
        /// </summary>
        /// <param name="primeraFecha">Primera fecha D.C.</param>
        /// <param name="segundaFecha">Segunda fecha D.C.</param>
        /// <returns>Valor entero correspondiente a la diferencia.</returns>
        public static int CalcularEdadDias(DateTime primeraFecha, DateTime segundaFecha)
        {
            int diferenciaDias = primeraFecha.DayOfYear - segundaFecha.DayOfYear;
            return Math.Abs(diferenciaDias);
        }
        /// <summary>
        /// Calcula la diferencia en años o en días entre dos fechas.
        /// </summary>
        /// <param name="primeraFecha">Primera fecha D.C.</param>
        /// <param name="segundaFecha">Segunda fecha D.C.</param>
        /// <returns>Array de int con el valor en años y días (años = pos. 0, días = pos. 1).</returns>
        public static int[] CalcularDiferencia(DateTime primeraFecha, DateTime segundaFecha)
        {
            int[] diferenciaAniosDias = new int[2];
            DateDiff restaFecha = new DateDiff(primeraFecha, segundaFecha);
            diferenciaAniosDias[0] = restaFecha.Years;
            diferenciaAniosDias[1] = restaFecha.Days;
            return diferenciaAniosDias;
        }
    }
}
