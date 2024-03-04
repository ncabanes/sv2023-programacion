/* 196. Con la ayuda de File.ReadAllLines, y de un SortedList, crea un 
programa que pida al usuario el nombre de un fichero de texto y luego 
diga qué frases (no vacías) aparecen repetidas, y cuántas veces las ha 
encontrado. Haz una segunda versión usando una tabla Hash (o un 
Dictionary). Recorre los datos usando "foreach". Tienes ejemplos de 
ficheros de texto compartidos en GitHub (por ejemplo, "2000-0.txt"). */

using System;
using System.IO;
using System.Collections.Generic;

class Ejemplo 
{
    static void Main() 
    {
        Console.WriteLine("--- Versón con SorteList: ---");
        SortedList<string, int> frases = new SortedList<string, int>();
        string[] lineas = File.ReadAllLines("2000-0.txt");
        
        foreach(string linea in lineas)
        {
            if (! frases.ContainsKey(linea))
                frases.Add(linea, 1);
            else
            {
                frases[linea]++;
                /*
                Alternativa, más exhaustiva pero no necesaria:
                 
                int cantidad = frases[linea];
                cantidad++;
                frases[linea] = cantidad;
                */
            }
        }
        
        frases.Remove("");
        foreach(KeyValuePair<string, int> par in frases)
        {
            if (par.Value > 1)
                Console.WriteLine(par.Key + ": "+ par.Value);
        }
        
        
        Console.WriteLine("--- Versón con Dictionary: ---");
        Dictionary<string, int> frases2 = new Dictionary<string, int>();
        string[] lineas2 = File.ReadAllLines("2000-0.txt");
        
        foreach(string linea in lineas2)
        {
            if (! frases2.ContainsKey(linea))
                frases2.Add(linea, 1);
            else
            {
                frases2[linea]++;
                /*
                Alternativa, más exhaustiva pero no necesaria:
                 
                int cantidad = frases[linea];
                cantidad++;
                frases[linea] = cantidad;
                */
            }
        }
        
        frases2.Remove("");
        foreach(KeyValuePair<string, int> par in frases2)
        {
            if (par.Value > 1)
                Console.WriteLine(par.Key + ": "+ par.Value);
        }
    }
}

