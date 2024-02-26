/*184. Crea una nueva variante del ejercicio 182, en la que los datos no se introduzcan en una cola (sin tipo),
 *  sino en una pila (sin tipo), de modo que se obtendrán en orden inverso al que se introdujeron. 
 * Nuevamente, comienza por usar una pila sin tipo.*/

// Noelia (...)


using System;
using System.Collections;

class Ejercicio182
{
    static void Main()
    {
        Stack pilaNumeros = new Stack();
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
            short numero = (short) pilaNumeros.Pop();
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
