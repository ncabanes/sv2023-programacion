/* Nombre: Andrés (...) */

/* Ejercicio 32. Números pares descendentes.
 * 
 * Muestra los números pares del 30 al 10, ambos inclusive, descendiendo,
 * separados por un espacio, sin avanzar de línea, usando "for". 
 * 
 * Hazlo dos veces como parte de un mismo programa: 
 * primero disminuyendo de 2 en 2 y luego repítelo disminuyendo de 1 en 1 
 * pero comprobando si el número es par antes de escribirlo. */
 
 using System;
 
class numerosDescendientes 
{
    static void Main() 
    {
        // Números descendentes de dos en dos.
        for (int numero = 30; numero >= 10; numero-=2) 
        {
            Console.Write("{0} ", numero);
        }
        Console.WriteLine();

        // Números descendentes de uno en uno comprobando si es par.
        for (int numero = 30; numero >= 10; numero--) 
        {
            if (numero % 2 == 0)  
            {
                Console.Write("{0} ", numero);
            }
        }
        Console.WriteLine();
    }
}
