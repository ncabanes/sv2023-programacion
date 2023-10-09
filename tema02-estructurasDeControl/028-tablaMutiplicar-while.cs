/*
 * 28. Escribe un programa en C# que pida al usuario un número entero y muestre
 * su tabla de multiplicar, usando "while".
 * 
 * VÍCTOR (...)
*/

using System;

class exercise_02_02_28
{
    static void Main()
    {
        int num, multiplicador;
        
        Console.Write("Introduzca un número entero: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        multiplicador = 0;
        while (multiplicador <= 10)
        {
            Console.WriteLine("{0} x {1} = {2}", 
                num, multiplicador, num*multiplicador);
            multiplicador ++;
        }
    }
}
