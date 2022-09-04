using Librería_de_Clases;
using System;

namespace Ej2._Cuantas_primaveras_tenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Miguel", new DateTime(2001, 7, 12), 43596276);
            Persona persona2 = new Persona("Agustina", new DateTime(2006, 2, 24), 45874155);
            Persona persona3 = new Persona("Luis", new DateTime(1999, 12, 3), 42388107);

            Console.WriteLine(Persona.Mostrar(persona1));
            Console.WriteLine(Persona.Mostrar(persona2));
            Console.WriteLine(Persona.Mostrar(persona3));
        }
    }
}
