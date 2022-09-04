using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases_Validadoras
{
    public static class Validadora
    {
        //Podría crear atributos
        private static int rangoMinimo; //Este atributo PUEDE cambiar su valor durante la ejecución del programa.
        private const int RANGO_MAXIMO = 100; //Este atributo es una CONSTANTE. Su valor NO PUEDE cambiarse. 

        static Validadora() //Constructor estático. Se ejecuta solo, la primera vez que interactuemos con la clase.
        {
            //La función del Constructor estático es inicializar los valores de los atributos estáticos de la clase.
            rangoMinimo = 1;
        }

        public static bool ValidarNumerico(string datoIngresado, int valorMinimo, int valorMaximo)
        {
            //int numeroParseado = int.Parse(datoIngresado);

            return (Validadora.EsNumerico(datoIngresado) && Validadora.ValidarRango(datoIngresado, valorMinimo, valorMaximo));

            // *** La hice diferente porque con el método ValidarRango CREO que no funcionaba bien. ***

            //return (Validadora.EsNumerico(datoIngresado) && Validadora.ValidarRango(numeroParseado, valorMinimo, valorMaximo));

            //'EsNumerico' al ser static, lo llamo nombrando la clase 'Validadora.'
            //Si mi método EsNumerico no fuera static, tendría que si o si crear una instancia.
            //Aun así, como esta clase Validadora es static, TODOS sus miembros deben ser static.
            //Lo mismo pasa si usara rangoMinimo y RANGO_MAXIMO. Al ser atributos estáticos, los llamo con Validadora.
        }

        private static bool ValidarRango(string valorIngresado, int valorMinimo, int valorMaximo)
        {
            int numeroParseado = int.Parse(valorIngresado);
            return numeroParseado > valorMinimo && numeroParseado < valorMaximo;

            // *** La hice diferente, hice que valorIngresado ingrese como string y parseo (en vez de ser int).
            //return valorIngresado > valorMinimo && valorIngresado < valorMaximo;
        }

        public static bool EsNumerico(string numero)
        {
            int retorno;
            if(int.TryParse(numero, out retorno))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarRespuesta(string respuestaIngresada)
        {
            return respuestaIngresada == "s" || respuestaIngresada == "S";
        }

        public static bool ValidarOperacion(string operacionIngresada)
        {
            return operacionIngresada == "+" || operacionIngresada == "-"
                   || operacionIngresada == "*" || operacionIngresada == "/";
        }


        //
        //Este método esta mal por varios motivos. En primer lugar, el clean code.
        //Tenemos que aprender a atomizar el código. Este método 'ValidarEdad' es poco reutilizable.
        //Lo correcto es usar un método más general como el 'ValidarNumérico', etc.
        //También esta mal porque le estamos pasando un tipo Persona entero, en vés de
        //solo pasarle el atributo que vamos a usar. Lo correcto sería pasarle un int persona.edad.
        //
        //public static bool ValidarEdad(Persona persona)
        //{
        //    if (persona is not null)
        //    {
        //        if persona(persona.edad > 0 && persona.edad < 200)
        //        {

        //        }
        //    }
        //}
        //
    }
}
