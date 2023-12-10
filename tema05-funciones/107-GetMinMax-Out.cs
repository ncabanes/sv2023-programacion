
/*
107. Crea una variante del ejercicio 106 (GetMinMax)
*  que no emplee parámetros "ref" sino parámetros "out".

 Julio

 */

using System;

class PruebaOut
{
    static void GetMinMax(float[] numeros,
        out float min, out float max)
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
        float min;
        float max;
        float[] numeros = { 4.5f, 6, 2.2f, 7.1f, 81.6f };

        GetMinMax(numeros, out min, out max);
        Console.WriteLine("minimo: " + min);
        Console.WriteLine("máximo: " + max);
    }
}
