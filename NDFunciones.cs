using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_meme
{
    class NDFunciones
    {
        public static string SolicitarFecha()
        {
            string entradaFecha = "";
            
            do
            {
                Console.WriteLine("Introduzca una fecha: ");
                entradaFecha = Console.ReadLine();
                if (entradaFecha.Equals(""))
                {
                    Console.WriteLine("Debe introducir una fecha");
                }
            } while (entradaFecha.Equals(""));
            return entradaFecha;      
        }
    }
}
