/*Crea una versión alternativa del ejercicio anterior, usando Generics:

Pide al usuario textos, que guardarás en una pila de "string", hasta que teclee Intro sin introducir ningún texto.

En ese momento, extrae todo el contenido de la pila y muéstralo (aparecerá en orden inverso).
*/


using System;
using System.Collections.Generic;

class Prueba
{
    static void Main()
    {
        Stack<string> pila = new Stack<string>();
        string texto;

        do
        {
            Console.Write("Dime un texto: ");
            texto = Console.ReadLine();
            if (texto != "")
                pila.Push(texto);
        }
        while (texto != "");

        int cantidad = pila.Count;
        for (int i = 0; i < cantidad; i++) 
        {
            string textoActual = pila.Pop();
            Console.WriteLine(textoActual);
        }
    }
}

// Dime un texto: uno
// Dime un texto: dos
// Dime un texto: tres
// Dime un texto:
// tres
// dos
// uno
