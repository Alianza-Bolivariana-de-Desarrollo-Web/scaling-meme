using System;
using System.Collections.Generic;
using System.Text;

namespace clui.scaling_meme
{
    class NDFunciones
    {
        public static string SolicitarFecha()
        {
            /// <summary>
            /// Solicita una fecha para luego comprobar si el formato de esta es correcto
            /// </summary>
            /// <param name="entradaFecha">string que contiene la fecha</param>
            /// <returns></returns>

            string entradaFecha = "";
            
            do
            {
                Console.WriteLine("Introduzca una fecha: ");
                entradaFecha = Console.ReadLine();
                if (entradaFecha.Trim().Length==0)
                {
                    Console.WriteLine("Debe introducir una fecha...");
                }
            } while (entradaFecha.Trim().Length == 0);
            return entradaFecha;      
        }
    }
}
