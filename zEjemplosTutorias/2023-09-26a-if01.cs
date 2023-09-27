// Pido número, miro si es mayor o igual que 3

using System;

class MayorOIgualQue3 
{
    static void Main() 
    {
        int n;
        
        Console.WriteLine("Dime el número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n >= 3)
        {
            Console.WriteLine("Es mayor o igual que 3");
        }
    }
}

