/*
 199. Para comparar velocidades de ejecución, crea una versión alternativa del ejercicio anterior (198),
que no guarde las palabras en un conjunto sino en una List<string> 
(pero sólo las palabras que no estén ya en la lista). 
Si te interesa conocer el tiempo exacto de ejecución, puedes usar la estructura:

DateTime comienzo = DateTime.Now;
// Aquí va el proceso que se quiere medir
Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));

julio, retoques menores por Nacho
 */

using System;
using System.IO;
using System.Collections.Generic;

class Fichero
{
    static void Main()
    {
        List<string> frases = new List<string>();
        int contadorPalabras = 0;
        Console.Write("Indica el nombre del fichero: ");
        string nombreFichero = Console.ReadLine().ToLower();
        Console.WriteLine("Leyendo" );
        string[] lineas = File.ReadAllLines(nombreFichero);

        Console.WriteLine("Memorizando palabras..." );
        DateTime comienzo = DateTime.Now;
        foreach (string linea in lineas)
        {
            string l = linea.Trim();
            l = l.Replace(",", "");
            l = l.Replace(".", "");
            l = l.Replace(":", "");
            l = l.Replace("—", "");
            //Console.WriteLine(l);
            //Console.ReadLine();

            foreach (string palabra in l.Split())
            {
                contadorPalabras++;
                if (!frases.Contains(palabra))
                {
                    frases.Add(palabra);
                    //Console.WriteLine(palabra);
                }
            }
        }
        Console.WriteLine("Palabras totales: " + contadorPalabras);
        Console.WriteLine("Palabras almacenadas: " + frases.Count);
        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
    }
}
