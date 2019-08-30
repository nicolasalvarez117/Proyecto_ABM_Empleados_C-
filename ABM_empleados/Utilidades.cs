using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_empleados
{
    public class Utilidades
    {
        

        public static bool SoloLetras(string cadena)
        {
            bool retorno = true;
            int i = 0;
            while(i < cadena.Length)
            {
                if( (cadena[i] < 'a' || cadena[i] > 'z') && 
                    (cadena[i] < 'A' || cadena[i] > 'Z') && 
                    (cadena[i] != ' ') )
                {
                    retorno = false;
                }
                i++;
            }
            return retorno;
        }
        public static void PreguntarDatosPorTeclado(Empleado nuevoEmpleado)
        {
            string auxString;

            Console.Write("Ingrese el nombre: ");
            auxString = Console.ReadLine();
            while( !nuevoEmpleado.setNombre(auxString))
            {
                Console.Write("nombre incorrecto, reingrese el nombre: ");
                auxString = Console.ReadLine();
            }
            Console.Write("Ingrese el apellido: ");
            auxString = Console.ReadLine();
            while(!nuevoEmpleado.setApellido(auxString))
            {
                Console.Write("apellido incorrecto, reingrese el apellido: ");
                auxString = Console.ReadLine();
            }
            Console.Write("Ingrese el sector: ");
            auxString = Console.ReadLine();
            while(!nuevoEmpleado.setSueldo(auxString))
            {
                Console.Write("error, caracter incorrecto. Reingrese el sueldo: ");
                auxString = Console.ReadLine();
            }
            
            
        }
        public static void NuevoEmpleado(List<Empleado> lista)
        {
            Empleado nuevo = new Empleado();
            PreguntarDatosPorTeclado(nuevo);
            lista.Add(nuevo);
        }
    }
}
