/* Crea una función recursiva "SumaDePares", que reciba como parámetro 
un número entero y devuelva la suma de los números desde ese número 
hasta 0 (decreciendo) que sean pares.
*/

using System;

class Recursividad1SumaPares 
{
    static int SumaDeParesIterativa(int n)
    {
        int suma = 0;
        for (int i = n; i >= 0; i--)
        {
            if (i % 2 == 0)
                suma += i;
        }
        return suma;
    }
    
    
    static int SumaDePares(int n)
    {
        // Caso base
        if (n <= 0)
            return 0;
            
        // Caso general
        if (n % 2 == 0)  // Par
            return n + SumaDePares(n-2);
        else  // Impar
            return SumaDePares(n-1);
    }
    
    
    static void Main() 
    {
        Console.WriteLine(SumaDeParesIterativa(20));
        Console.WriteLine(SumaDePares(20));
    }
}

// 110
// 110

