using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Suspendida : EstadoVentanilla
    {
        public void Atende(Persona persona)
        {
            if (persona.edad > 65)
            {
                Console.WriteLine("");
                Console.WriteLine("Atendiendo a " + persona.nombre+" "+persona.edad+" anhos "+ "3ra edad");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Espera 5 minutos por favor...   preferencia 3ra edad");
                Console.WriteLine("");
            }
        }
    }
}
