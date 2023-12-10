
/*
106. Crea una funci�n llamada "GetMinMax", que devolver� el m�nimo y el m�ximo 
(en ese orden) del array de n�meros reales de simple precisi�n 
que se pase como par�metro, empleando dos par�metros por referencia. 
Si el array est� vac�o, no devolver� ning�n valor, sino que se deber� 
lanzar una excepci�n (para lo que no necesitas hacer nada especial: el
programa fallar� al acceder a la posici�n [0], y es un comportamiento aceptable).
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
        Console.WriteLine("m�ximo: " + max);
    }
}
