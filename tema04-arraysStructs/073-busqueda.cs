/*73. Pide al usuario 10 enteros cortos sin signo y guárdalos en un array. Luego pide uno más y dile 
si estaba entre esos 10 datos iniciales, de 2 formas distintas: primero usando un booleano y luego 
usando un contador, para, en la segunda ocasión, responderle cuántas veces aparecía (ambas respuestas 
serán parte del mismo programa, no dos programas independientes).

Javier (...), retoques menores por Nacho*/

using System;

class Ejercicio073
{
    static void Main()
    {
        const int CANTIDAD = 10;
        ushort[] numeros = new ushort[CANTIDAD];
        ushort valor;
        byte contador;
        bool encontrado;

        // Petición de datos
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Introduce número {0}: ", i + 1);
            numeros[i] = Convert.ToByte(Console.ReadLine());

        }
        
        Console.Write("Introduce el valor a buscar: ");
        valor = Convert.ToByte(Console.ReadLine());

        // Búsqueda usando una variable booleana
        encontrado = false;
        for (int i = 0;i < numeros.Length; i++)
        {
            if (valor == numeros[i])
            {
                encontrado = true;
            }
        }
        if (encontrado)
        {
            Console.WriteLine("Encontrado!");
        }
        else
        {
            Console.WriteLine("No encontrado");
        }
        
        // Búsqueda usando un contador
        contador=0;
        for (int i = 0;i < numeros.Length; i++)
        {
            if (valor == numeros[i])
            {
                contador++;
            }
        }
        if (contador > 0)
        {
            Console.WriteLine("Encontrado {0} veces!", contador);
        }
        else
        {
            Console.WriteLine("No encontrado");
        }
    }
}
