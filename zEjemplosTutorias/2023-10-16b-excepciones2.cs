// Excepciones 1: comprobación de un bloque

using System;

class Excepciones1
{
    static void Main() 
    {
        
        try
        {
            Console.WriteLine("Dime el primero");
            int n1 = Convert.ToInt32( Console.ReadLine() );
        }
        catch (Exception)
        {
            Console.WriteLine("No es un número válido");
        }
        
        Console.WriteLine("Dime el segundo");
        int n2 = Convert.ToInt32( Console.ReadLine() );
        
        //int division = n1 / n2;
        //Console.WriteLine("Su división es {0}", division);
    }
}
