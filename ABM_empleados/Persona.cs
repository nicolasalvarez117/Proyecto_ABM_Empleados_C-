using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_empleados
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public bool setNombre(string nombre)
        {
            bool retorno = false;
            if(Utilidades.SoloLetras(nombre))
            {
                nombre = nombre.ToLower();
                this.nombre = nombre;
                retorno = true;
            }
            return retorno;
        }
        public bool setApellido(string apellido)
        {
            bool retorno = false;
            if (Utilidades.SoloLetras(apellido))
            {
                apellido = apellido.ToLower();
                this.apellido = apellido;
                retorno = true;
            }
            return retorno;
        }
    }
}
