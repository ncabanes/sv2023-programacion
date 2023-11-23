// Pide al usuario una palabra y muéstrala con mayúsculas 
// "en formato de nombre" (la primera letra en mayúsculas 
// y el resto en minúsculas)

using System;

class Strings01
{
    static void Main()
    {
        string frase = Console.ReadLine();
        // frase.ToUpper();
        // Console.WriteLine(frase);

        string fraseModificada =
            frase.ToUpper().Substring(0, 1) +
            frase.ToLower().Substring(1);
        Console.WriteLine(fraseModificada);

        string fraseModificada2 =
            frase.Substring(0, 1).ToUpper() +
            frase.Substring(1).ToLower();
        Console.WriteLine(fraseModificada2);

        string fraseModificada3 = frase.ToLower();
        fraseModificada3 =
            fraseModificada3.ToUpper()[0] +
            fraseModificada3.Substring(1);
        Console.WriteLine(fraseModificada3);
    }
}

// hOLa
// Hola
// Hola
// Hola
