using Librería_de_Clases_Validadoras;
using System;

namespace Ej2._Desea_Continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuestaIngresada = "s";
            int acumuladorNumeros = 0;

            while (Validadora.ValidarRespuesta(respuestaIngresada) == true)
            {
                Console.WriteLine("Ingrese un número: ");
                string valorIngresadoString = Console.ReadLine();
                bool resultadoNumero = int.TryParse(valorIngresadoString, out int numeroIngresado);

                while (resultadoNumero == false)
                {
                    Console.WriteLine("Dato inválido");
                    Console.WriteLine("Ingrese un número: ");
                    valorIngresadoString = Console.ReadLine();
                    resultadoNumero = int.TryParse(valorIngresadoString, out numeroIngresado);
                }

                acumuladorNumeros += numeroIngresado;

                Console.WriteLine("¿Desea continuar ? (S / N)");
                respuestaIngresada = Console.ReadLine();
            }

            Console.WriteLine("La suma de todos los números es: " + acumuladorNumeros);
        }
    }
}
