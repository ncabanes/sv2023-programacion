/* 70. Crea un programa en C# que pida al usuario una cadena y la muestre
 * encriptada de dos maneras diferentes: primero sumando 1 a cada carácter,
 * luego con la operación XOR 1.
 *
 * VÍCTOR (...) - 1º DAM SEMI*/

using System;

class Ejercicio_03_02_70
{
    static void Main()
    {
        string frase;

        Console.WriteLine("Introduzca una frase: ");
        frase = Console.ReadLine();

        foreach (char letra in frase)
        {
            Console.Write((char)(letra + 1));
        }

        Console.WriteLine();

        foreach (char letra in frase)
        {
            Console.Write((char)(letra ^ 1));
        }
    }
}
