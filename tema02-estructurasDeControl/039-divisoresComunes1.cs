/*Escribe un programa que le pida al usuario dos números a y b, así 
como un límite inferior y un límite superior, y muestre todos los 
números entre ambos límites (incluidos) que sean a la vez múltiplos de 
a y de b, como en este ejemplo:

Introduce un número: 2
Introduce otro número: 5
¿A partir de qué número buscamos? 10
¿Hasta qué número buscamos? 30

He encontrado los siguientes múltiplos comunes de ambos números: 10 20 30
*/

// Salvador (...)

using System;

public class T2_39
{
    public static void Main()
    {   
        int a, b, inicio, fin;

        Console.Write("Introduce un número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce otro número: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿A partir de qué número buscamos? ");
        inicio = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Hasta qué número buscamos? ");
        fin = Convert.ToInt32(Console.ReadLine());
        
        Console.Write(
            "He encontrado los siguientes múltiplos comunes de ambos números: "); 
        for(int i = inicio; i <= fin; i++)
        {
            if ((i%a == 0) && (i%b == 0))
                Console.Write("{0} ", i);
        }
    }
}
