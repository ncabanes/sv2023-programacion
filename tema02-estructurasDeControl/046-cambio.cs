/*
46. Crea un programa que devuelva el cambio de una compra, 
utilizando siempre en primer lugar monedas (o billetes) 
del valor más grande posible. Supondremos que tenemos 
una cantidad ilimitada de monedas (o billetes) de 
100, 50, 10, 5 y 1, y que no hay decimales. La ejecución 
podría ser algo como:

Precio? 222
Pagado? 500
Tu cambio es 378: 100 100 100 50 10 10 5 1 1 1 

Usa la(s) estructura(s) repetitiva(s) que consideres adecuada(s).
*/ 

// Boris (...)

using System;
class E46
{
    static void Main()
    {
        System.Console.Write("Precio?: ");
        int precio = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Pagado?: ");
        int pagado = Convert.ToInt32(Console.ReadLine());

        int cambio = pagado - precio;

        System.Console.Write("Su cambio es: ");

        while (cambio > 100)
        {
            cambio = cambio - 100;
            System.Console.Write("100 ");
        }
        while (cambio > 50)
        {
            cambio = cambio - 50;
            System.Console.Write("50 ");

        }
        while (cambio > 10)
        {
            cambio = cambio - 10;
            System.Console.Write("10 ");
        }
        while (cambio > 5)
        {
            cambio = cambio - 5;
            System.Console.Write("5 ");
        }
        while (cambio > 0)
        {
            cambio = cambio - 1;
            System.Console.Write("1 ");
        }
        
        Console.WriteLine();
    }
}
