using System;

class Enteros2 
{
    static void Main() 
    {
        byte edad;
        byte edadEn2Anyos;
        ulong poblacionPais;
        
        Console.Write("Dime tu edad: ");
        edad = Convert.ToByte( Console.ReadLine() );
        
        edadEn2Anyos = edad + 2; // Error: quizá no quepa en un byte
        // Alternativa: edad += 2; (pero pude desbordar)
        Console.WriteLine("En 2 años tendrás {0}", edadEn2Anyos );
        
        Console.Write("Dime la población del país: ");
        poblacionPais = Convert.ToUInt64( Console.ReadLine() );
    }
}
