using System;

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
