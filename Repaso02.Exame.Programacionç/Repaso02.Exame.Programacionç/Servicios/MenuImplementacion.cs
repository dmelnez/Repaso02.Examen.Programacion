using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso02.Exame.Programacionç.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuPrincipal()
        {

            Console.WriteLine("--------------------------------");
            Console.WriteLine("| [0] -> CERRAR APLICACION      |");
            Console.WriteLine("| [1] -> DAR ALTA ACTIVIDAD     |");
            Console.WriteLine("| [2] -> MOSTRAR UNA ACTIVIDAD  |");
            Console.WriteLine("| [3] -> ELIMINAR ACTIVIDAD     |");
            Console.WriteLine("--------------------------------");

            int selecionMenu = Convert.ToInt32(Console.ReadLine());
            return selecionMenu;

        }

    }
}
