using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Calculadora
    {
        public static int Calcular(int primerOperando, int segundoOperando, string operacionMatematica)
        {
            int resultadoOperacion;
            switch (operacionMatematica)
            {
                case "+":
                    resultadoOperacion = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultadoOperacion = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultadoOperacion = primerOperando * segundoOperando;
                    break;
                default:
                    if(Validar(segundoOperando))
                    {
                        resultadoOperacion = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                        resultadoOperacion = 0;
                    }
                    break;
            }
            return resultadoOperacion;
        }

        private static bool Validar(int segundoOperando)
        {
            return segundoOperando != 0;
        }

        public static int CalcularFactorial(int numeroIngresado)
        {
            int resultadoFactorial = numeroIngresado;
            int iteraciones = numeroIngresado;

            for (int restador = 1; iteraciones > 1; restador++)
            {
                resultadoFactorial = resultadoFactorial * (numeroIngresado - restador);
                iteraciones--;
            }
            return resultadoFactorial;
        }
    }
}
