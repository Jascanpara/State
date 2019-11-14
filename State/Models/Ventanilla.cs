using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Ventanilla
    {
        private EstadoVentanilla estado;

        public Ventanilla()
        {
            estado = new Abierta();
        }

        public void suspendete()
        {
            estado = new Suspendida();
            Console.WriteLine("");
            Console.WriteLine("Se suspendio Ventanilla");
            Console.WriteLine("");
        }

        public void Cerrate()
        {
            estado = new Cerrada();
            Console.WriteLine("");
            Console.WriteLine("Se cerro Ventanilla");
            Console.WriteLine("");
        }

        public void Abrite()
        {
            estado = new Abierta();
            Console.WriteLine("");
            Console.WriteLine("Se abrio Ventanilla");
            Console.WriteLine("");
        }

        public void atende(Persona persona)
        {
            estado.Atende(persona);
        }
    }
}
