/* 122. El máximo común divisor (MCD) de dos números A y B se puede calcular de
 * forma recursiva utilizando el algoritmo de Euclides: si B es 0, la respuesta
 * es A; De lo contrario, la respuesta será el MCD de B y A%B. Crea dos funciones
 * que devuelvan el MCD de dos números enteros largos: uno debe ser iterativo
 * (NO recursivo, sino usando "for" o "while"), y debe llamarse "Mcd". La segunda
 * función debe hacerlo de forma recursiva, utilizando el algoritmo de Euclides
 * y debe llamarse "McdR".
 *
 * Un ejemplo de uso podría ser:
 * Console.Write ( McdR( 30, 18) ); // Mostraría 6
 *
 */

// Eric (...)

using System;

class Ejercicio122
{
    static void Main()
    {
        Console.WriteLine(Mcd(30, 18));
        Console.WriteLine(McdR(30, 18));
    }
    
    static long McdR(long n1, long n2)
    {
        long temp = n2;
        n2 = n1 % n2;
        n1 = temp;
        
        if(n2 != 0) { return McdR(n1, n2); }

        return n1;
    }
    
    static long Mcd(long n1, long n2)
    {       
        while (n2 != 0)
        {
            long temp = n2;
            n2 = n1 % n2;
            n1 = temp;
        }
        
        return n1;
    }
}
