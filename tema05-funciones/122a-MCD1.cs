/*122. El máximo común divisor (MCD) de dos números A y B se puede calcular de 
forma recursiva utilizando el algoritmo de Euclides: si B es 0, la respuesta es 
A; De lo contrario, la respuesta será el MCD de B y A%B. Crea dos funciones que 
devuelvan el MCD de dos números enteros largos: uno debe ser iterativo (NO 
recursivo, sino usando "for" o "while"), y debe llamarse "Mcd". La segunda 
función debe hacerlo de forma recursiva, utilizando el algoritmo de Euclides y 
debe llamarse "McdR".

Un ejemplo de uso podría ser:

Console.Write ( McdR( 30, 18) ); // Mostraría 6 */

// Miguel Ángel (..)

using System;

class recursivaMCD
{
    static int Mcd(int A, int B)
    {
        int mayor, mcd = 1;
        if (A > B)
        {
            mayor = A;
        }
        else
        {
            mayor = B;
        }
        for (int i = 2; i <= mayor/2; i ++)
        {
            if ( A % i == 0 && B % i == 0)
            {
                mcd = i;
            }
        }
        return mcd;
    }
    
    static int McdR(int A, int B)
    {   
        int mayor, menor;
        
        if (A > B)
        {
            mayor = A;
            menor = B;
        }
        else
        {
            mayor = B;
            menor = A;
        }
        if (menor == 0)
        {
            return mayor;
        }
        if (mayor % menor == 0)
        {
            return menor;
        }
        return McdR(menor, mayor % menor);
    }
    
    static void Main()
    {
        Console.WriteLine(Mcd(30, 18));
        Console.WriteLine(McdR(30, 18));
    }
}
