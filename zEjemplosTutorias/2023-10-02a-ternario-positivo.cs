// Ejemplo de operador ternario: ver si un número es positivo
using System;

class Ternario 
{
    static void Main() 
    {
        int x;
        int positivo;
        
        x = -5;
        if (x > 0)
            positivo = 1;
        else
            positivo = 0;
        Console.WriteLine("Positivo: {0}", positivo);
            
        positivo = x > 0 ? 1 : 0;
        Console.WriteLine("Positivo: {0}", positivo);
    }
}

