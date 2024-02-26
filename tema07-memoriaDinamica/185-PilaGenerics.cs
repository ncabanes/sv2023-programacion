/*185. Haz una variante del ejercicio anterior, en la que los datos se guarden en
 *  una pila con tipo.*/

// Noelia (...)


using System;
using System.Collections.Generic;

class Ejercicio182
{
    static void Main()
    {
        Stack<short> pilaNumeros = new Stack<short>();
        string numerosUsuario;
        int suma = 0;

        Console.WriteLine("Introduce números + INTRO para almacenarlos, " +
            "y pulsa solo INTRO para finalizar:");
        do
        {
            numerosUsuario = Console.ReadLine();

            if (numerosUsuario != "")
            {
                pilaNumeros.Push(Convert.ToInt16(numerosUsuario));
            }

        } while (numerosUsuario != "");

        Console.Write("Números almacenados: ");
        int cantidadNumeros = pilaNumeros.Count;

        while (pilaNumeros.Count > 0)
        {
            short numero = pilaNumeros.Pop();
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
