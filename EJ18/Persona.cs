using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Constructores
{
    public class Persona
    {
        public Persona(string nombre, string apellido, uint edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public uint Edad { get; set; }
    }
}
