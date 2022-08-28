using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2._Desea_Continuar
{
    internal class Validador
    {
        static public bool ValidarRespuesta(string respuestaIngresada)
        {
            if(respuestaIngresada == "s" || respuestaIngresada == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
