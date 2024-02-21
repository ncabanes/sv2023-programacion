/* Crea una versión alternativa del ejercicio 2, usando una cola (los 
datos aparecerán en el mismo orden en que se introdujeron). */

using System;
using System.Collections.Generic;

class Prueba
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        string texto;

        do
        {
            Console.Write("Dime un texto: ");
            texto = Console.ReadLine();
            if (texto != "")
                cola.Enqueue(texto);
        }
        while (texto != "");

        int cantidad = cola.Count;
        for (int i = 0; i < cantidad; i++) 
        {
            string textoActual = cola.Dequeue();
            Console.WriteLine(textoActual);
        }
    }
}

// Dime un texto: uno
// Dime un texto: dos
// Dime un texto: tres
// Dime un texto:
// uno
// dos
// tres
