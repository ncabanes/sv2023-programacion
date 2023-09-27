// Pido número, miro si es mayor o igual que 3 (V2: else)

using System;

class MayorOIgualQue3b
{
    static void Main() 
    {
        int n;
        
        Console.WriteLine("Dime el número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n >= 3)
            Console.WriteLine("Es mayor o igual que 3");
        else
            Console.WriteLine("Es menor que 3");
    }
}

