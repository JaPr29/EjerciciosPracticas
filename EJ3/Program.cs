class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        var num2 = Convert.ToInt32(Console.ReadLine());

        var guardado = num1;
        num1 = num2;
        num2 = guardado;

        Console.WriteLine("El primer numero intercambiado es: " + num1);
        Console.WriteLine("El segundo numero intercambiado es: " + num2);
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}