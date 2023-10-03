// Tutoría de 03/10/23. Ejercicio 2.2.1.1.4

/*
(2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de 
números al usuario. Tras introducir cada par de números, responderá si 
el primero es múltiplo del segundo. Se repetirá mientras los dos 
números sean distintos de cero (terminará cuando uno de ellos sea 
cero).

(2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras 
introducir cada par de números, responderá si el primero es múltiplo 
del segundo, o el segundo es múltiplo del primero, o ninguno de ellos 
es múltiplo del otro.
*/

using System;

class Ejercicio_2_2_1_1_4 
{
    static void Main() 
    {
        int a, b;
        
        do
        {
            Console.Write("Dime a: ");
            a = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("Dime b: ");
            b = Convert.ToInt32( Console.ReadLine() );
            
            if (a % b == 0)
                Console.WriteLine("a es múltiplo de b");
            else if (b % a == 0)
                Console.WriteLine("b es múltiplo de a");
            else
                Console.WriteLine("ninguno es múltiplo");
        }
        while ((a != 0) && (b != 0));
    }
}
