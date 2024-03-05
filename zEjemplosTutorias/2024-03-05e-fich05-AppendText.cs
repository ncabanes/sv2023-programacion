/* Crea un programa que, cada vez que se lance, 
 * pida una frase al usuario, la añada al 
 * fichero "registro.txt" y termine.
 */

using System;
using System.IO;

class Ficheros
{
    static void Main()
    {
        //StreamWriter f = File.AppendText("registro.txt");
        StreamWriter f = new StreamWriter("registro.txt",true);
        Console.Write("Dime una frase: ");
        string linea = Console.ReadLine();
        f.WriteLine(linea);
        f.Close();
    }
}

// cuatro
// cinco
// seis
