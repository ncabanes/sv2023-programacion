/*

Crea una nueva versión del diccionario inglés-español usando una 
HashTable. En esta ocasión, para mostrar los datos, recorre el array de 
claves, así:

 foreach (string palabra in miDiccio.Keys)
    Console.WriteLine(palabra + " - " + miDiccio[palabra]);


*/

using System;
using System.Collections;

class Ejemplo 
{
    static void Main() 
    {
        Hashtable d = new Hashtable();
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

// Dime la primera palabra en inglés: one
// Dime su traducción: uno
// Dime la segunda palabra en inglés: two
// Dime su traducción: dos
// hola
// two = dos
// one = uno
// bye = adios
// hello = hola
