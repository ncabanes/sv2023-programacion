/*
Pide al usuario el nombre de un fichero WEBP. Avísale en caso de que el 
primer byte no sea una letra R.
*/

using System;
using System.IO;

class Ejemplo 
{
    static void Main() 
    {
        FileStream f = File.OpenRead("welcome8.webp");
        int dato = f.ReadByte();
        if (dato == -1)
            Console.WriteLine("No he podido leer");
        byte caracter = (byte) dato;
        if (Convert.ToChar(caracter) == 'R')
            Console.WriteLine("Empezamos bien");
        else
            Console.WriteLine("NO es un WEBP");
        f.Close();
    }
}

// Empezamos bien

