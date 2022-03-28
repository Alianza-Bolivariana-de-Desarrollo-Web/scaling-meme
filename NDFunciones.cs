using System;

namespace clui.scaling_meme
{
    /// <summary>
    /// Clase de Nauzet Dorta.
    /// Actualizada: 28/03/2022.
    /// </summary>
    class NDFunciones
    {
        /// <summary>
        /// Solicita una entrada por teclado que no puede ser vacía.
        /// </summary>
        /// <returns>Entrada de tipo string no vacía.</returns>
        public static string SolicitarFecha()
        {       
            string entradaFecha = "";
            do
            {
                Console.WriteLine("Introduzca una fecha (DD/MM/YYYY): ");
                entradaFecha = Console.ReadLine();
                if (entradaFecha.Trim().Length == 0)
                {
                    Console.WriteLine("Debe introducir na entrada no vacía...");
                }
            } while (entradaFecha.Trim().Length == 0);
            return entradaFecha;      
        }
    }
}
