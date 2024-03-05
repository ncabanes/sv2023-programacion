/* Crea una variante del ejercicio anterior, 
 * tratando todo el fichero como una gran cadena de texto.
 */

using System;
using System.IO;

class Ficheros
{
    static void Main()
    {
        string linea = File.ReadAllText("2000-0.txt");
        linea = linea.Replace(" ", "");
        File.WriteAllText("2000-2.txt", linea);
    }
}
