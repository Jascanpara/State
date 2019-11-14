using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Abierta : EstadoVentanilla
    {
        public void Atende(Persona persona)
        {
            Console.WriteLine("");
            Console.WriteLine("Atendiendo a "+persona.nombre + " " + persona.edad + " anhos");
            Console.WriteLine("");
        }
    }
}
