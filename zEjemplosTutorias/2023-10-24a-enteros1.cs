using System;

class Enteros1 
{
    static void Main() 
    {
        byte edad;
        ulong poblacionPais;
        
        Console.Write("Dime tu edad: ");
        edad = Convert.ToByte( Console.ReadLine() );
        
        Console.Write("Dime la población del país: ");
        poblacionPais = Convert.ToUInt64( Console.ReadLine() );
    }
}
