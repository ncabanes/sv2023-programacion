
/*
106. Crea una función llamada "GetMinMax", que devolverá el mínimo y el máximo 
(en ese orden) del array de números reales de simple precisión 
que se pase como parámetro, empleando dos parámetros por referencia. 
Si el array está vacío, no devolverá ningún valor, sino que se deberá 
lanzar una excepción (para lo que no necesitas hacer nada especial: el
programa fallará al acceder a la posición [0], y es un comportamiento aceptable).
Crea un Main de prueba.

 Julio

 */

using System;

class PruebaRef
{
    static void GetMinMax(float[] numeros,
        ref float min, ref float max)
    {
        min = numeros[0];
        max = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > max)
            {
                max = numeros[i];
            }

            if (numeros[i] < min)
            {
                min = numeros[i];
            }
        }
    }

    static void Main()
    {
        float min = 0;
        float max = 0;
        float[] numeros = { 4.5f, 6, 2.2f, 7.1f, 81.6f };

        GetMinMax(numeros, ref min, ref max);
        Console.WriteLine("minimo: " + min);
        Console.WriteLine("máximo: " + max);
    }
}
