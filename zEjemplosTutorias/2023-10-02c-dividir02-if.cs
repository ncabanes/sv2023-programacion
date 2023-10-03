// Dividir dos números (versión 2: poco robusto, "if")

using System;

class Dividir02 
{
    static void Main() 
    {
        int a, b;
        
        Console.WriteLine("Dime el primer número");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Dime el segundo número");
        b = Convert.ToInt32( Console.ReadLine() );
        
        if (b == 0)
        {
            Console.WriteLine("Cero no, por favor");
            Console.WriteLine("Dime el segundo número");
            b = Convert.ToInt32( Console.ReadLine() );
        }
        
        Console.WriteLine("Su división es {0}", a/b);
    }
}

