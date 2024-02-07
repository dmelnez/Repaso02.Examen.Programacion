using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso02.Exame.Programacionç.Dtos
{
    internal class Actividad
    {
        long idActividad;

        string nombreActividad = "aaaaa";


        DateTime fechaInicioActividad ;

        DateTime fechaFinalActividad ;

        int duracionActividadMin = 11111;

        public long IdActividad { get => idActividad; set => idActividad = value; }
        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FechaInicioActividad { get => fechaInicioActividad; set => fechaInicioActividad = value; }
        public DateTime FechaFinalActividad { get => fechaFinalActividad; set => fechaFinalActividad = value; }
        public int DuracionActividadMin { get => duracionActividadMin; set => duracionActividadMin = value; }



        public Actividad() { }

        public Actividad(long idActividad, string nombreActividad, DateTime fechaInicioActividad, DateTime fechaFinalActividad, int duracionActividadMin)
        {
            IdActividad = idActividad;
            NombreActividad = nombreActividad;
            FechaInicioActividad = fechaInicioActividad;
            FechaFinalActividad = fechaFinalActividad;
            DuracionActividadMin = duracionActividadMin;
        }

        override 

          public string ToString()
            {

            string MetodoString =

             "NOMBRE : " + this.nombreActividad +
             "DURACION: " + this.DuracionActividadMin;

                   return MetodoString;


            }

    }
}
