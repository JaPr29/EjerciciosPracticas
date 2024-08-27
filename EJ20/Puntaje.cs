using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ20
{
    public class Puntaje
    {
        public static int CalcularPuntaje(int dist1, int dist2, int dist3)
        {
            int puntaje = 0;
            switch (dist1)
            {
                case int n when (n == 0):
                    puntaje += 500;
                    break;
                case int n when (n <= 10 && n > 0):
                    puntaje += 250;
                    break;
                case int n when (n > 10 && n <= 50):
                    puntaje += 100;
                    break;
                case int n when (n > 50):
                    puntaje += 0;
                    break;
            }

            switch (dist2)
            {
                case int n when (n == 0):
                    puntaje += 500;
                    break;
                case int n when (n <= 10 && n > 0):
                    puntaje += 250;
                    break;
                case int n when (n > 10 && n <= 50):
                    puntaje += 100;
                    break;
                case int n when (n > 50):
                    puntaje += 0;
                    break;
            }

            switch (dist3)
            {
                case int n when (n == 0):
                    puntaje += 500;
                    break;
                case int n when (n <= 10 && n > 0):
                    puntaje += 250;
                    break;
                case int n when (n > 10 && n <= 50):
                    puntaje += 100;
                    break;
                case int n when (n > 50):
                    puntaje += 0;
                    break;
            }

            return puntaje;
        }
    }
}
