/* Pide al usuario el nombre de un fichero WEBP. Lee el primer bloque 
de 12 bytes. Avísale en caso de que los bytes 9 a 12 no sean W,E,B,P.
*/

using System;
using System.IO;

class Ejemplo 
{
    static void Main() 
    {
        byte[] datos = new byte[12];
        FileStream f = File.OpenRead("welcome8.webp");
        int leidos = f.Read(datos, 0, 12);
        if (leidos != 12)
            Console.WriteLine("Fichero incompleto");
        else
        {
            string textoWebp = ""+Convert.ToChar(datos[8])
                + Convert.ToChar(datos[9])
                + Convert.ToChar(datos[10])
                + Convert.ToChar(datos[11]);
            if (textoWebp == "WEBP")
                Console.WriteLine("Imagen WEBP");
            else
                Console.WriteLine("NO es una imagen WEBP");
        }
        f.Close();
    }
}


// Imagen WEBP
