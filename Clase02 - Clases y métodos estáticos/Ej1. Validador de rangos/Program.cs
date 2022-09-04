using Librería_de_Clases_Validadoras;
using System;

namespace Ej1._Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorIngresadoString;
            int numeroIngresado;
            bool flagPrimerNumeroIngresado = false;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int contadorDeNumeros = 0;
            int acumuladorDeNumeros = 0;
            float promedioDeNumeros;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                valorIngresadoString = Console.ReadLine();
                bool resultadoNumero = Validadora.ValidarNumerico(valorIngresadoString, -100, 100);

                while (resultadoNumero == false)
                {
                    Console.WriteLine("Dato inválido, debe ingresar un número entero entre el -100 y el 100.");
                    Console.WriteLine("Ingrese un número: ");
                    valorIngresadoString = Console.ReadLine();
                    resultadoNumero = Validadora.ValidarNumerico(valorIngresadoString, -100, 100);
                }

                numeroIngresado = int.Parse(valorIngresadoString);

                if (flagPrimerNumeroIngresado == false)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                    flagPrimerNumeroIngresado = true;
                }
                else
                {
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                }
                contadorDeNumeros++;
                acumuladorDeNumeros += numeroIngresado;
            }

            promedioDeNumeros = (float)acumuladorDeNumeros / contadorDeNumeros;

            Console.WriteLine($"El número máximo es: {numeroMaximo}");
            Console.WriteLine($"El número mínimo es: {numeroMinimo}");
            Console.WriteLine($"El promedio es: {promedioDeNumeros}");
        }

    }
}
