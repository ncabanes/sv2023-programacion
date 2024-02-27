/*

Pide palabras al usuario, y guárdalas (sin duplicados) en un Conjunto. 
Cuando pulse Intro para terminar, muestra todas las palabras.


*/

using System;
using System.Collections.Generic;

class Ejemplo 
{
    static void Main() 
    {
        HashSet<string> c = new HashSet<string>();
        string palabra;
        
        do
        {
            Console.Write("Dime una palabra: ");
            palabra = Console.ReadLine();
            
            if (palabra != "")
                c.Add(palabra);
        }
        while (palabra != "");
        
        foreach(string s in c)
        {
            Console.WriteLine(s);
        }
    }
}

// Dime una palabra: uno
// Dime una palabra: dos
// Dime una palabra: tres
// Dime una palabra: uno
// Dime una palabra: cuatro
// Dime una palabra:
// uno
// dos
// tres
// cuatro
