/*

Crea una variante del ejercicio anterior usando SortedList<string, 
string>.

*/

using System;
using System.Collections.Generic;

class Ejemplo 
{
    static void Main() 
    {
        SortedList<string, string> d = new SortedList<string, string>();
        d.Add("hello", "hola");
        d["bye"] = "adios";
        
        Console.Write("Dime la primera palabra en inglés: ");
        string p = Console.ReadLine();
        Console.Write("Dime su traducción: ");
        string t = Console.ReadLine();
        d.Add(p, t);
        
        Console.Write("Dime la segunda palabra en inglés: ");
        string p2 = Console.ReadLine();
        Console.Write("Dime su traducción: ");
        string t2 = Console.ReadLine();
        d[p2] = t2;
        
        Console.WriteLine( d["hello"] );
        
        foreach(string s in d.Keys)
        {
            Console.WriteLine("{0} = {1}",
                s,  d[s]);
        }
    }
}

// Dime la primera palabra en inglés: two
// Dime su traducción: dos
// Dime la segunda palabra en inglés: one
// Dime su traducción: uno
// hola
// bye = adios
// hello = hola
// one = uno
// two = dos
