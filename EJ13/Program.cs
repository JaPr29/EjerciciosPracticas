class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese dos números para mostrar los números existentes entre sí de forma incluyente y excluyente.");
        Console.WriteLine("Ingrese el primer número (DEBE SER MENOR QUE EL SEGUNDO):");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        var num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("El primer número es mayor que el segundo, la operación no es posible");
            return;
        }

        Console.WriteLine("Los números existentes entre ambos números de forma incluyente son: ");
        for (int i = num1; i < num2 + 1; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        Console.WriteLine("Los números existentes entre ambos números de forma excluyente son: ");
        for (int i = num1 + 1; i < num2; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}