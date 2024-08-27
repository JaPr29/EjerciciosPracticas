class Program
{
    static void Main(string[] args)
    {
        int cantidadimpar = new();
        int promedio = new();
        Console.WriteLine("Ingrese 5 edades para calcular el promedio de edad y las edades impares mayores a 18.");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad > 18 && edad % 2 != 0)
            {
                cantidadimpar += 1;
            }

            promedio += edad;
        }
        promedio = promedio / 5;
        Console.WriteLine("El promedio de edad es " + promedio + " y la cantidad de edades impares mayores a 18 es " + cantidadimpar);
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }
}