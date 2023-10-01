// 13. Crea un programa en C# que pida al usuario un número entero y responda 
// si es un número positivo, negativo o cero, usando "if" y "else".

//Por Nuria (...)

using System;

class PositivoNegativo
{
    static void Main()
    {
        int a;

        Console.Write("Dime un número entero: ");
        a = Convert.ToInt32(Console.ReadLine());
        
        if (a>0)
        {
            Console.Write("{0} es un número positivo", a);
        }
        else if (a==0)
        {
            Console.Write("Es cero", a);
        }
        else
        {
            Console.Write("{0} es un número negativo", a);
        }
    }
} 
