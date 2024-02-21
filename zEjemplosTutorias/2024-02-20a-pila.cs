/*
Pide al usuario textos, que guardarás en una pila, hasta que teclee 
Intro sin introducir ningún texto.

En ese momento, extrae todo el contenido de la pila y muéstralo 
(aparecerá en orden inverso). 
*/


using System;
using System.Collections;

class Prueba
{
    static void Main()
    {
        Stack pila = new Stack();
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
            string textoActual = (string) pila.Pop();
            Console.WriteLine(textoActual);
        }
    }
}

// Dime un texto: a
// Dime un texto: b
// Dime un texto: c
// Dime un texto:
// c
// b
// a
