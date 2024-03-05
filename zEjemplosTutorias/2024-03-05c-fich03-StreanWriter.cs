/* Crea tres ficheros, cada uno de ellos formado por 
 * tres líneas: "Uno", "Dos" y "Tres", desde un mismo 
 * programa, usando los tres formatos vistos.
 */

using System;
using System.IO;

class Ficheros
{
    static void Main()
    {
        StreamWriter f;

        f = File.CreateText("1.txt");
        f.WriteLine("Uno");
        f.WriteLine("Dos");
        f.WriteLine("Tres");
        f.Close();

        f = new StreamWriter("2.txt");
        f.WriteLine("Uno");
        f.WriteLine("Dos");
        f.WriteLine("Tres");
        f.Close();

        using (f = new StreamWriter("3.txt"))
        {
            f.WriteLine("Uno");
            f.WriteLine("Dos");
            f.WriteLine("Tres");
        }

        using (f = File.CreateText("4.txt"))
        {
            f.WriteLine("Uno");
            f.WriteLine("Dos");
            f.WriteLine("Tres");
        }

    }
}
