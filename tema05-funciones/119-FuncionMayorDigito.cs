/*119. Crea una función "ObtenerMayorDigito", que devuelva la cifra más alto 
que aparece en un número entero largo que recibirá como parámetro. Crea una 
versión recursiva ("ObtenerMayorDigitoR") y otra iterativa 
("ObtenerMayorDigito"), como parte de un mismo programa, y comprueba que se 
comportan igual. Ejemplos de su uso:

Console.Write(ObtenerMayorDigito(32)); // Debería mostrar 3
if ( ObtenerMayorDigito(276) != 7 )
    Console.WriteLine("Algo no va bien!");*/
    
// Miguel Ángel (...)

using System;

class funcMayorDigito
{
    static byte ObtenerMayorDigito(long numero)
    {
        byte mayorDigito = 0;
        
        while (numero != 0)
        {
            if (numero % 10 > mayorDigito)
            {
                mayorDigito = (byte) (numero % 10);
            }
            numero /= 10;
        }
        return mayorDigito;
    }
    
    static byte ObtenerMayorDigitoR(long numero)
    {
        byte ultimoDigito;
        
        if (numero < 10)
        {   
            ultimoDigito = (byte) numero;
            return ultimoDigito;
        }
        
        ultimoDigito = (byte) (numero % 10);
        if (ultimoDigito < ObtenerMayorDigitoR(numero /10))
        {
            return ObtenerMayorDigitoR(numero / 10);
        }
        return ultimoDigito;
    }
    
    static void Main()
    {
        Console.Write(ObtenerMayorDigito(32)); // Debería mostrar 3
        if ( ObtenerMayorDigito(276) != 7 )
            Console.WriteLine("Algo no va bien!");
        
        Console.Write(ObtenerMayorDigitoR(32)); // Debería mostrar 3
        if ( ObtenerMayorDigitoR(276) != 7 )
            Console.WriteLine("Algo no va bien!");
    }
}
