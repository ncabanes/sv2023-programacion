// Dividir dos números (versión 4: do-while)

using System;

class Dividir04 
{
    static void Main() 
    {
        int a, b;
        
        Console.WriteLine("Dime el primer número");
        a = Convert.ToInt32( Console.ReadLine() );
 
        do
        {
            Console.WriteLine("Dime el segundo número");
            b = Convert.ToInt32( Console.ReadLine() );

            if (b == 0)
                Console.WriteLine("Cero no, por favor");
        }      
        while (b == 0);
        
        Console.WriteLine("Su división es {0}", a/b);
    }
}

