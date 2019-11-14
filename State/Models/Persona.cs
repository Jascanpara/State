using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        public Persona(string _nombre, string _apellido, int _edad)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.edad = _edad;
        }
    }
}
