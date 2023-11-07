using System;

// Pide al usuario 5 números reales de doble precisión. 
// Después muéstralos en orden inverso de dos formas: 
// - Usando una constante para el tamaño.
// - Empleando ".Length"

class Arrays03 
{
    static void Main() 
    {
        const int CAPACIDAD = 5;
        double[] datos = new double[CAPACIDAD];
        
        // -- Con constante
        
        for (int i = 0; i < CAPACIDAD; i++)
        {
            Console.Write("Dime el dato "+ (i+1) + ": ");
            datos[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        for (int i = CAPACIDAD-1; i >= 0; i--)
        {
            Console.WriteLine( datos[i] );
        }
        
        // -- Con .Length
        
        for (int i = 0; i < datos.Length; i++)
        {
            Console.Write("Dime el dato "+ (i+1) + ": ");
            datos[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        for (int i = datos.Length-1; i >= 0; i--)
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
