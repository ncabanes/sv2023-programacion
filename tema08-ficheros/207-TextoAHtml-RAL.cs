/*207. Crea una versión alternativa del ejercicio anterior (convertidor 
básico de texto a HTML), empleando ReadAllLines y WriteAllLines, y 
ayudándote de una List<string> para las manipulaciones intermedias que 
sean necesarias. */

using System;
using System.Collections.Generic;
using System.IO;

class TextoAHtml2
{
    static void Main(string[] args)
    {               
        string nombreFichero;
        string nombreNuevoFichero;
        
        if (args.Length < 1)
        {
            Console.WriteLine("Indique el fichero a convertir: ");
            nombreFichero = Console.ReadLine();
        }
        else
        {
            nombreFichero = args[0];
        }
        nombreNuevoFichero = nombreFichero + ".html";

        try
        {
            List<string> lineas = 
                new List<string>(File.ReadAllLines(nombreFichero));
            lineas.Insert(0,"<html>");
            lineas.Insert(1,"<body>");
            for(int i = 2; i <lineas.Count; i++)
            {
                lineas[i] = "<p>" + lineas[i] + "</p>";
            }
            lineas.Add("</body>");
            lineas.Add("</html>");
            File.WriteAllLines(nombreNuevoFichero, lineas);
            Console.WriteLine("Conversión terminada");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Nombre demasiado largo");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Ese fichero no existe");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error de E/S: {0}", e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error inesperado: {0}", e.Message);
        }
    }
}
