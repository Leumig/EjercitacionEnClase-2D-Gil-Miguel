using System;

namespace Ej2._Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            float numeroIngresado;

            float numeroAlCuadrado;
            float numeroAlCubo;

            Console.WriteLine("Ingrese un número: ");
            numeroIngresadoString = Console.ReadLine();
            bool resultadoNumero = float.TryParse(numeroIngresadoString, out numeroIngresado);

            while (resultadoNumero == false || numeroIngresado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un número: ");
                numeroIngresadoString = Console.ReadLine();
                resultadoNumero = float.TryParse(numeroIngresadoString, out numeroIngresado);
            }

            //numeroAlCuadrado = numeroIngresado * numeroIngresado;
            //numeroAlCubo = numeroIngresado * numeroIngresado * numeroIngresado;
            numeroAlCuadrado = (float)Math.Pow(numeroIngresado, 2);
            numeroAlCubo = (float)Math.Pow(numeroIngresado, 3);

            Console.WriteLine("El número {0} al cuadrado es: {1}", numeroIngresado, numeroAlCuadrado);
            Console.WriteLine("El número {0} al cubo es: {1}", numeroIngresado, numeroAlCubo);
        }
    }
}




