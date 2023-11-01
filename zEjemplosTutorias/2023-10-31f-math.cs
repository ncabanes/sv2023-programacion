// Contacto con las funciones matemáticas

using System;
using System.Collections.Concurrent;

class RaizCuadradaYCubica
{
    static void Main()
    {
        Console.Write("Dime un número: ");
        int numero = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("Raíz cuadrada =  " + Math.Sqrt(numero));
        Console.WriteLine("Raíz cúbica =  " + Math.Pow(numero, 1.0/3.0));
    }
}

// Dime un número: 8
// Raíz cuadrada = 2,82842712474619
// Raíz cúbica =  2
