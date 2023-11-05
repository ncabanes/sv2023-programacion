/*
 * 62. Escribe un programa que pida al usuario una frase y muestre las 
 * cifras numéricas que contenga. Por ejemplo, si el usuario introduce 
 * "12 es más que 3 y que 4", el programa escribirá "1234". 
 * Hazlo usando "foreach".
*/

// Felipe (...)

using System;

class Ejercicio62
{
    static void Main()
    {
        string fraseUsuario;

        Console.Write("Escribe una frase: ");
        fraseUsuario = Console.ReadLine();

        foreach (char simbolo in fraseUsuario)
        {
            if (simbolo >='0' && simbolo <='9')
            {
                Console.Write(simbolo);
            }
        }
    }
}
