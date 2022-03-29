using System;
using System.Globalization;

namespace clui.scaling_meme
{
    /// <summary>
    /// Clase principal del programa. Contiene el método principal que inicia en modo consola.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal, una vez llamado ejecuta una aplicación en modo consola que solicita 2 fechas por teclado y hace cálculos con ella.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al proyecto: Fechas y Edades");
            string primeraFecha = NDFunciones.SolicitarFecha();
            string mensajeDeError = "";
            if(SCFunciones.ValidarFecha(primeraFecha, "es", ref mensajeDeError))
            {
                string segundaFecha = NDFunciones.SolicitarFecha();
                if (SCFunciones.ValidarFecha(segundaFecha, "es", ref mensajeDeError))
                {
                    CultureInfo cultureInfoES = new CultureInfo("es-ES");
                    DateTime fechaUno = Convert.ToDateTime(primeraFecha, cultureInfoES);
                    DateTime fechaDos = Convert.ToDateTime(segundaFecha, cultureInfoES);

                    Console.WriteLine("[PRIMERA FECHA] - {0} D.C.", fechaUno);
                    Console.WriteLine("[SEGUNDA FECHA] - {0} D.C.", fechaDos);
                    int[] diferenciaAniosDiasACDC = MMFunciones.CalcularDiferencia(fechaUno, fechaDos);
                    Console.WriteLine("Diferencia en años y días:");
                    Console.WriteLine("\t- {0} años.", diferenciaAniosDiasACDC[0]);
                    Console.WriteLine("\t- {0} días.", diferenciaAniosDiasACDC[1]);
                }
                else
                {
                    Console.WriteLine("Se ha producido un error al obtener la entrada: {0}", mensajeDeError);
                }
            }
            else
            {
                Console.WriteLine("Se ha producido un error al obtener la entrada: {0}", mensajeDeError);
            }
            Console.WriteLine("Pulsa una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
