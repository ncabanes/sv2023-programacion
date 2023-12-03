/*99. Crea una función entera llamada "CantidadDeDivisores", que devolverá la 
cantidad de divisores que tiene el número entero largo que se indique como 
parámetro. Por ejemplo, si el número es 8, deberá devolver como resultado 4 
(porque el 8 tiene 4 divisores: 1, 2, 4, 8).*/

// Eric (...), retoques por Nacho

using System;

class Ejercicio_99
{
    static int CantidadDeDivisores(int n)
    {
        int cantidad = 0;
        
        for (int i = 1; i <= n; i++) 
        {
            if (n % i == 0)
            {
                cantidad ++;
            }
        }
        return cantidad;
    }

    static void Main()
    {
        Console.Write("Escribe un numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El numero {0} tiene: {1} divisores.", 
            n1, CantidadDeDivisores(n1));
    }
}
