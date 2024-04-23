/*229. Intenta romper la contraseña de un segundo archivo comprimido, en esta 
ocasión probando todas las palabras de un diccionario (el fichero "words.txt" 
que ya habíamos usando anteriormente). Tendrás un fichero compartido llamado 
"c2.rar" en Aules y en GitHub, y también tendrás el (des)compresor de línea de 
comandos "rar.exe" (la orden para descomprimir probando una contraseña "hola" 
es "rar x c2.rar -phola").*/

// Miguel Ángel

using System;
using System.Diagnostics;
using System.IO;

class RomperPasswordTexto
{
    static void Main()
    {
        try
        {
            Process p;
            int contador = 0;
            string[] palabras = File.ReadAllLines("words.txt");
            Console.Write("Probando: ");
            do
            {
                p = Process.Start("rar", "x c2.rar -p" 
                    + palabras[contador]);
                p.WaitForExit();
                Console.Write(palabras[contador]+" ");
                if (p.ExitCode != 0)
                {
                    contador++;
                }
            }
            while (p.ExitCode != 0 && contador < palabras.Length);
            if (p.ExitCode == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Encontrado: " + palabras[contador]);
            }
        } 
        catch (IOException e)
        { 
            Console.WriteLine("Error de lectura: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error general: " + e.Message);
        }
    }
}

