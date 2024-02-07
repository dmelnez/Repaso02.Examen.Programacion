using Repaso02.Exame.Programacionç.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso02.Exame.Programacionç.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de solicitar al usuario todos los datos que compondran todos los atributos de una actividad
        /// </summary>
        /// <param name="listaActividades"></param>
        public void altaActividad(List<Actividad> listaActividades);

        /// <summary>
        /// Metodo encargado de mostrar todos los campos de una actividad, identificada por el nombre de la misma
        /// </summary>
        /// <param name="listaActividades"></param>
        public void mostrartActividad(List<Actividad> listaActividades);


        /// <summary>
        /// Metodo encargado de mostrar todas las actividad existentes, identificar a una actividad por el nombre, y eliminarlo
        /// </summary>
        /// <param name="listaActividades"></param>
        public void eliminarActividad(List<Actividad> listaActividades);
       

    }
}
