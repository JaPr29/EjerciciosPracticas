using EJ20;
class Program
{
    static void Main(string[] args)
    {
        bool añadirjugadores = true;
        int contador = 2;
        List<Jugador> jugadores = new List<Jugador>();
        Console.WriteLine("¡Bienvenido al juego del tiro al blanco!");
        Console.WriteLine("Para ingresar, se necesitan dos jugadores, ingresen sus nombres y la distancia de sus tiradas:");

        Console.WriteLine("Jugador 1:");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("Distancia de los tiros (Ingrese las 3):");
        int distancia1 = int.Parse(Console.ReadLine());
        int distancia2 = int.Parse(Console.ReadLine());
        int distancia3 = int.Parse(Console.ReadLine());
        var puntaje1 = Puntaje.CalcularPuntaje(distancia1, distancia2, distancia3);



        Console.WriteLine("Jugador 2:");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("Distancia de los tiros (Ingrese las 3):");
        distancia1 = int.Parse(Console.ReadLine());
        distancia2 = int.Parse(Console.ReadLine());
        distancia3 = int.Parse(Console.ReadLine());
        var puntaje2= Puntaje.CalcularPuntaje(distancia1, distancia2, distancia3);

        Jugador jugador = new Jugador(nombre1, puntaje1);
        jugadores.Add(jugador);
        jugador = new Jugador(nombre2, puntaje2);
        jugadores.Add(jugador);

        while (añadirjugadores)
        {
            Console.WriteLine("¿Desea agregar más jugadores? (s/n)");

            string decisión = Console.ReadLine();


            switch (decisión)
            {
                case "S":
                case "s":
                    contador++;
                    Console.WriteLine("Jugador " + (contador) + ":");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Distancia de los tiros (Ingrese las 3):");
                    distancia1 = int.Parse(Console.ReadLine());
                    distancia2 = int.Parse(Console.ReadLine());
                    distancia3 = int.Parse(Console.ReadLine());
                    var puntaje = Puntaje.CalcularPuntaje(distancia1, distancia2, distancia3);

                    jugador = new Jugador(nombre, puntaje);
                    jugadores.Add(jugador);
                    break;

                case "N":
                case "n":
                    Console.Clear();
                    Console.WriteLine("Calculando puntajes...");
                    Thread.Sleep(3000);
                    añadirjugadores = false;
                    break;
            }
        }
        int Puntajemax = new();
        int numerodejugador = new();

        for (int i = 0; i < jugadores.Count; i++)
        {
            if (i == 0)
            {
                Puntajemax = jugadores[i].Puntaje;
                numerodejugador = i;
            }
            if (jugadores[i].Puntaje > Puntajemax)
            {
                Puntajemax = jugadores[i].Puntaje;
                numerodejugador = i;
            }
        }


        Console.WriteLine("El ganador es: " + jugadores[numerodejugador].Nombre + " con un puntaje de: " + Puntajemax);


    }
}