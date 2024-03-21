/* Pide al usuario el nombre de un fichero WEBP. Lee un bloque de 4 
bytes tras saltar los primeros 8 bytes. Avísale en caso de que los 4 
bytes no sean W,E,B,P.
*/

using System;
using System.IO;

class Ejemplo 
{
    static void Main() 
    {
        byte[] datos = new byte[4];
        FileStream f = File.OpenRead("welcome8.webp");
        f.Seek(8, SeekOrigin.Begin);
        int leidos = f.Read(datos, 0, 4);
        if (leidos != 4)
            Console.WriteLine("Fichero incompleto");
        else
        {
            string textoWebp = ""
                + Convert.ToChar(datos[0])
                + Convert.ToChar(datos[1])
                + Convert.ToChar(datos[2])
                + Convert.ToChar(datos[3]);
            if (textoWebp == "WEBP")
                Console.WriteLine("Imagen WEBP");
            else
                Console.WriteLine("NO es una imagen WEBP");
        }
        f.Close();
    }
}


// Imagen WEBP
