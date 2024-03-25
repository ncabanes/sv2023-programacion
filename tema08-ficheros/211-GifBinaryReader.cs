/*
211. Crea un programa que pida el nombre de un fichero GIF y compruebe si realmente se trata de una imagen en ese formato
. Debes hacerlo con BinaryReader. 
Para conseguirlo, deberás leer byte a byte, 
y comprobar que los 4 primeros bytes corresponden a los caracteres G, I, F, 8. 
El quinto byte permite saber la versión concreta de fichero GIF del que se trata (GIF87 o GIF89),
que deberás mostrar en pantalla. Tienes un fichero de ejemplo "welcome8.gif" compartido en Aules y GitHub.

julio
 */

using System;
using System.IO;

class AnalizadorGif
{
    static void Main()
    {
        Console.Write("indica el nombre del fichero: ");
        string nombreFichero = Console.ReadLine();
        BinaryReader fichero = new BinaryReader(
            File.OpenRead(nombreFichero));
        string leido = "";


        for (int i = 0; i < 5; i++)
        {
            leido += Convert.ToChar(fichero.ReadByte());
        }
        fichero.Close();

        Console.WriteLine(leido);
        if (leido == "GIF87" || leido == "GIF89")
        {
            Console.WriteLine("Es un archivo .gif");
        }
        else
        {
            Console.WriteLine("No es un archivo . gif");
        }
        
    }
}
