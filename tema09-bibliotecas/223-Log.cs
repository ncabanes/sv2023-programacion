/*
223. Crea un programa llamado "log", que, cada vez que se lance, 
añadirá una línea a un archivo de texto llamado "log.txt".  Esta línea 
contendrá la fecha y hora actuales, en formato AAAA-MM-DD HH:MM:SS.mmm, 
seguida por el texto que el usuario haya indicado como parámetros de la 
línea de comandos. Por ejemplo, si el ejecutable se llama "log.exe" y 
el usuario escribe "log Esto es una prueba" en la línea de comandos, se 
debe añadir una línea como:

2024-04-15 17:20:02.023 - Esto es una prueba

Si no se indica nada en línea de comandos, se preguntará al usuario qué 
texto desea anotar como parte del "log".
*/

//Iván (...)

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string texto;

        if (args.Length > 0)
        {
            texto = string.Join(" ", args);
        }
        else
        {
            Console.WriteLine("Ingrese el texto que desea agregar al registro:");
            texto = Console.ReadLine();
        }

        string datos = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " - " + texto;
        AddToLog(datos);
        Console.WriteLine("Datos introducidos.");
    }

    static void AddToLog(string datos)
    {
        string archivo = "log.txt";

        using (StreamWriter sw = File.AppendText(archivo))
        {
            sw.WriteLine(datos);
        }
    }
}
