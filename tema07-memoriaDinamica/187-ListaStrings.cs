/* 187. Crea una variante del ejercicio anterior (186), en la que los datos se 
guarden s�lo en la lista de strings. Cuando termine de guardar datos, deber�s 
mostrar los datos primero en orden de introducci�n, luego en orden inverso y 
despu�s ordenados alfab�ticamente, pero todo ello lo har�s recorriendo esa 
(�nica) lista. */

// julio 
 
using System;
using System.Collections.Generic;

class MyClass
{
    static void Main()
    {

        List<string> lista = new List<string>();
        string respuesta;

        do
        {
            Console.Write("Dime una frase: ");
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                lista.Add(respuesta);
            }
        }
        while (respuesta != "");

        Console.WriteLine("orden directo:");
        foreach (string i in lista)
            Console.WriteLine(i);

        Console.WriteLine("orden inverso:");
        for (int i = lista.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(lista[i]);
        }

        Console.WriteLine("ordenados:");
        lista.Sort();
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
