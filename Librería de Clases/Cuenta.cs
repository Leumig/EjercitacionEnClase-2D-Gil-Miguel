using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Cuenta
    {
        public string titular;
        public int cantidad;

        public Cuenta()
        {
            titular = "NO CARGADO";
        }

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        static public string Mostrar(Cuenta cuentaIngresada)
        {
            string titularIngresado = cuentaIngresada.titular;
            int cantidadIngresada = cuentaIngresada.cantidad;

            string texto = "| TITULAR: " + titularIngresado + " | CANTIDAD: "  + cantidadIngresada + " |";

            return texto;
        }

        public void Ingresar(int cantidadIngresada)
        {
            if(cantidadIngresada >= 0)
            {
                cantidad = cantidadIngresada;
            }
        }

        public void Retirar(int cantidadIngresada)
        {
            cantidad -= cantidadIngresada;
        }

    }
}
