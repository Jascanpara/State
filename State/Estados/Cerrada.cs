using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Cerrada : EstadoVentanilla
    {
        public void Atende(Persona persona)
        {
            Console.WriteLine("");
            Console.WriteLine("Ventanilla cerrada¡");
            Console.WriteLine("");
        }
    }
}
