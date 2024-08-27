class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número");
        var num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}