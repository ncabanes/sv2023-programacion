/* 97. Crea una función llamada "MediaDeArray", que devolverá la media 
 * de los elementos de un array de reales de simple precisión que se 
 * pasará como parámetro. Si el array está vacío, devolverá 0. Pruébala 
 * con un array prefijado. La función deberá aparecer antes de "Main".
 */

// Diana (...), retoques por Nacho

using System;

public class Ejer97
{
    public static float MediaDeArray(float[] numeros)
    {
        float suma=0;
        for(int i=0;i<numeros.Length;i++)
        {
            suma += numeros[i];
        }
        if (numeros.Length == 0)
            return 0;
        else
            return suma / numeros.Length;
    }
    
    public static void Main()
    {
        float[] numeros={7.5f, 2.7f, 5, 3.3f, 2.5f};
        float media=MediaDeArray(numeros);
        Console.WriteLine("La media es {0}",media);
    }
}
