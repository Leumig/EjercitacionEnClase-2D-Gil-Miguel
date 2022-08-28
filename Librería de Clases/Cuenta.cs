using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Cuenta
    {
        string titular;
        int cantidad;

        public Cuenta()
        {
            titular = "NO CARGADO";
        }

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }




    }
}
