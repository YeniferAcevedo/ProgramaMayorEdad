using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad
{
    public class Edad : Proceso
    {
        public bool calcularEdad()
        {
            double edad = this.getEdad();

            if (edad > 18 && edad < 100)
            {
                return true;
            }
            else if (edad > 1 && edad <= 18)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
