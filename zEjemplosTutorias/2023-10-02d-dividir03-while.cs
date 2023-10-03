// Dividir dos números (versión 3: while)

using System;

class Dividir03 
{
    static void Main() 
    {
        int a, b;
        
        Console.WriteLine("Dime el primer número");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Dime el segundo número");
        b = Convert.ToInt32( Console.ReadLine() );
        
        while (b == 0)
        {
            Console.WriteLine("Cero no, por favor");
            Console.WriteLine("Dime el segundo número");
            b = Convert.ToInt32( Console.ReadLine() );
        }
        
        Console.WriteLine("Su división es {0}", a/b);
    }
}

