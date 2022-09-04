using System;

namespace Ejemplo_Guitarra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidxs a la tienda de musica");
            Console.WriteLine("¿Qué desean comprar?");


            //Creo 2 objetos 'guitarra1' y 'guitarra2'. Ambos son variables de tipo Guitarra.
            //Guitarra es la clase que creamos. Usamos la palabra reservada 'new' para invocar
            //a los constructores que hayamos creado en la clase.
            //Esto es una Instancia. Un Objeto es la instancia de una clase.
            Guitarra guitarra1 = new Guitarra("Gibson", 60000, "Melamina", false, 12);
            Guitarra guitarra2 = new Guitarra("Fender", 20000, true);

            //Aca creo un array de tipo Guitarra llamado stockGuitarras.
            //Lo creo dandole 2 items.
            Guitarra[] stockGuitarras = new Guitarra[2];

            //A cada item le doy el valor del objeto que creamos anteriormente.
            stockGuitarras[0] = guitarra1;
            stockGuitarras[1] = guitarra2;

            //Recorro el array de guitarras con un foreach.
            foreach (Guitarra itemGuitarra in stockGuitarras)
            {
                Console.WriteLine(itemGuitarra.marca);
                Console.WriteLine(itemGuitarra.precio);
                Console.WriteLine();
            }

            //Modifico los valores y vuelvo a mostrar.
            //Siempre que modifiquemos el valor de un objeto, se va a actualizar
            //en todos los lugares del programa en el cual aparezca el objeto.
            guitarra1.precio = 10000;
            guitarra2.marca = "Slasher";

            foreach (Guitarra itemGuitarra in stockGuitarras)
            {
                Console.WriteLine(itemGuitarra.marca);
                Console.WriteLine(itemGuitarra.precio);
                Console.WriteLine();
            }
        }
    }
}
