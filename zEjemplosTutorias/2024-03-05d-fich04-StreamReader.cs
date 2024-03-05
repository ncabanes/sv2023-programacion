/* Lee el primero de los tres ficheros que has 
 * creado en el ejercicio anterior y muestra su contenido.
 */

using System;
using System.IO;

class Ficheros
{
    static void Main()
    {
        StreamReader f;
        string linea;

        f = File.OpenText("1.txt");
        do
        {
            linea = f.ReadLine();
            if (linea != null)
                Console.WriteLine(linea);
        }
        while (linea != null);
        f.Close();
    }
}

// Uno
// Dos
// Tres
