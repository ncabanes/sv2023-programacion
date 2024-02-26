/*183. Crea una variante del ejercicio anterior, en la que utilices una cola 
con tipo base -Generics-.*/

// Noelia(...)


using System;
using System.Collections.Generic;

class Ejercicio182
{
    static void Main()
    {
        Queue<short> colaNumeros = new Queue<short>();
        string numerosUsuario;
        int suma = 0;

        Console.WriteLine("Introduce números + INTRO para almacenarlos, " +
            "y pulsa solo INTRO para finalizar:");
        do
        {
            numerosUsuario = Console.ReadLine();

            if (numerosUsuario != "")
            {
                colaNumeros.Enqueue(Convert.ToInt16(numerosUsuario));
            }

        } while (numerosUsuario != "");

        Console.Write("Números almacenados: ");
        int cantidadNumeros = colaNumeros.Count;

        while (colaNumeros.Count > 0)
        {
            short numero = colaNumeros.Dequeue();
            Console.Write(numero + " ");
            suma += numero;
        }
        Console.WriteLine();  

        if (cantidadNumeros > 0)
        {
            double media = (double)suma / cantidadNumeros;
            Console.WriteLine("Suma total: " + suma);
            Console.WriteLine("Media: " + media);
        }
        else
        {
            Console.WriteLine("No se ha introducido ningún número");
        }
    }
}
