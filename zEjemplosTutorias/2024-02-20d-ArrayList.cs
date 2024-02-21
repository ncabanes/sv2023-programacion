/* Crea una versión alternativa del ejercicio 3, 
 * usando una lista: el usuario introducirá 
 * textos hasta que pulse Intro. Después 
 * deberás mostrarlos dos veces: primero 
 * en orden de introducción y luego en orden 
 * inverso.
*/

using System;
using System.Collections;

class Prueba
{
    static void Main()
    {
        ArrayList lista = new ArrayList();
        string texto;

        do
        {
            Console.Write("Dime un texto: ");
            texto = Console.ReadLine();
            if (texto != "")
                lista.Add(texto);
        }
        while (texto != "");

        // De principio a fin
        /*
        for (int i = 0; i < lista.Count; i++) 
        {
            string textoActual = (string) lista[i];
            Console.WriteLine(textoActual);
        }*/
        foreach(string textoActual in lista)
            Console.WriteLine(textoActual);

        // De fin a principio
        for (int i = lista.Count-1; i >= 0; i--)
        {
            string textoActual = (string)lista[i];
            Console.WriteLine(textoActual);
        }
    }
}

// Dime un texto: a
// Dime un texto: b
// Dime un texto: c
// Dime un texto: d
// Dime un texto:
// a
// b
// c
// d
// d
// c
// b
// a
