// Mario (...), retoques menores por Nacho

/*
58. El número "e" (2.718281828...) se puede escribir como 

e = 1 + 1/1 + 1/(1·2) + 1/(1·2·3) + ...

Crea un programa que pregunte al usuario cuántos sumandos desea y le muestre el 
valor de la aproximación de "e" hasta esa cantidad de sumandos, por ejemplo: 

Sumandos? 3
e vale aproximadamente 2,5

*/

using System;

class valorE
{
    static void Main()
    {
        long pasos;
        double e = 1, divisor = 1;
        
        Console.Write("Sumandos? ");
        pasos = Convert.ToInt64(Console.ReadLine());
        
        for (long i = 2; i <= pasos; i++)
        {
            divisor = divisor * (i-1);
            e = e + 1/divisor;
        }
        
        Console.Write("e vale aproximadamente {0}", e);
    }
}
