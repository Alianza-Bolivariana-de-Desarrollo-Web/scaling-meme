using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_meme
{
    class SCFunciones
    {
        /// <summary>
        /// Devuelve bool como resultado de la comprobación de un string como fecha.
        /// </summary>
        /// <param name="stringFecha">Argumento de tipo string con el valor de la fecha (Ej. "01/01/2022").</param>
        /// <param name="locale">Argumento de tipo string con el valor de la localización (Ej. es).</param>
        /// <returns>true ó false (true = es una fecha válida, false = no es una fecha válida).</returns>
        public static bool ValidarFecha(string stringFecha, string locale)
        {
            DateTime dateTimeObject = new DateTime();
            return ValidarFecha(stringFecha, locale, ref dateTimeObject);
        }
        /// <summary>
        /// Devuelve bool como resultado de la comprobación de un string como fecha.
        /// </summary>
        /// <param name="stringFecha">Argumento de tipo string con el valor de la fecha (Ej. 01/01/2022).</param>
        /// <param name="locale">Argumento de tipo string con el valor de la localización (Ej. es).</param>
        /// <param name="dateTimeObject">Asigna el valor convertido de string a DateTime.</param>
        /// <returns>true ó false (true = es una fecha válida, false = no es una fecha válida).</returns>
        public static bool ValidarFecha(string stringFecha, string locale, ref DateTime dateTimeObject)
        {
            bool returnStatus = false;
            if (stringFecha.Trim().Length != 10)
            {
                if (locale == "es")
                {
                    string[] valoresFecha = stringFecha.Split('/');
                    if (int.TryParse(valoresFecha[0], out int valorDia))
                    {
                        if (valoresFecha[0].Length == 2)
                        {
                            if (int.TryParse(valoresFecha[0], out int valorMes))
                            {
                                if (valoresFecha[1].Length == 2)
                                {
                                    if (int.TryParse(valoresFecha[0], out int valorAnio))
                                    {
                                        if (valoresFecha[2].Length == 4)
                                        {
                                            returnStatus = true;
                                            dateTimeObject = new DateTime(valorDia + '/' + valorMes + '/' + valorAnio);
                                        }
                                        else
                                        {
                                            Console.WriteLine("SCFunciones: Error, el valor correspondiente al AÑO no es válido.");
                                            returnStatus = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("SCFunciones: Error, el valor correspondiente al AÑO no es numérico.");
                                        returnStatus = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("SCFunciones: Error, el valor correspondiente al MES no es válido.");
                                    returnStatus = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("SCFunciones: Error, el valor correspondiente al MES no es numérico.");
                                returnStatus = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("SCFunciones: Error, el valor correspondiente al DÍA no es válido.");
                            returnStatus = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("SCFunciones: Error, el valor correspondiente al DÍA no es numérico.");
                        returnStatus = false;
                    }
                }
                else
                {
                    Console.WriteLine("SCFunciones: Error, no se ha especificado una región.");
                    returnStatus = false;
                }
            }
            else
            {
                Console.WriteLine("SCFunciones: Error, la fecha no tiene la longitud exacta.");
                returnStatus = false;
            }
            return returnStatus;
        }
    }
}
