class Program
{
    static void Main(string[] args)
    {
        // Lectura de datos
        Console.WriteLine("Ingrese dos números naturales.");
        Console.WriteLine("Primer numero: ");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundo numero: ");
        var num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < 0 || num2 < 0)
        {
            Console.WriteLine("Los números no pueden ser negativos.");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
            return;
        }

        // Selección de operación
        Console.WriteLine("¿Que operación desea realizar?");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        var op = Convert.ToInt32(Console.ReadLine());

        // Calculos y resultados

        switch (op)
        {
            case 1:
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("El resultado de la division es: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("La operación no existe.");
                break;
        };


        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}