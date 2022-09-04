using Librería_de_Clases;
using System;

namespace Ej1._Creo_que_necesito_un_prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta[] listaDeCuentas = new Cuenta[3];

            Cuenta cuenta1 = new Cuenta("Miguel Ángel Gil", 20000);

            string mostrarPrimerCuenta = Cuenta.Mostrar(cuenta1);

            Console.WriteLine(mostrarPrimerCuenta);

            cuenta1.Ingresar(60000);

            mostrarPrimerCuenta = Cuenta.Mostrar(cuenta1);
            Console.WriteLine(mostrarPrimerCuenta); ;

            cuenta1.Retirar(30000);

            Console.WriteLine(cuenta1.Cantidad);

            cuenta1.Ingresar(15000);

            Console.WriteLine(cuenta1.Cantidad);

            cuenta1.Retirar(100000);

            Console.WriteLine(cuenta1.Cantidad);
        }
    }
}
