using System;

class Ejercicio006
{
    static void Main()
    {
        int n1, n2, producto;
        
        Console.Write("Introduce el primer número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        producto = n1 * n2;
        Console.WriteLine("El resultado de multiplicar {0} y {1} es {2}.", 
            n1, n2, producto);
    }
}

