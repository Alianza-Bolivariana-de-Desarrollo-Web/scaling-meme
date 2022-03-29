using Itenso.TimePeriod;
using System;

namespace clui.scaling_meme
{
    /// <summary>
    /// Clase de Sergio Coello.
    /// Actualizada: 28/03/2022.
    /// </summary>
    public class SCFunciones
    {
        /// <summary>
        /// Devuelve bool como resultado de la comprobación de un string como fecha.
        /// </summary>
        /// <param name="stringFecha">Argumento de tipo string con el valor de la fecha (Ej. 01/01/2022).</param>
        /// <param name="locale">Argumento de tipo string con el valor de la localización (Ej. es).</param>
        /// <param name="mensajeDeError">Devuelve por referencia de tipo string el mensaje de error.</param>
        /// <returns>true ó false (true = es una fecha válida, false = no es una fecha válida).</returns>
        public static bool ValidarFecha(string stringFecha, string locale, ref string mensajeDeError)
        {
            bool returnStatus = false;
            mensajeDeError = "";
            if (stringFecha.Trim().Length == 10)
            {
                if (locale == "es")
                {
                    string[] valoresFecha = stringFecha.Split('/');
                    if (int.TryParse(valoresFecha[0], out int valorDias))
                    {
                        if (valoresFecha[0].Length == 2)
                        {
                            if (valorDias <= 31 && valorDias >= 1)
                            {
                                if (int.TryParse(valoresFecha[0], out int valorMes))
                                {
                                    if (valoresFecha[1].Length == 2)
                                    {
                                        if (valorMes <= 31 && valorMes >= 1)
                                        {
                                            if (int.TryParse(valoresFecha[0], out _))
                                            {
                                                if (valoresFecha[2].Length == 4)
                                                {
                                                    returnStatus = true;
                                                }
                                                else
                                                {
                                                    mensajeDeError = "SCFunciones: Error, el valor correspondiente al AÑO no es válido.";
                                                    returnStatus = false;
                                                }
                                            }
                                            else
                                            {
                                                mensajeDeError = "SCFunciones: Error, el valor correspondiente al AÑO no es numérico.";
                                                returnStatus = false;
                                            }
                                        }
                                        else
                                        {
                                            mensajeDeError = "SCFunciones: Error, el valor correspondiente al MES no corresponde a una fecha válida.";
                                            returnStatus = false;
                                        }
                                    }
                                    else
                                    {
                                        mensajeDeError = "SCFunciones: Error, el valor correspondiente al MES no es válido.";
                                        returnStatus = false;
                                    }
                                }
                                else
                                {
                                    mensajeDeError = "SCFunciones: Error, el valor correspondiente al MES no es numérico.";
                                    returnStatus = false;
                                }
                            }
                            else
                            {
                                mensajeDeError = "SCFunciones: Error, el valor correspondiente al DÍA no corresponde a una fecha válida.";
                                returnStatus = false;
                            }
                        }
                        else
                        {
                            mensajeDeError = "SCFunciones: Error, el valor correspondiente al DÍA no es válido.";
                            returnStatus = false;
                        }
                    }
                    else
                    {
                        mensajeDeError = "SCFunciones: Error, el valor correspondiente al DÍA no es numérico.";
                        returnStatus = false;
                    }
                }
                else
                {
                    mensajeDeError = "SCFunciones: Error, no se ha especificado una región.";
                    returnStatus = false;
                }
            }
            else
            {
                mensajeDeError = "SCFunciones: Error, la fecha no tiene la longitud exacta.";
                returnStatus = false;
            }
            return returnStatus;
        }
        /// <summary>
        /// Calcula la diferencia en años y días entre una fecha A.C. y D.C.
        /// </summary>
        /// <param name="fechaAC">Fecha A.C.</param>
        /// <param name="fechaDC">Fecha D.C.</param>
        /// <returns>Array de int con el valor en años y días (años = pos. 0, días = pos. 1).</returns>
        public static int[] DiferenciaFechaAC(DateTime fechaAC, DateTime fechaDC)
        {
            int[] diferenciaAniosDias = new int[2];
            DateTime fechaZero = new DateTime(1, 1, 1);
            DateDiff diferenciaFechaACZero = new DateDiff(fechaAC, fechaZero);
            DateDiff diferenciaFechaDCZero = new DateDiff(fechaDC, fechaZero);
            diferenciaAniosDias[0] = Math.Abs(diferenciaFechaACZero.Years + diferenciaFechaDCZero.Years - 2);
            diferenciaAniosDias[1] = Math.Abs(diferenciaFechaACZero.Days + diferenciaFechaDCZero.Days - 2);
            return diferenciaAniosDias;
        }
    }
}
