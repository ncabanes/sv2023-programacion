/*
27. Crea un programa que muestre los números del 10 al 20, 
separados por un espacio, sin avanzar de línea, usando "while".
*/

// Noelia (...)

 using System;
 
 class Ejercicio027
 {
    static void Main()
    {
       int numero = 10;
       
       while (numero <= 20)
       {
            Console.Write("{0} ", numero);
            numero = numero + 1;
       }
    }
}
