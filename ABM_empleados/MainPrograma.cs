using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_empleados
{
    class MainPrograma
    {
        static void Main(string[] args)
        {
            int opcion;
            List <Empleado> lista = new List<Empleado>();
            do
            {
                switch (opcion = MenuDeOpciones.MenuPrincipal())
                {
                    case -1:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                    case 1:
                        Utilidades.nuevoEmpleado(lista);
                        break;
                }
            }while (opcion != 3);
        }
    }
}
