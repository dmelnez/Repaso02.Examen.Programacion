using Repaso02.Exame.Programacionç.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso02.Exame.Programacionç.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

         public void altaActividad(List<Actividad> listaActividades)
        {

            Actividad actividadNueva = new Actividad();

            // Fecha de Inicializacion de la ctividad, sera en base al DateTime.Now
            actividadNueva.FechaInicioActividad = DateTime.Now;


            Console.WriteLine("NOMBRE ACTIVIDAD: ");


            actividadNueva.NombreActividad = Console.ReadLine();

            Console.WriteLine("FECHA INICIO ACTIVIDAD: ");

            String fechaActividadString = Console.ReadLine();
            
            actividadNueva.FechaInicioActividad = Convert.ToDateTime(fechaActividadString);


            // Fecha de finalizacion de la actividad.
            // Sera en base al DatTime.NOW. 
            actividadNueva.FechaFinalActividad = DateTime.Now;

            // Operativa de calculo de Minutos
            if (actividadNueva.FechaFinalActividad > actividadNueva.FechaInicioActividad)
            {
                int auxAnios = actividadNueva.FechaFinalActividad.Year - actividadNueva.FechaInicioActividad.Year;
                int numeroAnios = Math.Abs(auxAnios);



                int auxMeses = actividadNueva.FechaFinalActividad.Month - actividadNueva.FechaInicioActividad.Month;
                int numeroMeses = Math.Abs(auxMeses);




                int auxDias = actividadNueva.FechaFinalActividad.Day - actividadNueva.FechaInicioActividad.Day;
                int numeroDias = Math.Abs(auxDias);



                // Operaciones de calculo en base al numero de anios, meses y dias de las fechas resultantes

                // Numero de dias 
                int auxOpDias = (numeroMeses * 30) + numeroDias;

                // Numero de Horas 
                int auxOpHoras = actividadNueva.FechaFinalActividad.Hour + (auxOpDias * 24);

                // Numero de Minutos
                int auxOpMinutos = actividadNueva.FechaFinalActividad.Minute + (auxOpHoras * 60);

                Console.WriteLine(auxOpMinutos);

                actividadNueva.DuracionActividadMin = auxOpMinutos;

            }


            else
            {

                Console.WriteLine("[ATENCION] -> LA FECHA NO PUEDE SER MAYOR A LA ACTUAL");



            }





            listaActividades.Add(actividadNueva);
        }



        public void mostrartActividad(List<Actividad> listaActividades)
        {
            Console.WriteLine("NOMBRE ACTIVIDAD: ");
            string actividadABuscarIntro = Console.ReadLine();


            foreach(var actividadABuscar in listaActividades)
            {

                if (actividadABuscar.NombreActividad.Equals(actividadABuscarIntro) == true)
                {

                    Console.WriteLine("NOMBRE ACTIVIDAD : " + actividadABuscar.NombreActividad);
                    Console.WriteLine("Fecha Inicio: " + actividadABuscar.FechaInicioActividad);
                    Console.WriteLine("FECHA FIN: " + actividadABuscar.FechaFinalActividad);
                    Console.WriteLine("DURACION: " + actividadABuscar.DuracionActividadMin);


                }



            }



        }



        public void eliminarActividad(List<Actividad> listaActividades)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---     ACTIVIDADES ACTIVAS    ---");
            Console.WriteLine("----------------------------------");
            
            foreach(var actividadMostrada in listaActividades){

                Console.WriteLine(actividadMostrada + " " );

            }

            Console.WriteLine("----------------------------------");



            Console.WriteLine("NOMBRE DE LA ACTIVIDAD: ");
            string actividadABorrar =  Console.ReadLine();







            foreach (var actividadABuscar in listaActividades)
            {

                if (actividadABuscar.NombreActividad.Equals(actividadABorrar) == true)
                {

                    listaActividades.Remove(actividadABuscar);
                    break;

                }

            }





        }




    }
}
