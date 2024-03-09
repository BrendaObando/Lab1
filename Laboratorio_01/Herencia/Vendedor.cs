using Laboratorio_01.Abstracción;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_01.Herencia
{
    public class Vendedor : Persona, IVendedor
    {
        public int NumVentas { get; set; }
        public void AgregarVendedor()
        {
            Console.WriteLine("Agregar Vendedor (Vendedor)");
        }
        public void ActualizarVendedor()
        {

        }
        public void EliminarVendedor()
        {

        }
    }
}
