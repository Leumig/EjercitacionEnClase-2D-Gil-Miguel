using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona()
        {
            nombre = "NO CARGADO";
            fechaDeNacimiento = DateTime.MinValue;
            dni = 00000000;
        }

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }

        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }

            set
            {
                fechaDeNacimiento = value;
            }

        }
        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }

        }

        static public int CalcularEdad(DateTime fechaIngresada)
        {
            int edad;
            edad = DateTime.Today.AddTicks(-fechaIngresada.Ticks).Year - 1;
            return edad;
        }

        static public string Mostrar(Persona personaIngresada)
        {
            string nombreIngresado = personaIngresada.Nombre;
            DateTime fechaDeNacimientoIngresada = personaIngresada.FechaDeNacimiento;
            int dniIngresado = personaIngresada.Dni;
            int edad = CalcularEdad(personaIngresada.FechaDeNacimiento);

            string texto = "| NOMBRE: " + nombreIngresado + " | FECHA DE NACIMIENTO: " + fechaDeNacimientoIngresada.ToShortDateString() + " | "
                + "DNI: " + dniIngresado + " | EDAD: " + edad + " | " + EsMayorDeEdad(edad) + " |";
            return texto;
        }      

        static public string EsMayorDeEdad(int edadIngresada)
        {
            string texto = "ES MENOR DE EDAD";
            if(edadIngresada >= 18)
            {
                texto = "ES MAYOR DE EDAD";
            }
            return texto;
        }

    }
}
