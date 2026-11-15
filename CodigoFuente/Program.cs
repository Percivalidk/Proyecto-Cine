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
            Console.WriteLine("   0 1 2 3 4 5");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + "  ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(sala[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("1. verr sala");
            Console.WriteLine("2. reservar");
            Console.WriteLine("3. liberar");
            Console.WriteLine("4. consultar");
            Console.WriteLine("5. estadisticas");
            Console.WriteLine("6. salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("mostrando sala");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("falta programar reservar");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("falta programar liberar");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("falta programar consultar");
            }
            else if (opcion == 5)
            {
                Console.WriteLine("falta programar estadisticas");
            }
            else if (opcion == 6)
            {
                Console.WriteLine("adios");
            }
            else
            {
                Console.WriteLine("Opcion incorrecta");
            }

            if (opcion != 6)
            {
                Console.WriteLine("Presiona Enter para seguir");
                Console.ReadLine();
            }
        }
    }
}
