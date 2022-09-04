using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta()
        {
            titular = "NO CARGADO";
        }

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get 
            { 
                return titular; 
            } 
        }

        public int Cantidad
        {
            get
            {
                return cantidad;    
            }
        }

        static public string Mostrar(Cuenta cuentaIngresada)
        {
            string titularIngresado = cuentaIngresada.Titular;
            int cantidadIngresada = cuentaIngresada.Cantidad;

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
