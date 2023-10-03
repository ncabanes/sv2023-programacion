// Contador, versión 3: descendente

using System;

class Contar3 
{
    static void Main() 
    {
        int n = 10;
        while (n >= 0)
        {
            Console.Write("{0} ", n);
            n = n - 1;
        }
    }
}

