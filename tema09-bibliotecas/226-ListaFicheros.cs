/*
226. Crea un programa que muestre la lista de ficheros que hay en una cierta 
ruta que se indique en línea de comandos (o en la carpeta del ejecutable, si no 
se indica nada en línea de comandos). Para cada fichero, mostrará su nombre, 
extensión, tamaño en KB (destacando los millares, si es el caso) y fecha y hora 
de modificación, así:

ejemplo.exe, 1.234 KB, 12-Mar-2024 17:43
ejemplo.dat, 67 KB, 13-Abr-2024 05:23
*/

// Mario (...)

using System;
using System.IO;

class Ejercicio226
{
    static void Main(string[] args)
    {
        string ruta;
        if (args.Length == 0)
        {
            ruta = ".";
        }
        else
        {
            ruta = args[0];
        }

        string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul",
            "Ago", "Sep", "Oct", "Nov", "Dic" };
        DirectoryInfo carpeta;
        FileInfo[] ficheros;

        try
        {
            carpeta = new DirectoryInfo(ruta);
            ficheros = carpeta.GetFiles();

            foreach (FileInfo f in ficheros)
            {
                long tamanyo = f.Length / 1024;
                string fecha = f.LastWriteTime.Day + " - "
                    + meses[f.LastWriteTime.Month - 1] + " - "
                    + f.LastWriteTime.Year + " "
                    + f.LastWriteTime.ToString("t");
                Console.WriteLine("{0}, {1} KB, {2}", f.Name,
                    tamanyo.ToString("N0"), fecha);
            }
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Nombre de archivo demasiado largo");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error de lectura/escritura: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error inesperado: " + e.Message);
        }
    }
}
