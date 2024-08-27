class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el salario por hora de trabajo.");
        var salario = Single.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el total diario de horas laborales.");
        var tiempo = Single.Parse(Console.ReadLine());

        var sabado = salario * (tiempo / 2);
        var salariosemanal = (salario * tiempo) * 5 + sabado;

        Console.WriteLine("El salario semanal es: " + salariosemanal);
        Console.WriteLine("Presione Enter para continuar.");
        Console.ReadLine();

    }
}