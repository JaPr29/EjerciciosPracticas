/class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mostrando números...");

        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}