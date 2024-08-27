class Program
{
    static void Main(string[] args)
    {
        bool contr = true;
        while (contr)
        {
            Console.Clear();
            Console.WriteLine("Menú de operaciones matemáticas, elija la operación deseada usando su respectivo signo.");
            Console.WriteLine("+ Suma");
            Console.WriteLine("- Resta");
            Console.WriteLine("* Multiplicación");
            Console.WriteLine("/ División");
            Console.WriteLine("'F' para salir del menú");

            var operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    Console.WriteLine("Suma");

                    Console.WriteLine("Ingrese los numeros a sumar");
                    var nums1 = Convert.ToInt32(Console.ReadLine());
                    var nums2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La suma de los dos números es: " + (nums1 + nums2));

                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "-":
                    Console.WriteLine("Resta");
                    Console.WriteLine("Ingrese los numeros a restar");
                    var numr1 = Convert.ToInt32(Console.ReadLine());
                    var numr2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La resta de los dos números es: " + (numr1 - numr2));

                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "*":
                    Console.WriteLine("Multiplicación");
                    Console.WriteLine("Ingrese los numeros a multiplicar");
                    var numm1 = Convert.ToInt32(Console.ReadLine());
                    var numm2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La multiplicación de los dos números es: " + (numm1 * numm2));

                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "/":
                    Console.WriteLine("División");
                    Console.WriteLine("Ingrese los numeros a dividir");
                    var numd1 = Convert.ToInt32(Console.ReadLine());
                    var numd2 = Convert.ToInt32(Console.ReadLine());
                    if (numd2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("La division de los dos números es: " + (numd1 / numd2));

                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "F":
                    Console.WriteLine("Saliendo del menú");
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();

                    contr = false;
                    break;

                default:
                    Console.WriteLine("Opción no disponible");
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    break;
            }

        }
    }
}