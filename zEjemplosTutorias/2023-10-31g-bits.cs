// Contacto con los operadores a nivel de bit

using System;
using System.Collections.Concurrent;

class SumaBitABit
{
    static void Main()
    {
        string frase = Console.ReadLine();
        foreach (char letra in frase)
        {
            Console.Write( (char) (letra | 32));
        }
    }
}

// HOLA
// hola

