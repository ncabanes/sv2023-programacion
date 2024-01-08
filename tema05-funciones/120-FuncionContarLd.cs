/*
 120. Crea una función "ContarLd", que permita saber la cantidad de letras 
(sólo del alfabeto inglés) y de dígitos que hay en la cadena que se pasa 
como parámetro. Se usaría de manera parecida a:

ContarLd("Este es 1 Texto", letras, digitos);
Console.WriteLine ("Letras: " + letras + ", dígitos: " + digitos);
// Mostraría "Letras: 12, dígitos: 1"

Julio
 */

using System;
using System.Text;

class Contador
{
    static int ContarLd(string cadena, out int letras, out int digitos)
    {
        letras = 0;
        digitos = 0;

        foreach (char caracter in cadena)
        {
            if (caracter >= 'A' && caracter <= 'z')
            {
                letras++;
            }
            if (caracter >= '0' && caracter <= '9')
            {
                digitos++;
            } 
        }
        return letras  + digitos;
    }

    static void Main()
    {
        int letras, digitos;

        ContarLd("Este es 1 Texto", out letras, out digitos);
        Console.WriteLine("Letras: " + letras + ", dígitos: " + digitos);
    }
}
