/* 105. Crea tres versiones de una función para multiplicar un número por 10 y
 * prueba todas ellas desde un único Main:
 *
 * La primera será una función entera llamada "MultiplicarPor10a", que devolverá
 * multiplicado por 10 el valor del número entero pasado como parámetro (por
 * ejemplo, si el parámetro es 6, se devolverá 60).
 *
 * La segunda será un procedimiento (función "void") llamado "MultiplicarPor10b",
 * que multiplicará por 10 el valor del número entero pasado como parámetro (por
 * ejemplo, si el parámetro es 5, se convertirá en 50), sin usar "ref". Tras
 * llamar a la función, comprueba si en Main ha cambiado el valor de la variable
 * que has pasado como parámetro.
 *
 * La tercera será un procedimiento llamado "MultiplicarPor10c", que multiplicará
 * por 10 el valor de un número entero que se le pasará como parámetro ref (por
 * ejemplo, si el parámetro es 3, se convertirá en 30). Tras llamar a la función,
 * comprueba si en Main ha cambiado el valor de la variable que has pasado como
 * parámetro.
 *
 * VICTOR (...) - 1º DAM SEMI, retoques menores por Nacho */

using System;

class exercise_05_02_105
{
    static int MultiplicarPor10a (int n1)
    {
        n1 = n1*10;
        return n1;
    }

    static void MultiplicarPor10b (int n2)
    {
        n2 = n2*10;
    }

    static void MultiplicarPor10c (ref int n3)
    {
        n3 = n3*10;
    }

    static void Main()
    {
        Console.Write("Introduzca n1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = n1;
        int n3 = n1;
        
        n1 = MultiplicarPor10a(n1);
        Console.WriteLine(n1);

        MultiplicarPor10b(n2);
        Console.WriteLine(n2);

        MultiplicarPor10c(ref n3);
        Console.WriteLine(n3);
    }
}
