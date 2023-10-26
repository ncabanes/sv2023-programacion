using System;

class Reales1 
{
    static void Main() 
    {
        float n;
        // float pi = 3.14f;
        // float pi = (float) 3.14151926535;
        // int piSinDecimales = (int) pi;
        
        Console.Write("Dime un número: ");
        n = Convert.ToSingle( Console.ReadLine() );
        
        Console.WriteLine("Su cuadrado es {0}", n*n );
    }
}

/*
Dime un número: 3,5
Su cuadrado es 12,25

Dime un número: 4.2
Su cuadrado es 1764   <---- Fallará si se usa "." en consola
*/
