using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_empleados
{
    public class MenuDeOpciones
    {
        public static int MenuPrincipal()
        {
            int retorno;
            string opcion;
            Console.WriteLine("Menu Principal");
            Console.Write("1. Alta de empleado\n2. Baja de empleado\n3. Salir ");
            opcion = Console.ReadLine();
            if( int.TryParse(opcion,out retorno))
            {
                if(retorno > 0 && retorno < 4)
                {
                    retorno = Convert.ToInt32(opcion);
                }
                else
                {
                    retorno = -1;
                }
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }
    }
}
