using System;

namespace Apunte_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine es como el printf de C. Muestra lo que escribamos entre ""
            //y le agrega un salto de línea al final (por eso se llama Line).
            Console.Write("Hola, me llamo: " + "Miguel");
            //En cambio, Console.Write (sin Line), no agrega un salto de línea al final.
            //Además, en C# se pueden concatenar mensajes así, usando el '+'.

            Console.WriteLine(""); //Lo tiro así para hacer un salto de línea.

            string pais = "Argentina";
            Console.WriteLine($"Soy de {pais}"); //"String interpolado"
            //También se puede usar la máscara '$', y darle el valor de una variable.
            //El nombre de la variable se escribe dentro del mensaje entre {}.
            int edad = 21;
            Console.WriteLine("Soy de {0} y tengo {1} años", pais, edad);
            //Esta es otra forma, en este caso usamos {0,1,2,3...} para agregar los valores
            //de las variables que queramos. La primera corresponde a '0' .. y así.

            //Ya sabemos que tanto en WriteLine como en Write se puede concatenar usando '+'.
            //Algo que también podemos hacer es operar, por ejemplo así:
            Console.WriteLine("En 30 años mi edad será: {0}", edad + 30);

            //Para colocar un salto de línea en un lugar en específico podemos hacer esto:
            Console.Write("Voy a poner un salto de línea aca:{0}Mi edad es {1}", Environment.NewLine, edad);
            //Environment.NewLine funciona como el \n de C, y en este caso corresponde a {0}.

            //Los errores se llaman excepciones.
        }
    }
}
