using EJ19;
class Program
{
    static void Main(string[] args)
    {
        int intentos = 3;
        bool control = true;
        while (control)
        {

            Usuario usuario = new Usuario(usuario: "admin", contraseña: "123456");


            Console.WriteLine("Bienvenido al sitio web, por favor, ingrese sus credenciales");

            Console.Write("Usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Contraseña: ");
            string contraseñaIngresada = Console.ReadLine();


            if (usuarioIngresado != usuario.usuario)
            {
                Console.WriteLine("El usuario especificado no existe en el sistema.");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                while (contraseñaIngresada != usuario.contraseña && intentos > 0)
                {
                    Console.WriteLine("Contraseña incorrecta. Por favor, ingrese nuevamente la contraseña. Tiene " + intentos + " intento/s.");
                    Console.Write("Contraseña: ");
                    contraseñaIngresada = Console.ReadLine();
                    intentos -= 1;
                }

                if (intentos == 0)
                {
                    Console.WriteLine("Se han agotado los intentos. Por favor, contacte al administrador.");
                }
                else
                {
                    Console.WriteLine("Contraseña correcta. ¡Ha iniciado sesión exitosamente!");
                }
                control = false;
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}