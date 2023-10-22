/*
48. Pide al usuario tres números enteros, que guardarás en variables
"a", "b" y "c". Dale a una variable llamada "mayor" el valor del 
mayor número de esos 3. Hazlo de dos formas, como parte del mismo
programa: primero con dos "if" encadenados y luego con dos operadores
ternarios encadenados.

*/ //Boris (...)

using System;

class E48
{
    static void Main()
    {

        int mayor;
        Console.WriteLine("Número a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Número b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Número c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if ((a >= b) && (a >= c))
        {
            mayor = a;
        }
        else if ((b >= a) && (b >= c))
        {
            mayor = b;
        }
        else
        {
            mayor = c;
        }

        Console.WriteLine("El número mayor (if) es el {0}", mayor);

        mayor = a >= b && a >= c ? a 
            : b >= a && b >= c ? b 
            : c;
        Console.WriteLine("El número mayor (ternario) es el {0}", mayor);

    }
}
