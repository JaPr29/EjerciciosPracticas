using Ejercicios.Constructores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los datos de un grupo de personas, el programa terminará cuando en lugar de un nombre, se ingrese un asterisco (*)");
        List<Persona> personas = new List<Persona>();
        bool contrl = true;
        while (contrl)
        {
            Console.WriteLine("Ingrese un nombre: ");
            var nombre = Console.ReadLine();
            if (nombre == "*")
            {
                contrl = false;
                break;
            }
            Console.WriteLine("Ingrese un apellido: ");
            var apellido = Console.ReadLine();
            Console.WriteLine("Ingrese una edad: ");
            var edad = Convert.ToUInt32(Console.ReadLine());

            Persona persona = new Persona(nombre, apellido, edad);

            personas.Add(persona);

            // Console.WriteLine(personas[0].Nombre + " " + personas[0].Apellido + " " + personas[0].Edad);

        }


        uint edadmin = new uint();
        int edadcont = new int();


        for (var i = 0; i < personas.Count; i++)
        {
            if (i == 0)
            {
                edadmin = personas[i].Edad;
                edadcont = i;
            }
            if (personas[i].Edad < edadmin)
            {
                edadmin = personas[i].Edad;
                edadcont = i;
            }
        }


        Console.WriteLine("La persona más joven es: " + personas[edadcont].Nombre + " " + personas[edadcont].Apellido + " con " + personas[edadcont].Edad + " años.");

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }   
}
