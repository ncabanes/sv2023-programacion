// Mario (...)
// Conversor de pies a milímetros

using System;

class Conversor
{
    static void Main()
    {
        int pies, milimetros;
        int milimetrosPorPie = 305;

        Console.WriteLine ("Introduce el número de pies");
        pies = Convert.ToInt32 (Console.ReadLine());

        milimetros = pies * milimetrosPorPie;

        Console.Write (pies);
        Console.Write (" pies son ");
        Console.Write (milimetros);
        Console.Write (" milímetros.");
    }
}
