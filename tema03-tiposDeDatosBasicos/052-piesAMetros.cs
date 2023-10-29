/* 52. Crea una versión mejorada del ejercicio 8: un programa que pida al
 * usuario una cantidad de pies y muestre su equivalencia en metros
 * (1 pie = 0,305 metros). Debe emplear tres variables: pies, metros,
 * metrosPorPie, todas ellas números reales de simple precisión (float). Debe
 * mostrar toda la información en una línea, algo como "2 pies son 0,61 m".
 * 
 * VICTOR (...) - 1º DAM SEMI */

using System;

class exercise_03_01_52
{
    static void Main()
    {
        float pies, metros, metrosPorPie;

        Console.Write("Introduzca la cantidad de pies: ");
        pies = Convert.ToSingle(Console.ReadLine());
        
        metrosPorPie = 0.305f;

        metros = metrosPorPie * pies;

        Console.WriteLine("{0} pies son {1} m.", pies, metros);
    }
}
