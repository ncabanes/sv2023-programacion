using System;

// Pide al usuario 5 números reales de doble precisión. 
// Después muéstralos en orden inverso.

class Arrays01
{
    static void Main() 
    {
        double[] datos = new double[5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dime el dato "+ (i+1) + ": ");
            datos[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine( datos[i] );
        }
    }
}

/*
Dime el dato 1: 10
Dime el dato 2: 20
Dime el dato 3: 30
Dime el dato 4: 40
Dime el dato 5: 50
50
40
30
20
10
*/
