/*182. Pide al usuario números enteros cortos (short), tantos como desee, hasta 
 * que pulse Intro en vez de un número. Deberás ir almacenando todos ellos en una cola.
 *  Finalmente, deberás mostrar todos los datos que ha introducido, así 
 * como su suma y su media (que deberás calcular en el momento de mostrar los 
 * datos, no en el de introducirlos). Debes emplear una cola sin tipo base.*/

// Noelia(...)


using System;
using System.Collections;

class Ejercicio182
{
    static void Main()
    {
        Queue colaNumeros = new Queue();
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
            short numero = (short) colaNumeros.Dequeue();
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
