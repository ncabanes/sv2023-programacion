// Crea una función "SumaDeArray", reciba como parámetros un array de 
// enteros y devuelva como resultado la suma de los números que forman ese 
// array. Pruébala desde Main, con un array prefijado.

using System;

class EjemploFuncion3
{
    static void Main() 
    {
        int[] numeros = { 1, 2, 3, 4, 5};
        Console.WriteLine( SumaDeArray(numeros) );
        
        int[] numeros2 = { 11, 21, 31, 41, 51};
        int suma = SumaDeArray(numeros2);
        Console.WriteLine(suma);
    }
    
    static int SumaDeArray(int[] datos)
    {
        int suma = 0;
        
        for (int i = 0; i < datos.Length; i++)
        {
            suma += datos[i];
        }
        return suma;
    }
}

// 15
// 155


