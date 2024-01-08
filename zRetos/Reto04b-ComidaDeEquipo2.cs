/*
Comida de equipo
¡Hoy es nuestra comida de equipo quincenal! Esta vez, vamos a nuestro
restaurante indio favorito y queremos saber de antemano el número mínimo de
mesas necesarias para acomodar a todos los miembros del equipo.

Todas las mesas tienen forma cuadrada, siempre deben estar unidas en una fila y
no puede haber más de un comensal sentado a cada lado de la mesa.

Ejemplo para 4 comensales:

     O
   +---+
 O | 1 | O
   +---+
     O


4 comensales -> 1 mesa

Ejemplo para 5 comensales:

     O   O
   +---+---+
 O | 1 | 2 |
   +---+---+
     O   O


5 comensales -> 2 mesas



Entrada
En la primera línea, un entero T indica el número de casos. Cada caso se
describe en una línea con un entero N que indica el número de comensales.



Salida
Para cada caso t, la salida es la cadena "Case #t: r" donde t es el número de
caso y r es el resultado.

Límites
1 <= T <= 50
0 <= N <= 2^16

Entrada de ejemplo
4
4
6
5
3

Salida de ejemplo
Case #1: 1
Case #2: 2
Case #3: 2
Case #4: 1
*/

// Mario (...), retoques por Nacho

using System;

class Reto04ComidaDeEquipo
{
    static int NumeroMesas(int n)
    {
        if (n > 0 && n <= 4)
            return 1;

        if (n > 4)
        {
            return (1 + NumeroMesas(n - 2));
        }

        return 0;
    }
    static void Main()
    {
        byte t = Convert.ToByte(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int mesas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Case #"+(i+1)+": "+NumeroMesas(mesas));
        }
    }
}
