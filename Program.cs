using System;
using System.Globalization;

namespace clui.scaling_meme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al proyecto: Fechas y Edades");
            string primeraFecha = NDFunciones.SolicitarFecha();
            if(SCFunciones.ValidarFecha(primeraFecha, "es"))
            {
                string segundaFecha = NDFunciones.SolicitarFecha();
                if (SCFunciones.ValidarFecha(segundaFecha, "es"))
                {                   
                    CultureInfo cultureInfoES = new CultureInfo("es-ES");
                    DateTime fechaUno = Convert.ToDateTime(primeraFecha, cultureInfoES);
                    DateTime fechaDos = Convert.ToDateTime(segundaFecha, cultureInfoES);
                    int diferenciaAnios=MMFunciones.CalcularEdadAños(fechaUno, fechaDos);
                    int diferenciaDias= MMFunciones.CalcularEdadDias(fechaUno, fechaDos);
                    Console.WriteLine("La diferencia entre las fechas dadas es: ");
                    Console.WriteLine("{0} años", diferenciaAnios);
                    Console.WriteLine("{0} días", diferenciaDias);
                }
                else
                {
                    Console.WriteLine("El formato escrito para la segunda fecha no es correcto");
                }
            }
            else
            {
                Console.WriteLine("El formato escrito para la primera fecha no es correcto");
            }
            Console.WriteLine("Pulsa una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
