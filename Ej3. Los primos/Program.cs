using System;

namespace Ej3._Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorIngresadoString;
            float numeroIngresado;

            string codigoSalida = "salir";
            string continuarPrograma = "n";

            do
            {
                Console.WriteLine("Ingrese un número (o ingrese 'salir' para salir): ");
                valorIngresadoString = Console.ReadLine();
                bool resultadoNumero = float.TryParse(valorIngresadoString, out numeroIngresado);

                while ((resultadoNumero == false || numeroIngresado <= 0) && valorIngresadoString != codigoSalida)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.WriteLine("Ingrese un número (o ingrese 'salir' para salir): ");
                    valorIngresadoString = Console.ReadLine();
                    resultadoNumero = float.TryParse(valorIngresadoString, out numeroIngresado);
                }

                if (valorIngresadoString != codigoSalida)
                {
                    int numeroActual = 2;
                    int totalPrimosEncontrados = 1;

                    while (numeroActual <= numeroIngresado)
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
                            Console.WriteLine(numeroActual);
                            totalPrimosEncontrados++;
                        }

                        numeroActual++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Si desea ingresar otro número, escriba 's': ");
                    continuarPrograma = Console.ReadLine();
                }

                if (valorIngresadoString == codigoSalida)
                {
                    continuarPrograma = "n";
                }

            } while (continuarPrograma == "s");
        }
    }
}
