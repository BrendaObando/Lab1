using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01.Polimorfismo
{
    public class Circulo : Forma
    {
        public override void dibujar()
        {
            Console.WriteLine("Dibujando un circulo");
        }
    }
}
