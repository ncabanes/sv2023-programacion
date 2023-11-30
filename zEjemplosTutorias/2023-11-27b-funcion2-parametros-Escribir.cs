// Crea una función "EscribirVariasVeces", 
// reciba como parámetros un número y un texto, 
// y escriba varias veces en la misma línea ese texto 
// (tantas veces como indique el número).

using System;

class EjemploFuncion2
{
    static void EscribirVariasVeces(int n, string texto) 
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(texto);
        }
    }
    
    static void Main() 
    {
        Console.WriteLine("Empezamos..." );
        EscribirVariasVeces(5,"Hola");
        EscribirVariasVeces(3," :-) ");
        Console.WriteLine(" Adios");
    }
}

// Empezamos...
// HolaHolaHolaHolaHola :-)  :-)  :-)  Adios


