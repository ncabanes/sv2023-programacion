// Pide al usuario una palabra. Cambia su segunda letra
// por una "o", de tres formas distintas.

using System;
using System.Text;

class Strings03
{
    static void Main()
    {
        string frase = Console.ReadLine();

        string nuevaFrase1 = frase
            .Remove(1, 1)
            .Insert(1, "o");
        Console.WriteLine(nuevaFrase1);

        string nuevaFrase2 = 
            frase.Substring(0,1)
            +"o"
            +frase.Substring(2);
        Console.WriteLine(nuevaFrase2);

        StringBuilder textoModificable = new StringBuilder(frase);
        textoModificable[1] = 'o';
        string nuevaFrase3 = textoModificable.ToString();
        Console.WriteLine(nuevaFrase3);
    }
}

// mala
// mola
// mola
// mola
