using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las notas de los trimestres.");
        Console.WriteLine("Trimestre 1: ");
        var nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Trimestre 2: ");
        var nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Trimestre 3: ");
        var nota3 = Convert.ToInt32(Console.ReadLine());

        var promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("El promedio es: " + promedio);
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

}