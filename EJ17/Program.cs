class Program
{
    static void Main(string[] args)
    {
        // Quizás lo hice más complicado de lo que debería ser pero fue la forma más fácil en la q pensé, la primera sinceramente.
        Console.WriteLine("Ingrese números para calcular el mínimo y el máximo, al terminar, presione 0 para imprimir los resultados.");
        bool contrl = true;
        bool contrl2 = true;
        int max = new();
        int min = new();
        while (contrl)
        {
            Console.WriteLine("Ingrese un número: ");
            var num = Convert.ToInt32(Console.ReadLine());
            if (contrl2)
            {
                max = num;
                min = num;
                contrl2 = false;
            }


            if (num == 0)
            {


                Console.WriteLine("El mínimo es: " + min);
                Console.WriteLine("El máximo es: " + max);
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadLine();
                contrl = false;
                break;
            }
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
    }
}