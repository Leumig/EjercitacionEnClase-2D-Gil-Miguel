using Librería_de_Clases;
using System;

namespace Ej9._Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            string valorIngresado = Console.ReadLine();

            int numeroIngresado = int.Parse(valorIngresado);

            int resultadoFactorial = Calculadora.CalcularFactorial(numeroIngresado);

            Console.WriteLine("El factorial de {0} es: {1}", numeroIngresado, resultadoFactorial);
        }
    }
}
