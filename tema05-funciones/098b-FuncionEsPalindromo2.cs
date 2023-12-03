/* 98. Crea una función booleana llamada "EsPalindromo", que devolverá "true"
 * si el parámetro, un texto, es una palabra palíndroma (que se lee igual de
 * izquierda a derecha que de derecha a izquierda), o "false" en caso contrario.
 * Pide al usuario un texto en "Main" y responde si es palíndromo.
 *
 * VICTOR (...) - 1º DAM SEMI */

using System;

class Exercise_05_01_98
{
    static bool EsPalindromo(string texto)
    {
        bool palindromo = false;
        int contadorLetras = 1, contadorCoincidencias = 0;

        for (int i = 0 ; i < (texto.Length/2) ; i++)
        {
            if (texto[i] == texto[texto.Length-contadorLetras])
            {
                contadorCoincidencias++;
            }
            contadorLetras++;
        }
        
        if (contadorCoincidencias == texto.Length/2)
        {
            palindromo = true;
        }

        return palindromo;
    }

    static void Main()
    {
        Console.Write("Introduzca una palabra: ");
        string texto = Console.ReadLine();
        if (EsPalindromo(texto) == true)
        {
            Console.WriteLine("Sí es palíndroma");
        }
        else
        {
            Console.WriteLine("No es palíndroma");
        }
    }
}
