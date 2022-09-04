using System;

namespace Apunte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString; //Creamos un string para leerlo con ReadLine
            int numeroIngresado; //Creamos el entero

            Console.WriteLine("Ingrese un número:");
            numeroIngresadoString = Console.ReadLine();
            //Console.ReadLine devuelve un string que el usuario ingrese. En este caso,
            //lo guardamos en la variable llamada numeroIngresadoString, la cual obviamente
            //es de tipo string.

            numeroIngresado = int.Parse(numeroIngresadoString);
            //Parse lo que hace es convertir tipos de variables entre int, float y strings.
            //Si lo que recibe es algo que no puede ser convertido en este caso a int,
            //provoca una excepción, es decir, un error.

            Console.WriteLine($"El número ingresado es: {numeroIngresado}");

            string edadIngresadaString;
            int edadIngresada;

            Console.WriteLine("Ingrese una edad:");
            edadIngresadaString = Console.ReadLine();

            bool resultadoEdad = int.TryParse(edadIngresadaString, out edadIngresada);
            /* Para evitar la excepción anterior con el Parse, se usa el método TryParse. 
             * Devuelve un dato de tipo booleano, que puede ser 'true' o 'false'.
             * Si no puede realizar el parseo, devuelve 'false', y si puede, 'true'.
             * En este caso creamos una variable de tipo bool llamada resultado, para 
             * ver cómo funciona el retorno del TryParse.
             * Además, tiene 2 argumentos, el primero es el dato a leer, y el segundo
             * es en dónde se va a guardar el dato parseado. */

            //El TryParse es más seguro que el Parse. Ambos vamos a usarlos para validar
            //el ingreso de datos numéricos.

            Console.WriteLine($"El parseo dió como resultado: {resultadoEdad}");
            Console.WriteLine($"La edad ingresada es: {edadIngresada}");

            string precioIngresadoString;
            float precioIngresado;

            Console.WriteLine("Ingrese un precio:");
            precioIngresadoString = Console.ReadLine();

            bool resultadoPrecio = float.TryParse(precioIngresadoString, out precioIngresado);

            if (resultadoPrecio == false)
            {
                Console.WriteLine("Dato inválido.");
            }
            else
            {
                Console.WriteLine($"El precio ingresado es: ${precioIngresado}");
                //Otra forma de mostrar un precio puede ser así:
                Console.WriteLine($"El precio ingresado es: {precioIngresado:C2}");
                //Ese 'C2' se llama 'especificador de formato'.
            }

            //Trabajando con números con decimales, tenemos otros 2 tipos de datos,
            //el 'double' y el 'decimal'.

            double numeroDoubleA = 0.1;
            double numeroDoubleB = 0.2;

            double resultadoEsperadoDouble = 0.3;
            double resultadoSumaDouble = numeroDoubleA + numeroDoubleB;

            Console.WriteLine("El resultado de la suma double es: {0}. ¿Era el resultado esperado?: {1}",
                resultadoSumaDouble, resultadoSumaDouble == resultadoEsperadoDouble);

            decimal numeroDecimalA = 0.1m;
            decimal numeroDecimalB = 0.2m;

            decimal resultadoEsperadoDecimal = 0.3m;
            decimal resultadoSumaDecimal = numeroDecimalA + numeroDecimalB;

            Console.WriteLine("El resultado de la suma decimal es: {0}. ¿Era el resultado esperado?: {1}",
                resultadoSumaDecimal, resultadoSumaDecimal == resultadoEsperadoDecimal);

            //Esto demuestra que el dato 'decimal' es más preciso que 'double'. Cuando necesitemos
            //precisión en el número, vamos a usar 'decimal' (el cual necesita agregar una 'm').


            /* C# es fuertemente tipado. Existe un tipo de variable llamada 'var'.
             * La cual NO funciona como el 'var' de JavaScript.
             * También hay otro tipo que es 'dynamic' el cual si es más como el 'var' de JavaScript.
             * Aún así, no se recomienda usarlos.
             */

            float precioConComa = 45.75f;

            int precioSinComa = (int)precioConComa;
            //Esto se llama CASTEO explícito. Ese '(int)' es un operador de casteo.
            //Castear es convertir un tipo de dato a otro.
            //En este caso, al pasar el float a int, estamos perdiendo el valor de los decimales.
            //Entonces, es una conversión explícita.

            Console.WriteLine($"El precio es: {precioSinComa}");

            int entero = 25;
            float numeroFlotante = 23.50f;

            //Conversión explícita (puede implicar pérdida de datos)
            entero = (int)numeroFlotante;

            //Conversión implícita (no implica pérdida de datos)
            numeroFlotante = entero;

            /* Diferencia entre Parsear y Castear
             * Parsear es cuando pasamos de un String a otro tipo de dato numérico.
             * Castear es cuando pasamos de un tipo a otro.
             */
        }
    }
}
