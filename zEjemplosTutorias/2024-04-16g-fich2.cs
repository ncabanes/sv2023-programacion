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
        DirectoryInfo d = new DirectoryInfo(".");
        FileInfo[] ficheros = d.GetFiles("*.cs");
        foreach (FileInfo f in ficheros) 
        {
            Console.WriteLine(f.Name + " " +f.CreationTime);
        }
    }
}
