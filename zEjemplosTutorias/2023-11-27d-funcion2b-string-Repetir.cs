// Crea una función "EscribirVariasVeces", 
// reciba como parámetros un número y un texto, 
// y escriba varias veces en la misma línea ese texto 
// (tantas veces como indique el número).

// Variante: devuelve la cadena múltiple

using System;

class EjemploFuncion2b
{
    static string RepetirVariasVeces(int n, string texto) 
    {
        string respuesta = "";
        
        for (int i = 0; i < n; i++)
        {
            respuesta += texto;
        }
        return respuesta;
    }
    
    static void Main() 
    {
        Console.WriteLine("Empezamos..." );
        string saludo = RepetirVariasVeces(5,"Hola").ToUpper();
        Console.WriteLine( RepetirVariasVeces(3," :-) ") );
        Console.WriteLine(" Adios");
    }
}

// Empezamos...
// HolaHolaHolaHolaHola :-)  :-)  :-)  Adios


