/* Pide al usuario el nombre de un fichero WEBP. Usando BinaryReader, 
lee 4 bytes tras saltar los primeros 8 bytes. Avísale en caso de que 
los 4 bytes no sean W,E,B,P.
*/

using System;
using System.IO;

class Ejemplo 
{
    static void Main() 
    {
        byte[] datos = new byte[4];
        BinaryReader f = new BinaryReader( 
            File.Open("welcome8.webp", FileMode.Open));

        f.BaseStream.Seek(8, SeekOrigin.Begin);
        byte b1 = f.ReadByte();
        byte b2 = f.ReadByte();
        byte b3 = f.ReadByte();
        byte b4 = f.ReadByte();

        string textoWebp = ""
            + Convert.ToChar(b1)
            + Convert.ToChar(b2)
            + Convert.ToChar(b3)
            + Convert.ToChar(b4);
        if (textoWebp == "WEBP")
            Console.WriteLine("Imagen WEBP");
        else
            Console.WriteLine("NO es una imagen WEBP");

        f.Close();
    }
}


// Imagen WEBP
