/* 24. Haz un programa que diga al usuario 
 * "Introduce un número negativo", y se lo pida tantas veces como 
 * sea necesario, repitiendo en caso de que introduzca un número no 
 * válido. Hazlo dos veces como parte del mismo programa: primero usando 
 * "while", y luego empleando "do-while". */

// Juan Luis (...)

using System;

class Ejercicio24
{
    static void Main ()
    {
        // ---------- Variante con while
        
        int numero;
        
        Console.WriteLine("Introduce un número negativo");
        numero = Convert.ToInt32(Console.ReadLine());
        
        while (numero >= 0)
        {
            Console.WriteLine("Número erroneo, vuelve a intentarlo");
            Console.WriteLine("Introduce un número negativo");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("El número introducido es {0}", numero);
        
        // ---------- Variante con do-while
        
        Console.WriteLine(); // Línea en blanco de separación
        
        do
        {
            Console.WriteLine("Introduce un número negativo");
            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero >= 0)
                Console.WriteLine("Número erroneo, vuelve a intentarlo");
        }        
        while (numero >= 0);
        
        Console.WriteLine("El número introducido es {0}", numero);
    }
}
