using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Aula
{
    public class Aula
    {
        public string comision;
        public Materia materia;
        public Profesor docente;
        public Alumno[] listaAlumnos;

        private Aula(string comision, Materia materia, Profesor docente)
        {
            this.comision = comision;
            this.materia = materia;
            this.docente = docente;
        }//Este constructor lo tenemos que poner en privado para que no pueda ser invocado en el program.
        //Esto es así porque si lo llamamos en el program, vamos a inicializar en null al array de tipo Alumno,
        //y no queremos que eso pase. Así que este constructor sólo lo utilizamos acá, en el proyecto clase.

        public Aula(string comision, Materia materia, Profesor docente, int capacidad) : this(comision, materia, docente)
        {
            //this.comision = comision;
            //this.materia = materia;
            //this.docente = docente;
            this.listaAlumnos = new Alumno[capacidad];
            //De esta forma estaría creando la lista de alumnos de este aula con la capacidad recibida.
            //En este caso es como si estuvieramos construyendo el aula, todos los pupitres, pero SIN los alumnos.
        }

        public Aula(string comision, Materia materia, Profesor docente, Alumno[] listaAlumnos) : this(comision, materia, docente)
        {
            //this.comision = comision;
            //this.materia = materia;
            //this.docente = docente;
            this.listaAlumnos = listaAlumnos;
            //De esta forma estaría creando la lista de alumnos de este aula con una lista específica recibida.
            //Todos los alumnos van a tener los atributos correspondientes.
        }

        public void AgregarAlumno(Alumno alumno1)
        {

        }
    }
}