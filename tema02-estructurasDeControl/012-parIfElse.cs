// Ejercicio 12 Tema 2 - Pablo (...)
// Programa que determina si un número introducido por usuario es par o no
// v2.0

using System;

public class EsPar
{
    public static void Main()
    {
        int numero, resto;
        
        Console.WriteLine("Introduce un número entero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        resto = numero%2;
        
        if (resto == 0) 
            Console.WriteLine("El número es par.");
        else 
            Console.WriteLine("El número no es par.");
    }
}
