class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese dos números para saber cuál es el mayor.");
        Console.WriteLine("Ingrese el primer número");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        var num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("El primer número es el mayor");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("El segundo número es el mayor");
        }
        else
        {
            Console.WriteLine("Son el mismo número");
        }
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}