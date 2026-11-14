 Análisis del Problema - Control de Asientos de Cine
1. Identificación del problema
En el cine actualmente apuntan los asientos reservados de forma manual, lo que provoca errores como vender el mismo lugar dos veces o no saber cuántos boletos quedan disponibles. El objetivo es hacer un programa sencillo para llevar el control de la sala sin equivocaciones.

2. Justificación de la estructura de datos
Vamos a usar una matriz porque una sala de cine está acomodada así, cada cuadrito de la matriz representa un asiento y podemos buscarlo rápido poniendo su número de fila y su número de columna. Usaremos la letra "L" para indicar que está Libre y la letra "O" para indicar que está Ocupado.

3. Alcance y limitaciones
 Alcance: El sistema controla una sala de cine de 5 filas por 6 columnas esto permite ver el mapa de la sala, apartar asientos, cancelarlos, revisar si un lugar está libre y ver cuántos asientos están ocupados y su porcentaje.

Limitaciones: Los datos solo se guardan mientras el programa está abierto; si se cierra la ventana, todos los asientos vuelven a quedar libres. Solo maneja una sala a la vez

 5. Entradas, procesos y salidas
Entradas:
  • El número de la opción que el usuario elige en el menú.
  • El número de fila y el número de columna del asiento.
procesos:
  • Revisar que la fila y la columna existan dentro de la sala.
  • Checar si el asiento tiene una "L"o una "O" antes de reservarlo o liberarlo.
  • Revisar toda la tabla asiento por asiento para contar cuántos están ocupados y cuántos libres
Salidas:
  • El dibujo de la matriz con todos los asientos.
  • Avisos de confirmación o mensajes de error 
  • El total de asientos libres, ocupados y el porcentaje de qué tan llena está la sala.

6. Descripción de requerimientos
1. Mostrar matriz: Dibujar en pantalla las filas y columnas de la sala para ver qué lugares están libres "L" y cuáles ocupados "O"
2. Reservar asiento: Pedir fila y columna, y si el lugar está libre, cambiarlo a ocupado.
3. Liberar asiento: Pedir fila y columna para cancelar un lugar ocupado y volverlo a poner libre.
4. Consultar disponibilidad: Pedir fila y columna para decirle al usuario si ese asiento está libre u ocupado.
5. Contar ocupados y disponibles: Contar toda la sala y mostrar cuántos lugares hay ocupados y cuántos vacíos.
6. Porcentaje de ocupación: Calcular y mostrar qué porcentaje de la sala está ocupada.

6. Casos de uso
Caso 1 - Apartar un asiento: El usuario elige reservar, escribe fila 1 y columna 2. El sistema ve que tiene una "L", la cambia a "O" y avisa que quedó reservado.
Caso 2 - Asiento ya ocupado: El usuario intenta apartar la fila 1 y columna 2 que ya tiene una "O" y el sistema no lo deja y le avisa que ese lugar ya está ocupado.
Caso 3 - Cancelar un asiento: Un cliente cancela su boleto, el usuario elige liberar, pone fila 1 y columna 2, y el sistema cambia la "O" por una "L".
Caso 4 - Ver estadísticas: El usuario pide ver el resumen de la sala, el sistema cuenta todos los lugares y le muestra cuántos están ocupados y cuantos libres.
