using System;
using System.Collections.Generic;
using System.Text;

namespace scaling_meme
{
    class SCFunciones
    {
        public static bool ValidarFecha(string stringFecha, string locale)
        {
            bool returnStatus = false;
            if (stringFecha.Trim().Length != 10)
            {
                if (locale == "es")
                {
                    string[] valoresFecha = stringFecha.Split('/');
                    if (int.TryParse(valoresFecha[0], out int valorDia))
                    {

                    }
                    else
                    {
                        returnStatus = false;
                    }
                }
                else
                {
                    //Console.WriteLine("SCFunciones: Error, la no se ha especificado una región.");
                    returnStatus = false;
                }
            }
            else
            {
                //Console.WriteLine("SCFunciones: Error, la fecha no tiene la longitud exacta.");
                returnStatus = false;
            }
            return returnStatus;
        }
    }
}
