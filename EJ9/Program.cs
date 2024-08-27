class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sistema de la Montaña Rusa Infierno, Ingrese los datos: ");
        Console.WriteLine("Ingrese la Edad: ");
        var edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la Altura en centímetros: ");
        var altura = Convert.ToInt32(Console.ReadLine());

        if (edad < 7 || altura < 150)
        {
            Console.WriteLine("No puede entrar");
        }
        else
        {
            Console.WriteLine("Puede entrar.");
        };
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine()
    }
}