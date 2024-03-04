/*
198. Crea una variante del ejercicio anterior (197), 
que muestre todas las palabras que hay en el texto 
(sin preocuparse por cuántas veces aparecen), usando un conjunto.

Versión B, HashSet

julio, retoques menores por Nacho
*/

using System;
using System.IO;
using System.Collections.Generic;

class Fichero
{
    static void Main()
    {
        HashSet<string> frases = new HashSet<string>();
        Console.Write("Indica el nombre del fichero: ");
        string nombreFichero = Console.ReadLine().ToLower();
        Console.WriteLine("Leyendo" );
        string[] lineas = File.ReadAllLines(nombreFichero);
        int cantidadPalabras = 0;

        Console.WriteLine("Memorizando palabras..." );
        DateTime comienzo = DateTime.Now;
        foreach (string linea in lineas)
        {
            string l = linea.Trim();
            l = l.Replace(",", "");
            l = l.Replace(".", "");
            l = l.Replace(":", "");
            l = l.Replace("-", "");
            //Console.WriteLine(l);
            //Console.ReadLine();
            foreach (string palabra in l.Split())
            {
                cantidadPalabras ++;
                if (!frases.Contains(palabra))
                {
                    frases.Add(palabra);
                }
            }
        }
        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Lista de palabras:" );
        foreach (string palabra in frases)
            Console.Write(palabra + " ");
        
        Console.WriteLine();
        Console.WriteLine("Palabras totales: " + cantidadPalabras);
        Console.WriteLine("Palabras almacenadas: " + frases.Count);
    }
}
