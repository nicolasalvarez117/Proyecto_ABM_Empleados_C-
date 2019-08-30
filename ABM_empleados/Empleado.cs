using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_empleados
{
    public class Empleado:Persona
    {
        private double sueldo;

        public bool setSueldo(string sueldo)
        {
            bool retorno = false;
            if ( double.TryParse(sueldo,out this.sueldo))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
