// Ejemplo de uso de "bool"

using System;

class EjemploBool
{
    static void Main()
    {
        bool esDeLosBuenos;

        Console.Write("Dime tu nombre: ");
        string nombre = Console.ReadLine();

        foreach(char letra in nombre)
        { 
            Console.Write(letra + " ");
        }

        Console.Write("Qué estudias? ");
        string estudios = Console.ReadLine();

        // if (estudios == "DAM")
        //     esDeLosBuenos = true;
        // else
        //     esDeLosBuenos = false;
        
        // esDeLosBuenos = 
        //     estudios == "DAM" ? true : false;

        esDeLosBuenos = estudios == "DAM";

        // if (esDeLosBuenos == true)
        if (esDeLosBuenos)
            Console.WriteLine("Bravooooo");
        else
            Console.WriteLine("Allá tú");
    }
}

// Dime tu nombre: Nacho
// N a c h o Qué estudias? Dam
// Allá tú
