﻿using System;
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
                    Console.WriteLine("[PRIMERA FECHA] - {0}", primeraFecha);
                    Console.WriteLine("[SEGUNDA FECHA] - {0}", segundaFecha);

                    CultureInfo cultureInfoES = new CultureInfo("es-ES");
                    DateTime fechaUno = Convert.ToDateTime(primeraFecha, cultureInfoES);
                    DateTime fechaDos = Convert.ToDateTime(segundaFecha, cultureInfoES);
                    int diferenciaAnios = MMFunciones.CalcularEdadAnios(fechaUno, fechaDos);
                    int diferenciaDias = MMFunciones.CalcularEdadDias(fechaUno, fechaDos);
                    Console.WriteLine("Diferencia en años y días:");
                    Console.WriteLine("- {0} años.", diferenciaAnios);
                    Console.WriteLine("- {0} días.", diferenciaDias);

                    Console.WriteLine("[PRIMERA FECHA] - {0} A.C.");
                    Console.WriteLine("[SEGUNDA FECHA] - {0} D.C.");
                    int[] diferenciaAniosDiasACDC = SCFunciones.DiferenciaFechaAC(fechaUno, fechaDos);
                    Console.WriteLine("Diferencia en años y días:");
                    Console.WriteLine("- {0} años.", diferenciaAniosDiasACDC[0]);
                    Console.WriteLine("- {0} días.", diferenciaAniosDiasACDC[1]);
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