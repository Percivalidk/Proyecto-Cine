using System;

class Program
{
    static char[,] sala = new char[5, 6];

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                sala[i, j] = 'L';
            }
        }

        int opcion = 0;

        while (opcion != 6)
        {
            Console.Clear();
            Console.WriteLine("CINE");
            Console.WriteLine("1. ver sala");
            Console.WriteLine("2. reservar");
            Console.WriteLine("3. liberar");
            Console.WriteLine("4. consultar");
            Console.WriteLine("5. estadisticas");
            Console.WriteLine("6. salir");

            try
            {
                Console.Write("opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("  === PANTALLA ===");
                        Console.WriteLine("   0  1  2  3  4  5");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(i + " ");
                            for (int j = 0; j < 6; j++)
                            {
                                if (sala[i, j] == 'L')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("[L]");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("[O]");
                                }
                                Console.ResetColor();
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.Write("fila: ");
                        int f = int.Parse(Console.ReadLine());
                        Console.Write("columna: ");
                        int c = int.Parse(Console.ReadLine());

                        if (f >= 0 && f < 5 && c >= 0 && c < 6)
                        {
                            if (sala[f, c] == 'L')
                            {
                                sala[f, c] = 'O';
                                Console.WriteLine("asiento reservado");
                            }
                            else
                            {
                                Console.WriteLine("ya esta ocupado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("no existe ese asiento");
                        }
                        break;

                    case 3:
                        Console.Write("fila: ");
                        f = int.Parse(Console.ReadLine());
                        Console.Write("columna: ");
                        c = int.Parse(Console.ReadLine());

                        if (f >= 0 && f < 5 && c >= 0 && c < 6)
                        {
                            if (sala[f, c] == 'O')
                            {
                                sala[f, c] = 'L';
                                Console.WriteLine("asiento liberado");
                            }
                            else
                            {
                                Console.WriteLine("ya estaba libre");
                            }
                        }
                        else
                        {
                            Console.WriteLine("no existe ese asiento");
                        }
                        break;

                    case 4:
                        Console.Write("fila: ");
                        f = int.Parse(Console.ReadLine());
                        Console.Write("columna: ");
                        c = int.Parse(Console.ReadLine());

                        if (f >= 0 && f < 5 && c >= 0 && c < 6)
                        {
                            if (sala[f, c] == 'L')
                            {
                                Console.WriteLine("esta libre");
                            }
                            else
                            {
                                Console.WriteLine("esta ocupado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("no existe ese asiento");
                        }
                        break;

                    case 5:
                        int ocupados = 0;
                        int libres = 0;

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (sala[i, j] == 'O')
                                {
                                    ocupados++;
                                }
                                else
                                {
                                    libres++;
                                }
                            }
                        }

                        double porcentaje = (ocupados * 100.0) / 30;
                        Console.WriteLine("ocupados: " + ocupados);
                        Console.WriteLine("libres: " + libres);
                        Console.WriteLine("porcentaje: " + porcentaje + "%");
                        break;

                    case 6:
                        Console.WriteLine("adios");
                        break;

                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("error, escribe solo numeros");
                opcion = 0;
            }

            if (opcion != 6)
            {
                Console.WriteLine("enter para seguir");
                Console.ReadLine();
            }
        }
    }
}
