/*
Haz un programa que calcule una raíz cuadrada (entera) por 
aproximación, tanteando los valores que sea necesario. Por ejemplo, si 
el usuario introduce 82, el resultado debería ser 9, porque 9*9=81, que 
es menor (o igual) que 82, pero 10*10=100, que es mayor que 82. Usa las 
estructuras de programación que consideres más adecuadas. Además, 
deberá decir si la raíz es exacta o aproximada. Por ejemplo, para el 
número 81, la respuesta será "9 (exacta)", y para el 99 la respuesta 
será "9 (aproximada)". Usa la(s) estructura(s) repetitiva(s) que 
consideres adecuada(s).
*/

// David (...)

using System;

class RaizTanteo 
{
    static void Main () 
    {
        Console.Write("Introduce un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int raiz = 0;

        while (raiz * raiz <= numero) {
            raiz++;
        }

        raiz--;

        Console.Write(raiz);

        if (raiz * raiz == numero) 
        {
            Console.WriteLine(" (exacta)");
        } 
        else 
        {
            Console.WriteLine(" (aproximada)");
        }
    }
}
