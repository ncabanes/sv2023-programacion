// Excepciones 2: comprobación de todo el programa (varias excepc.)

using System;

class Excepciones2
{
    static void Main() 
    {
        
        try
        {
            Console.WriteLine("Dime el primero");
            int n1 = Convert.ToInt32( Console.ReadLine() );
        
            Console.WriteLine("Dime el segundo");
            int n2 = Convert.ToInt32( Console.ReadLine() );
        
            int division = n1 / n2;
            Console.WriteLine("Su división es {0}", division);
        }
        catch (FormatException)
        {
            Console.WriteLine("No es un número válido");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No puedo dividir entre 0");
        }
        catch (Exception)
        {
            Console.WriteLine("Caramba!");
        }
        
        Console.WriteLine("Hasta otra!");
    }
}
