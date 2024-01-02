/*

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

Entrada de ejemplo
8
2
4
6
5
7
3
26073
59794

Salida de ejemplo
Case #1: 1
Case #2: 1
Case #3: 2
Case #4: 2
Case #5: 3
Case #6: 1
Case #7: 13036
Case #8: 29896
*/ 

using System;

class NumeroPersonasMesa 
{
    static void Main () 
    {

        int casos, dato, mesas=0;

        casos = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= casos; i++) 
        {

            dato = Convert.ToInt32(Console.ReadLine());

            if (dato == 0) 
            {
                mesas = 0;
            } 
            else if (dato <= 4) 
            {
                mesas = 1;                
            } 
            else if (dato % 2 == 0) 
            {
                mesas = (dato - 2) / 2;
            } 
            else if (dato % 2 != 0) 
            {
                mesas = (dato - 1) / 2;
            }

            Console.WriteLine("Case #{0}: {1}", i, mesas);

        }
    }
}

