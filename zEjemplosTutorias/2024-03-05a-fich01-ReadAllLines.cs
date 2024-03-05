/* Abre un fichero de texto de nombre prefijado, 
 * volcando su contenido a un array de strings.
 * Vuelca a otro fichero (también de nombre prefijado)
 * su contenido tras eliminar todos los espacios.
 */

using System;
using System.IO;

class Ficheros
{
    static void Main()
    {
        string[] lineas = File.ReadAllLines("2000-0.txt");
        for (int i = 0; i < lineas.Length; i++)
        {
            lineas[i] = lineas[i].Replace(" ", "");
        }
        File.WriteAllLines("2000-1.txt", lineas);
    }
}
