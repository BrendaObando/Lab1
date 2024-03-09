using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01.Encapsulamiento
{
    public class Persona
    {
        public int nombre { get; set; }
        public int edad
        {
            get
            {
                return edad;
            }
            private set
            {
                edad = value;
            }
        }
    }
}
