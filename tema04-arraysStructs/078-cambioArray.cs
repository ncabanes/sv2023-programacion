/* 78. Crea un variante mejorada del programa que devuelve el cambio de una 
compra, utilizando siempre en primer lugar monedas (o billetes) del valor más 
grande posible. Supondremos que tenemos una cantidad ilimitada de monedas (o 
billetes) de 100, 50, 10, 5 y 1, y que no hay decimales. La ejecución podría 
ser algo como:

Precio? 222 
Pagado? 500 
Tu cambio es 378: 100 100 100 50 10 10 5 1 1 1 

En este caso, las monedas (o billetes) disponibles estarán prefijados en un 
array, para que resulte menos repetitivo.*/

// Miguel Ángel (...)

using System;

class CambioArray
{
    static void Main()
    {
        int[] cambioDisponible = {100, 50, 10, 5, 1};
        int precio, pagado, cambio;
                
        Console.Write("¿Cual es el precio? ");
        precio = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Cuánto has pagado? ");
        pagado = Convert.ToInt32(Console.ReadLine());
        
        cambio = pagado - precio;
        Console.Write("Tu cambio es {0}: ", cambio);
        for (int i = 0; i < cambioDisponible.Length; i++)
        {
            while (cambio >= cambioDisponible[i])        
            {
                Console.Write(cambioDisponible[i] + " ");
                cambio -= cambioDisponible[i];
            }
        }
    }
}
