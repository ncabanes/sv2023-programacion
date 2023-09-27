// Pido número, miro si es mayor o igual que 3 (3: faltan llaves)

using System;

class MayorOIgualQue3c
{
    static void Main() 
    {
        int n;
        
        Console.WriteLine("Dime el número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n >= 3)  // Posible error (incluso si no hubiera "else"
            Console.WriteLine("Es mayor o igual que 3");
            Console.WriteLine("También puedes usar negativos");
        else
            Console.WriteLine("Es menor que 3");
    }
}

