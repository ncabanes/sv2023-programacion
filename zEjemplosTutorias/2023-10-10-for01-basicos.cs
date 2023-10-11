using System;

class For01
{
    static void Main() 
    {
        int i;
        
        // "for" ascendente
        for(i = 1; i <= 10; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
        // "for" descendente
        for(i = 10; i >= 0; i--)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
        // "for" con paso 10
        for(i = 10; i <= 50; i += 10)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        
        // Declarando la variable "al vuelo"
        for (int n = 5; n <= 8; n++)
        {
            Console.WriteLine(n);
        }
        
        // Errores frecuentes: repetir una orden vacía (el "punto y coma")
        for(i = 1; i <= 10; i++);
        {
            Console.Write("{0} ", i);
        }
    }
}

/*
Resultado de la ejecución:

1 2 3 4 5 6 7 8 9 10
10 9 8 7 6 5 4 3 2 1 0
10 20 30 40 50
5
6
7
8
11
*/
