using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01.Polimorfismo
{
    public class Forma
    {
        public virtual void dibujar()
        {
            Console.WriteLine("Dibujando una forma generica");
        }
    }
}
