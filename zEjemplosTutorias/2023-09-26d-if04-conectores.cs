// Pido número, miro si es mayor o igual que 3 (v4: tres formas)

using System;

class MayorOIgualQue3d
{
    static void Main() 
    {
        int n;
        
        Console.WriteLine("Dime el número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n >= 3)  // Habitual
        {
            Console.WriteLine("Es mayor o igual que 3");
        }
        
        if ((n > 3) || (n == 3))   // Alternativa con "o"
        {
            Console.WriteLine("Es mayor o igual que 3");
        }
        
        if ( ! ( n < 3 ))   // Alternativa con "no" y caso contrario
        {
            Console.WriteLine("Es mayor o igual que 3");
        }
        
    }
}

