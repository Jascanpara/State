using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona P1 = new Persona("Sharon",   "Woge",       21);
            Persona P2 = new Persona("Javier",   "Palacios",   21);
            Persona P3 = new Persona("Fernando", "Raposo",     72);
            Persona P4 = new Persona("Lizette",  "Altamirano", 41);

            Banco banco = new Banco();
            banco.abriVentanilla();
            banco.atende(P1);

            banco.suspendeVentanilla();

            banco.atende(P2);
            banco.atende(P3);

            banco.cerraVentanilla();
            banco.atende(P4);

            System.Threading.Thread.Sleep(50000);
        }
    }
}
