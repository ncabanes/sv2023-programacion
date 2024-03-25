/* 218. Crea un programa que sea capaz de encriptar y desencriptar una 
imagen en formato BMP, intercambiando el orden de sus dos primeros 
bytes de modo que los visores de imágenes no la detecten como una 
imagen válida. Debes abrir el fichero para lectura y escritura 
simultánea. Tienes un fichero de ejemplo ("welcome8.bmp") compartido en 
Aules y GitHub. */

//Iván Navarro Rojas

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string nombre = "welcome8.bmp";
        using (BinaryReader imagen = new BinaryReader
            (File.Open(nombre, FileMode.OpenOrCreate)))
        {
            byte cabecera1 = imagen.ReadByte();
            byte cabecera2 = imagen.ReadByte();

            imagen.BaseStream.Seek(0, SeekOrigin.Begin);
            imagen.BaseStream.WriteByte(cabecera2);
            imagen.BaseStream.WriteByte(cabecera1);
        }
        Console.WriteLine("Codificado.");
    }
}

