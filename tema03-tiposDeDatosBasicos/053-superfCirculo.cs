/* 53. Calcula la superficie de un círculo, a partir de su radio, que 
introducirá el usuario en una variable real de doble precisión llamada "radio". 
(Recuerda que la fórmula es: area = pi * radio al cuadrado). Tanto el valor de 
"pi" como el resultado (la longitud) deben estar almacenados en variables, que 
también serán números reales de doble precisión. Recuerda que para elevar x al 
cuadrado, basta con hacer x*x. */

// Salvador (...)

using System;

public class T3_53
{
    public static void Main()
    {
        double radio, area;
        double pi = 3.1415926535;

        Console.Write("Dime el de radio: ");
        radio = Convert.ToDouble(Console.ReadLine());

        area = pi * radio*radio;

        Console.WriteLine("Si el radio es {0}, el area es {1}", radio, area);
    }
}
