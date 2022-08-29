using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librería_de_Clases
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaDeNacimiento;
        public int dni;

        public Persona()
        {
            nombre = "NO CARGADO";
            //fechaDeNacimiento = DateTime.Today;
            dni = 0;
        }

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

       /*private int calcularEdad(DateTime fechaIngresada)
       {
            int edad;
            DateTime date;
            date = Convert.ToDateTime(fechaDeNacimiento);

            



        }
       */

    }
}
