using System;

class Program
{
// sala de cine: matriz de 5 filas x 6 columnas = 30 asientos
    // cada asiento guarda una letra: 'L' = Libre, 'O' = Ocupado

    static char[,] sala = new char[5, 6];

    static void Main()
    {
        // al inicio llenamos toda la sala con 'L' porque nadie ha reservado
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                sala[i, j] = 'L';
            }
        }

        int opcion = 0;

        // el menú se repite hasta que el usuario elija salir (6)
        
while (opcion != 6)
//el menú se repite hasta que el usuario elija salir (6)
        {
            Console.Clear();
            Console.WriteLine(" SISTEMA DE CINE");
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
// muestra la sala con colores
    MostrarSala();
    break;

                    case 2:
// reserva: pide fila y columna
                        Console.Write("fila: ");
                        int fila = int.Parse(Console.ReadLine());
                        Console.Write("columna: ");
                        int columna = int.Parse(Console.ReadLine());

   // revisa que ese asiento si exista

                        if (fila >= 0 && fila < 5 && columna >= 0 && columna < 6)
                        {
 // si esta libre ('L') lo cambia a ocupado ('O')
                            if (sala[fila, columna] == 'L')
                            {
                                sala[fila, columna] = 'O';
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
                   // libera: pide fila y columna
                        Console.Write("fila: ");
                        fila = int.Parse(Console.ReadLine());
                        Console.Write("columna: ");
                        columna = int.Parse(Console.ReadLine());

// revisa que ese asiento pues si exista

                        if (fila >= 0 && fila < 5 && columna >= 0 && columna < 6)
                        {
//si esta ocupado ('O') lo cambia a libre ('L')
                            if (sala[fila, columna] == 'O')
                            {
                                sala[fila, columna] = 'L';
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
// consulta: este solo dice si esta libre u ocupado, no lo cambia
                       Console.Write("fila: ");
                       fila = int.Parse(Console.ReadLine());
                        Console.Write("columna: ");
                        columna = int.Parse(Console.ReadLine());

  // Revisa que ese asiento si exista

                         if (fila >= 0 && fila < 5 && columna >= 0 && columna < 6)
                           {
                               if (sala[fila, columna] == 'L')
                           {
                           Console.WriteLine("El asiento [" + fila + "," + columna + "] esta LIBRE");
                           }
                      else
                           {
                            Console.WriteLine("El asiento [" + fila + "," + columna + "] esta OCUPADO");
                           }
                           }
                      else
                          {
                           Console.WriteLine("no existe ese asiento");
                          }
                            break;

                    
                        case 5:
// estadística : cuenta cuantos estan ocupados
                          int ocupados = 0;
// recorre toda la matriz para contar los que tienen 'O'

                           for (int i = 0; i < 5; i++)
                         {
                           for (int j = 0; j < 6; j++)
                         {
                        if (sala[i, j] == 'O')
                         {
                           ocupados++;
                         }
                      }
                   }
//Los libres son el total (30) menos los ocupados

                    int libres = 30 - ocupados;
                     Console.WriteLine("ocupados: " + ocupados);
                    Console.WriteLine("libres: " + libres);
// porcentaje% = ocupados * 100 / total
                    Console.WriteLine("porcentaje: " + ((ocupados * 100.0) / 30) + "%");
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
// si se escribe una letra en vez de numero, no se cierra el programa
                
                Console.WriteLine("error, escribe solo numeros");
                opcion = 0;
            }
  // pausa para leer el mensaje antes de limpiar la pantalla

            if (opcion != 6)
            {
                Console.WriteLine("enter para seguir");
                Console.ReadLine();
            }
        }
    }
// dibuja la sala, verde = libre, rojo = ocupado

    static void MostrarSala()
    {
        Console.WriteLine();
        Console.WriteLine("  === PANTALLA ===");
        Console.WriteLine("   0  1  2  3  4  5");
  // recorre fila x fila
        for (int i = 0; i < 5; i++)
        {
// recorre columna por columna
            Console.Write(i + " ");
            for (int j = 0; j < 6; j++)
            {
// cambia el color segun el estado del asiento
                if (sala[i, j] == 'L')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("[" + sala[i, j] + "]");

// regresa al color normal para no pintar todo
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
