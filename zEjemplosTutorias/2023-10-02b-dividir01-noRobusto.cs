// Dividir dos números (versión 1: no robusto)

using System;

class Dividir01 
{
    static void Main() 
    {
        int a, b;
        
        Console.WriteLine("Dime el primer número");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Dime el segundo número");
        b = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Su división es {0}", a/b);
    }
}

