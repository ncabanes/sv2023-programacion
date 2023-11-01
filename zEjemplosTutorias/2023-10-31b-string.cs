// Contacto con los "string"

using System;

class ContactoString
{
    static void Main()
    {
        Console.Write("Dime tu nombre: ");
        string nombre = Console.ReadLine();

        foreach(char letra in nombre)
        { 
            Console.Write(letra + " ");
        }

        Console.Write("Qué estudias? ");
        string estudios = Console.ReadLine();
        if (estudios == "DAM")
            Console.WriteLine("Bravooooo");
        else
            Console.WriteLine("Allá tú");
    }
}

// Dime tu nombre: Nacho
// N a c h o Qué estudias? Dam
// Allá tú
