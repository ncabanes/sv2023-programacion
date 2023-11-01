// Ejemplo de "const"

using System;

class EjemploConst
{
    static void Main()
    {
        const string ESTUDIOS_DESEABLES = "DAM";
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

        esDeLosBuenos = estudios == ESTUDIOS_DESEABLES;

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
