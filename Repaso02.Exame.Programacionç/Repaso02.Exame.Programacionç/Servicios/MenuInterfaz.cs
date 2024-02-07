using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso02.Exame.Programacionç.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar al usuario el menu principal, recoger el valor introducido y devolver
        /// al metodo Main un int, conteniente a la seleccion del usuario.
        /// </summary>
        /// <author>DMN - 07/02/2024</author>
        /// <returns>int seleccionMenu</returns>
        public int menuPrincipal();
    }
}
