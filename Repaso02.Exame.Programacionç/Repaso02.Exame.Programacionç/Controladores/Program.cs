using Repaso02.Exame.Programacionç.Dtos;
using Repaso02.Exame.Programacionç.Servicios;

namespace Repaso02.Exame.Programacionç.Controladores
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<Actividad> listaActividades = new List<Actividad>();

            MenuInterfaz me = new MenuImplementacion();

            OperativaInterfaz op = new OperativaImplementacion();


            bool cerrarMenu = false;

            do
            {
                switch (me.menuPrincipal())
                {

                    case 0:

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("- [INFO] -> Cierre de la Aplicacion -");
                        Console.WriteLine("-------------------------------------");
                        cerrarMenu = true;


                        break;

                    case 1:
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("- [INFO] -> Alta de una Actividad -");
                        Console.WriteLine("-----------------------------------");
                        op.altaActividad(listaActividades);

                        break;

                    case 2:

                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("- [INFO] -> Mostrar Actividad -");
                        Console.WriteLine("-------------------------------");

                        op.mostrartActividad(listaActividades);



              
                        break;

                    case 3:

                        Console.WriteLine("[INFO] -> Eliminar Actividad");
                        op.eliminarActividad(listaActividades);


                        break;



                default: Console.WriteLine("[ATENCION] -> Seleccione una opcion valida");
                        break;

                }


            }


            while (!cerrarMenu);


        }

    }


}
