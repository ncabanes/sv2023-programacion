/*

Crea un diccionario inglés-español usando una SortedList. Añade dos 
palabras prefijadas y pide otras dos (con su traducción). Luego muestra 
una de las prefijadas, y después todas ellas usando un esqueleto como 
éste:

 for (int i = 0; i < miDiccio.Count; i++)
     Console.WriteLine("{0} = {1}",
        miDiccio.GetKey(i),  miDiccio[ miDiccio.GetKey(i) ]);

*/

using System;
using System.Collections;

class Ejemplo 
{
    static void Main() 
    {
        SortedList d = new SortedList();
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
        
        
        for (int i = 0; i < d.Count; i++)
        {
            string clave = (string) d.GetKey(i);
            string valor = (string) d[ clave ];
            Console.WriteLine("{0} = {1}",
                clave,  valor);
        }
    }
}

// Dime la primera palabra en inglés: one
// Dime su traducción: uno
// Dime la segunda palabra en inglés: two
// Dime su traducción: dos
// hola
// bye = adios
// hello = hola
// one = uno
// two = dos
