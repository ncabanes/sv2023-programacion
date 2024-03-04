/* 197. Crea una variante del ejercicio anterior (196), que no muestre las 
frases repetidas sino las palabras repetidas (ayudándote de ".Split()" 
para obtener las palabras y de ".Replace" para eliminar los símbolos de 
puntuación más habituales). Para que la salida no sea exageradamente 
grande, pregunta al usuario no sólo el nombre del fichero, sino también 
a partir de cuántas repeticiones (por ejemplo, 500) quiere que se 
muestren las palabras. En esta ocasión, en vez de SortedList, deberás 
usar una tabla Hash (o un Dictionary). */

using System;
using System.IO;
using System.Collections.Generic;

class Ejemplo 
{
    static void Main() 
    {
        Dictionary<string, int> frases = new Dictionary<string, int>();
        string[] lineas = File.ReadAllLines("2000-0.txt");
        int cantidadPalabras = 0;
        
        foreach(string linea in lineas)
        {
            string l = linea;
            l = l.Replace(".", "");
            l = l.Replace(",", "");
            l = l.Replace("-", "");
            foreach(string trozo in l.Split())
            {
                cantidadPalabras ++;
                if (! frases.ContainsKey(trozo))
                    frases.Add(trozo, 1);
                else
                {
                    frases[trozo]++;
                    /*
                    int cantidad = frases[linea];
                    cantidad++;
                    frases[linea] = cantidad;
                    */
                }
            }
        }
        
        
        foreach(KeyValuePair<string, int> par in frases)
        {
            if (par.Value > 500)
                Console.WriteLine(par.Key + ": "+ par.Value);
        }
        
        Console.WriteLine("Palabras totales: " + cantidadPalabras);
        Console.WriteLine("Palabras almacenadas: " + frases.Count);
    }
}
