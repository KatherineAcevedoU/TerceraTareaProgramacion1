using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAlumnoUniversidad
{
    public partial class Alumno
    {

        //Creamos las propiedades de alumno

        public string NombreCompletoAlumno { get; set; }
        public int EdadAlumno { get; set; }
        public string NumeroCarnetAlumno { get; set; }
        public Carreras CarreraAlumno { get; set;  }
        public List<double> CalificacionesAlumno { get; set; }  //Creamos una lista para la calficacion de los alumnos


        //Creamos constructor con parametro
        public Alumno(string nombre, int edad,string numeroCarnet, Carreras carrera, List<double> Calificacion)
        {

            this.NombreCompletoAlumno = nombre;
            this.EdadAlumno = edad;
            this.NumeroCarnetAlumno = numeroCarnet;
            this.CarreraAlumno = carrera;
            CalificacionesAlumno = new List<double>(Calificacion); //Inicializo una lista y guardo los datos que me pasen como parametro

        }


        //Valores fijos de la carrera
        public enum Carreras
        {

            Ingenieria_De_Sistemas,
            Ingenieria_En_Computacion,
            Ingenieria_Electronica,
            Ingenieria_Civil,
            Ingenieria_Industrial,
            Ingenieria_Quimica,
            Ingenieria_Agricola,
            Ingenieria_Mecanica,
            Telecomunicaciones

        }

        //Creamos un metodo para calcular el promedio de calificaciones
        public double CalcularPromedioCalificaciones()
        {

            if (CalificacionesAlumno.Count == 0)
            {

                return 0;  //Si no hay ninguna calificaciones en la lista, imprimira un cero.

            }

            double SumaDeCalificaciones = 0;

            foreach (var calificaciones in CalificacionesAlumno)
            {

                SumaDeCalificaciones += calificaciones;  //Esto me permite ir sumandole las notas del alumno en una sola variable llamada SumaDeCalificaciones

            }

            return SumaDeCalificaciones / CalificacionesAlumno.Count;  //Esto me da el promedio de calificacion del alumno

        }

        //Creamos un metodo para determinar si el alumno aprobo o reprobo
        public string EstadoAprobadoORebrobado()
        {

            double promedio = CalcularPromedioCalificaciones();

            if (promedio >= 60)
            {
                
                   return "Usted aprobo la asignatura"; 

            }
            else
            {

                   return "Usted reprobo la asignatura";

            }

        }

    }
 
}
