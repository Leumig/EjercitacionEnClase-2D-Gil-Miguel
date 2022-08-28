using System;

namespace Ej1._Max__Min__Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorIngresadoString;
            int numeroIngresado;
            int flagPrimerNumeroIngresado = 0;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            int contadorDeNumeros = 0;
            int acumuladorDeNumeros = 0;
            float promedioDeNumeros;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                valorIngresadoString = Console.ReadLine();
                bool resultadoNumero = int.TryParse(valorIngresadoString, out numeroIngresado);

                while (resultadoNumero == false)
                {
                    Console.WriteLine("Dato inválido");
                    Console.WriteLine("Ingrese un número: ");
                    valorIngresadoString = Console.ReadLine();
                    resultadoNumero = int.TryParse(valorIngresadoString, out numeroIngresado);
                }

                if (flagPrimerNumeroIngresado == 0 && resultadoNumero == true)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                    flagPrimerNumeroIngresado = 1;
                }
                else
                {
                    if (numeroIngresado > numeroMaximo && resultadoNumero == true)
                    {
                        numeroMaximo = numeroIngresado;
                    }

                    if (numeroIngresado < numeroMinimo && resultadoNumero == true)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                }
                contadorDeNumeros++;
                acumuladorDeNumeros = acumuladorDeNumeros + numeroIngresado;
            }

            promedioDeNumeros = (float)acumuladorDeNumeros / contadorDeNumeros;

            Console.WriteLine($"El número máximo es: {numeroMaximo}");
            Console.WriteLine($"El número mínimo es: {numeroMinimo}");
            Console.WriteLine($"El promedio es: {promedioDeNumeros}");
        }
    }
}
