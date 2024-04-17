/*
Muestra el nombre y fecha de los fuentes en C# 
(ficheros .cs) que hay en la carpeta actual.
*/

using System;
using System.IO;

class Prueba
{ 
    static void Main()
    {
        string[] ficheros = Directory.GetFiles(".");
        foreach (string f in ficheros) 
        {
            Console.WriteLine(f);
        }
    }
}
