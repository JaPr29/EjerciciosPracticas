class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elección: 1. Do While - 2. While");
        var whil = Console.ReadLine();
        switch (whil)
        {
            case "1":
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menú de Opciones");
                    Console.WriteLine("Elija una opción: ");
                    Console.WriteLine("1. Opción 1");
                    Console.WriteLine("2. Opción 2");
                    Console.WriteLine("3. Salir");

                    var op = Console.ReadLine();

                    if (op != "1" && op != "2" && op != "3")
                    {
                        Console.WriteLine("Opción no disponible, volviendo al menú...");
                        Thread.Sleep(2000);
                        continue;
                    }

                    Console.WriteLine("¿Está seguro? S/N");

                    var decision = Console.ReadLine();

                    if (decision == "S" || decision == "s")
                    {
                        switch (op)
                        {
                            case "1":
                                Console.WriteLine("Opción 1 elegida");
                                break;
                            case "2":
                                Console.WriteLine("Opción 2 elegida");
                                break;
                            case "3":
                                Console.WriteLine("Saliendo del menú...");
                                Thread.Sleep(2000);
                                return;
                        }
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                    }
                    else if (decision == "N" || decision == "n")
                    {
                        Console.WriteLine("Volviendo al menú...");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Opción no disponible, volviendo al menú...");
                        Thread.Sleep(3000);
                    }



                } while (true);
            case "2":
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Menú de Opciones");
                    Console.WriteLine("Elija una opción: ");
                    Console.WriteLine("1. Opción 1");
                    Console.WriteLine("2. Opción 2");
                    Console.WriteLine("3. Salir");

                    var op = Console.ReadLine();

                    if (op != "1" && op != "2" && op != "3")
                    {
                        Console.WriteLine("Opción no disponible, volviendo al menú...");
                        Thread.Sleep(2000);
                        continue;
                    }

                    Console.WriteLine("¿Está seguro? S/N");

                    var decision = Console.ReadLine();

                    if (decision == "S" || decision == "s")
                    {
                        switch (op)
                        {
                            case "1":
                                Console.WriteLine("Opción 1 elegida");
                                break;
                            case "2":
                                Console.WriteLine("Opción 2 elegida");
                                break;
                            case "3":
                                Console.WriteLine("Saliendo del menú...");
                                Thread.Sleep(2000);
                                return;
                        }
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                    }
                    else if (decision == "N" || decision == "n")
                    {
                        Console.WriteLine("Volviendo al menú...");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Opción no disponible, volviendo al menú...");
                        Thread.Sleep(3000);
                    }



                };

            default:
                Console.WriteLine("Opción no disponible, Volviendo al menú principal...");
                Thread.Sleep(2000);
                break;
        }

    }
}