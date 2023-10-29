// Ejercicio 54 Tema 3 - Pablo (...)
// Programa que alcula el volumen de un cono, a partir de su radio y su altura,
// que introducirá el usuario

using System;

public class Cono
{
    public static void Main()
    {
        float pi = 3.141592f;
        float radio, altura, volumen;
        
        Console.Write("Introduce el radio del cono: ");
        radio = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce la altura del cono: ");
        altura = Convert.ToSingle(Console.ReadLine());
        
        volumen = pi * radio*radio * altura / 3;
        Console.WriteLine("El volumen del cono es de: {0}", volumen);
    }
}
