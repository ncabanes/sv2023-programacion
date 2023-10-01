/* 11. Crea un programa en C# que pida al usuario un número entero y
 * responda si es par o no lo es, empleando la orden "if" (pero no "else").
 * Pista: deberás usar el "operador módulo" (%).
 * VÍCTOR (...) */

using System;

class Exercise_02_01_11
{
    static void Main()
    {
        int number;
        
        Console.WriteLine("Escriba un número:");
        number = Convert.ToInt32(Console.ReadLine());
        
        if (number % 2 == 0)
            Console.WriteLine("Es par");
            
        if (number % 2 != 0)
            Console.WriteLine("Es impar");
    }
}
