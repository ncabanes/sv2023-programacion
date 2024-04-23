/*
230. Muestra información sobre el sistema: versión de Windows, versión 
de Punto Net, nombre de usuario actual, carpeta de documentos, y, 
finalmente, espacio libre y espacio total en todas las particiones de 
disco (quizá necesites buscar información sobre "DriveInfo") 
*/

// Iván (...)

using System;
using System.IO;

class InfoSistema
{
    static void Main()
    {
        string windowsVersion = Environment.OSVersion.ToString();

        string dotNetVersion = Environment.Version.ToString();

        string usuario = Environment.UserName;

        string carpetaDocumentos = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments);

        Console.WriteLine("Información del sistema:");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Versión de Windows: " + windowsVersion);
        Console.WriteLine("Versión de .NET: " + dotNetVersion);
        Console.WriteLine("Nombre de usuario actual: " + usuario);
        Console.WriteLine("Carpeta de documentos: " + carpetaDocumentos);

        DriveInfo[] allDrives = DriveInfo.GetDrives();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nInformación de espacio en disco:");
        Console.ForegroundColor = ConsoleColor.Blue;

        foreach (DriveInfo drive in allDrives)
        {
            if (drive.IsReady)
            {
                Console.WriteLine("Unidad: {0}", drive.Name);
                Console.WriteLine("  Espacio libre: {0}", FormatoBytes
                    (drive.AvailableFreeSpace));
                Console.WriteLine("  Espacio total: {0}", FormatoBytes
                    (drive.TotalSize));
            }
        }
    }
    
    static string FormatoBytes(long bytes)
    {
        string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
        int suffixIndex = 0;
        double size = bytes;

        while (size >= 1024 && suffixIndex < suffixes.Length - 1)
        {
            size /= 1024;
            suffixIndex++;
        }

        return size.ToString("0.##") + " " +suffixes[suffixIndex];
    }
}
