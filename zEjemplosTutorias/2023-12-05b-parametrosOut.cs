/* Crea una variante del ejercicio anterior (función "MaysYMins"), 
empleando parámetros "out").
*/

using System;

class EjemploOut 
{
    static void MaysYMins(string texto, 
        out string mays, out string mins)
    {
        mays = "";
        mins = "";
        foreach(char l in texto)
        {
            if (l >= 'A' && l <= 'Z')
                mays += l;
            if (l >= 'a' && l <= 'z')
                mins += l;
        }
    }
    
    static void Main() 
    {
        string saludo = "Hola Que Tal";
        string ma, mi;
        
        MaysYMins(saludo, out ma, out mi);
        Console.WriteLine("Mays: "+ma);
        Console.WriteLine("Mins: "+mi);
    }
}

// Mays: HQT
// Mins: olaueal

