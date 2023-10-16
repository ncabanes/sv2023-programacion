/*
Pide dos números enteros al usuario y responde cuántos numeros hay 
entre ellos (ambos inclusive) que sean a la vez pares y múltiplos de 3, 
así:

Número inicial? 11
Número final? 21
Números pares y a la vez múltiplos de 3 encontrados: 2

Nota: el programa debe comportarse correctamente si el primer número es 
menor que el segundo. No funcionará si el segundo es menor que el 
primero, pero no es importante todavía.

*/

// Eric (...), retoques por Nacho

using System;

class Ejercicio33
{
    static void Main()
    {
        int n1, n2;
        int cantidad = 0;
        
        Console.Write("Número inicial? ");
        n1= Convert.ToInt32(Console.ReadLine());
        Console.Write("Número final? ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        for (int i = n1; i < n2; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                cantidad++;
            }
        }
        Console.WriteLine("Números pares y múltiplos de 3 encontrados: {0}", 
            cantidad);   
    }
}
