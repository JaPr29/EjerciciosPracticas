class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para mostrar sus primeros 10 múltiplos");
        var num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(num * i);
        }

        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}