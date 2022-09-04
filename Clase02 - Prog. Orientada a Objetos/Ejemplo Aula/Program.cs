using System;

namespace Ejemplo_Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("German");

            Profesor profesor1 = new Profesor("Curcio");

            //aula1.AgregarAlumno(alumno1);

            Materia laboratorioII = new Materia("Laboratorio II");
            Materia programacionII = new Materia("Programación II");

            Alumno[] listaAlumnos2D = new Alumno[3]
            {
                alumno1,
                new Alumno("Juan"),
                new Alumno("Miguel")
            };


            Aula aula1 = new Aula("2D", laboratorioII, profesor1, 20);
            Aula aula2 = new Aula("7G", programacionII, profesor1, 35);

        }
    }
}
