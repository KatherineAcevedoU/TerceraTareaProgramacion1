using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAlumnoUniversidad
{
    public partial class Universidad
    {

        //Creamos una lista de datos para alumnos

        public List<Alumno> listaAlumnos;


        //Creamos un constructor
        public Universidad()
        {

            listaAlumnos = new List<Alumno>();

        }


        //Creamos un metodo para agregar un nuevo alumno a la lista
        public void AgregarAlumnoLista(Alumno alumnoNuevo)
        {

            listaAlumnos.Add(alumnoNuevo);  //Agregamos un alumno a la lista


        }

        //Creamos un metodo para obtener todos los alumnos
        public List<Alumno> ObtenerListaAlumno()
        {
           
            return listaAlumnos; //Nos va devolver la lista de los alumnos

        }

         

    }
}
