// Acercamiento a excepciones: programa sin control de errores

using System;

class ExcepcionesAcercamiento
{
    static void Main() 
    {
        Console.WriteLine("Dime el primero");
        int n1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Dime el segundo");
        int n2 = Convert.ToInt32( Console.ReadLine() );
        
        int division = n1 / n2;
        Console.WriteLine("Su división es {0}", division);
    }
}
