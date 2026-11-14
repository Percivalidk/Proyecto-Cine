Diseño de la Solución - Control de Asientos de Cine

1. Diseño Modular
   
• iniciarSala(): Llena toda la matriz de 5x6 con la letra "L" al arrancar el programa.
• mostrarSala(): Dibuja en pantalla la matriz con los números de fila y columna para ver qué lugares hay libres u ocupados.
• reservarAsiento(): Pide fila y columna, revisa que exista y que tenga "L", y la cambia por "O".
• liberarAsiento(): Pide fila y columna, revisa que tenga "O" y la regresa a "L".
• consultarAsiento(): Pide fila y columna y muestra en pantalla si ese lugar está libre u ocupado.
• verEstadisticas(): Cuenta cuántos asientos tienen "O", cuántos tienen "L" y calcula el porcentaje de ocupación.

3. Diseño Preliminar de la Interfaz (Pantalla en consola)
Así se verá el menú y la sala cuando el usuario abra el programa:

=== SISTEMA DE ASIENTOS DEL CINE ===
    0  1  2  3  4  5
0   L  L  O  L  L  L
1   L  L  L  L  O  L
2   O  O  L  L  L  L
3   L  L  L  L  L  L
4   L  L  L  L  L  O

1. Mostrar matriz de asientos
2. Reservar asiento
3. Liberar asiento
4. Consultar disponibilidad
5. Ver ocupados, disponibles y porcentaje
6. Salir
Elige una opcion:

3. Algoritmo General
   
1. Inicio del programa.
2. Crear la matriz de 5 filas por 6 columnas y llenarla con "L".
3. Mostrar el menú de 6 opciones al usuario.
4. Leer la opción elegida y ejecutar la función correspondiente.
5. Repetir el menú hasta que el usuario elija la opción 6.
6. Fin del programa.

4. Pseudocódigo Principal

INICIO
  Definir matriz sala de 5 filas por 6 columnas como Caracter
  Llamar iniciarSala()

  Repetir
    Imprimir "1. Mostrar sala"
    Imprimir "2. Reservar asiento"
    Imprimir "3. Liberar asiento"
    Imprimir "4. Consultar asiento"
    Imprimir "5. Ver estadisticas"
    Imprimir "6. Salir"
    Leer opcion

  Segun opcion Hacer
      Caso 1:
        Para i = 0 Hasta 4 Hacer
          Para j = 0 Hasta 5 Hacer
            Imprimir sala en posicion i, j
          FinPara
          Imprimir salto de linea
        FinPara

   Caso 2:
        Imprimir "Ingresa fila (0-4) y columna (0-5):"
        Leer fila, columna
        Si fila >= 0 Y fila < 5 Y columna >= 0 Y columna < 6 Entonces
          Si sala en posicion fila, columna es igual a "L" Entonces
            sala en posicion fila, columna = "O"
            Imprimir "Asiento reservado"
          Sino
            Imprimir "Error: El asiento ya esta ocupado"
          FinSi
        Sino
          Imprimir "Error: Fila o columna no valida"
        FinSi

  Caso 3:
        Imprimir "Ingresa fila (0-4) y columna (0-5):"
        Leer fila, columna
        Si fila >= 0 Y fila < 5 Y columna >= 0 Y columna < 6 Entonces
          Si sala en posicion fila, columna es igual a "O" Entonces
            sala en posicion fila, columna = "L"
            Imprimir "Asiento liberado"
          Sino
            Imprimir "Error: El asiento ya estaba libre"
          FinSi
        Sino
          Imprimir "Error: Fila o columna no valida"
        FinSi

   Caso 4:
        Imprimir "Ingresa fila (0-4) y columna (0-5):"
        Leer fila, columna
        Si fila >= 0 Y fila < 5 Y columna >= 0 Y columna < 6 Entonces
          Si sala en posicion fila, columna es igual a "L" Entonces
            Imprimir "El asiento esta LIBRE"
          Sino
            Imprimir "El asiento esta OCUPADO"
          FinSi
        FinSi

  Caso 5:
        ocupados = 0
        disponibles = 0
        Para i = 0 Hasta 4 Hacer
          Para j = 0 Hasta 5 Hacer
            Si sala en posicion i, j es igual a "O" Entonces
              ocupados = ocupados + 1
            Sino
              disponibles = disponibles + 1
            FinSi
          FinPara
        FinPara
        porcentaje = (ocupados * 100) / 30
        Imprimir "Ocupados: ", ocupados
        Imprimir "Disponibles: ", disponibles
        Imprimir "Porcentaje: ", porcentaje, "%"
    FinSegun
  Hasta Que opcion == 6
FIN
