/* 109. Crea una función "SumarHasta( n )", que calcule y devuelva la 
suma de los números enteros desde 1 hasta n, calculada de forma 
iterativa (con un bucle "for"). Por ejemplo, para n=4, deberá devolver 
10 (que es el resultado de 1+2+3+4). Crea una variante llamada 
"SumarHastaR( n )" que haga el mismo proceso de forma recursiva. Crea 
un Main de prueba que compruebe si ambas funciones se comportan igual 
para todos los números desde 0 hasta 1000. */

// Eric (...), retoques por Nacho

using System;

class PruebaSumarHasta
{
    public static int SumaIterativa (int n1)
    {
        int suma = 0;
        for (int i = n1; i > 0; i--)
        {
            suma += i;
        }
        return suma;
    }
    
    public static int SumaRecursiva(int n1)
    {
        if (n1 == 0)
        {
            return 0;
        }
        else
        {
            return n1 + SumaRecursiva( n1 - 1 );
        }
    }
    
    static void Main(string[] args)
    {
        int correctos = 0, fallos = 0;
        
        for (int i = 0; i <= 1000; i++)
        {
            if (SumaIterativa(i) == SumaRecursiva(i))
            {
                correctos ++;
                Console.Write(i + " ");
            }
            else
            {
                fallos ++;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Mismo resultado en {0} casos; falla en {1}.",
            correctos, fallos);
    }
}
