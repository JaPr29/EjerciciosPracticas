class Program
{
    static void Main(string[] args)
    {
        var mayor = 0;
        Console.WriteLine("Ingrese 3 números para saber cual es el mayor de todos ellos.");
        Console.WriteLine("Ingrese el primer número");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        var num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer número");
        var num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
        }
        else if (num3 > num1 && num3 > num2)
        {
            mayor = num3;
        }
        else
        {
            Console.WriteLine("Todos los números son iguales");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("El mayor es: " + mayor);
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}