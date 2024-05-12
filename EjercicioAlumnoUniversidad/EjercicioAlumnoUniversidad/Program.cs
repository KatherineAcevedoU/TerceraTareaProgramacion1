using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioAlumnoUniversidad
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            Universidad mensajero2 = new Universidad();

            Console.WriteLine("----------------");
            Console.WriteLine("Datos del Alumno");
            Console.WriteLine("----------------");
            Console.WriteLine();

            //Creo instancias de la clase Alumno con diferente datos de algunos alumnos
                                                                                                                                              //Agruegue 4 notas de 4 parciales
            Alumno alumno1 = new Alumno("Katherine Nahemi Acevedo Umaña", 18, "2023-1031U", Alumno.Carreras.Ingenieria_De_Sistemas, new List<double> { 90.12, 89.4, 100, 78.4});  //Ingreso los datos del primer alumno
            Alumno alumno2 = new Alumno("Jacqueline de la concepcion Umaña Lopez", 21, "2022-1130U", Alumno.Carreras.Ingenieria_Industrial, new List<double> {});                 //Ingreso el segundo alumno


            //Mando a llamar al metodo AgregarAlumnoLista e ingreso cada objeto que contiene datos.

            mensajero2.AgregarAlumnoLista(alumno1);
            mensajero2.AgregarAlumnoLista(alumno2);

            

            //Este me permite mostrar los datos de los alumnos

            foreach (var totalAlumnos in mensajero2.ObtenerListaAlumno())  //El metodo  ObtenerLista contiene todos los datos
            {

                //La variable totalAlumnos permite obtener toda la informacion e imprime la lista con todos los datos.

                //Observacion, intente imprimir las calificaciones pero no pude.

                Console.WriteLine("---------------------------------------");
                Console.Write($"Nombre: {totalAlumnos.NombreCompletoAlumno} \n" +
                              $"Edad: {totalAlumnos.EdadAlumno} \n" +
                              $"No.Carnet: {totalAlumnos.NumeroCarnetAlumno} \n" +
                              $"Carrera: {totalAlumnos.CarreraAlumno} \n"+
                              $"Calificacion: {totalAlumnos.CalificacionesAlumno} \n" +
                              $"Promedio: {totalAlumnos.CalcularPromedioCalificaciones()} \n" + 
                              $"Observe: {totalAlumnos.EstadoAprobadoORebrobado()} \n");
                Console.WriteLine("---------------------------------------");
               
            }



            

        }
    }
}
