using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Banco
    {
        private Ventanilla ventanilla;

        public Banco()
        {
            ventanilla = new Ventanilla();
        }

        public void atende(Persona persona)
        {
            Console.WriteLine(persona.nombre+" " + persona.edad + " anhos" + " ingreso a la fila");
            ventanilla.atende(persona);
        }

        public void suspendeVentanilla()
        {
            ventanilla.suspendete();
        }

        public void cerraVentanilla()
        {
            ventanilla.Cerrate();
        }
        public void abriVentanilla()
        {
            ventanilla.Abrite();
        }
    }
}
