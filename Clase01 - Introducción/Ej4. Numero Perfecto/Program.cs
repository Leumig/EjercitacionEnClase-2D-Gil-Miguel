using System;

namespace Ej4._Numero_Perfecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los primeros 4 números perfectos son:");

            int numeroActual = 2;
            int totalPerfectosEncontrados = 0;

            double resultadoFormula = 0;

            while (totalPerfectosEncontrados < 4)
            {
                bool esPrimo = true;

                for (int i = 2; i < numeroActual; i++)
                {
                    if (numeroActual % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    resultadoFormula = (Math.Pow(2, numeroActual - 1)) * (Math.Pow(2, numeroActual) - 1); //Fórmula de Euclides
                    Console.WriteLine(resultadoFormula);
                    totalPerfectosEncontrados++;
                }

                numeroActual++;
            }
            Console.WriteLine();
            Console.WriteLine("Se utilizo la fórmula del matemático Euclides.");

        }
    }
}
