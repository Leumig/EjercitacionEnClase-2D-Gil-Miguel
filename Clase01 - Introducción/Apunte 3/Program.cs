using System;

namespace Apunte_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro un array
            string[] nombres = new string[3];

            //Cargo valores de forma secuencial
            nombres[0] = "Lucas";
            nombres[1] = "Juan";
            nombres[2] = "Nacho";

            //Muestro
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            //Otra forma de declarar
            string[] paises = { "Brasil", "Peru", "Argentina" };

            //Muestro
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }

            //Otra forma de mostrar
            foreach (string itemPais in paises) //Itero sobre el array 'paises' y guardo cada valor en 'itemPais'
            {
                Console.WriteLine(itemPais);
            }
        }
    }
}
