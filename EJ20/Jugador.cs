using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ20
{
    public class Jugador
    {
        

        public Jugador(string nombre, int puntaje)
        {
            Nombre = nombre;
            Puntaje = puntaje;
        }

        public string Nombre { get; set; }
        public int Puntaje { get; set; }
    }
}
