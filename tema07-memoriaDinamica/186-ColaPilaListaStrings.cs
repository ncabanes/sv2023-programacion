/*
 186. Crea un programa que pida al usuario una frase tras otra, hasta que introduzca una frase vacía.
Todas esas frases se deberán guardar a la vez en una cola de strings, en una 
pila de strings y en una lista de strings. Cuando introduzca la frase vacía que marca el final de
los datos, deberás mostrar primero el contenido de la cola,
luego el de la pila, y luego el resultado de ordenar la lista alfabéticamente.
*/
 
// julio 
 
using System;
using System.Collections.Generic;

class ColaPilaLista
{
    static void Main()
    {
        Queue<string> cola = new Queue<string>();
        Stack<string> pila = new Stack<string>();
        List<string> lista = new List<string>();
        string respuesta;

        do
        {
            Console.Write("Dime una frase: ");
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                cola.Enqueue(respuesta);
                pila.Push(respuesta);
                lista.Add(respuesta);
            }
        }
        while (respuesta != "");

        Console.WriteLine("Cola:");
        int contador = pila.Count;
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(cola.Dequeue());
        }

        Console.WriteLine("Pila:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(pila.Pop());
        }

        Console.WriteLine("Lista:");
        lista.Sort();
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
