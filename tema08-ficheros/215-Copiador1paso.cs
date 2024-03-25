/* 215. Crea un programa que permita copiar un archivo de origen a un archivo
 * de destino. El nombre de ambos ficheros se tomará de la línea de comandos.
 * Debes usar FileStream y un bloque con el tamaño de todo el archivo. Un
 * ejemplo de uso podría ser:
 * 
 * micopiador fichero1.txt e:\fichero2.txt
 * 
 * Debe comportarse correctamente si el archivo de origen no existe y debe
 * avisar (pero no sobrescribirlo) si el archivo de destino existe.
 * 
 * VICTOR (...) */

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Write("ERROR: Introduzca el nombre del fichero y de salida");
            return;
        }
        else
        {
            string nombreFicheroEntrada = args[0];
            string nombreFicheroSalida = args[1];

            if (File.Exists(nombreFicheroEntrada))
            {
                try
                {
                    // LEER
                    FileStream ficheroEntrada = File.OpenRead(nombreFicheroEntrada);

                    int tamanyoFicheroEntrada = (int)ficheroEntrada.Length;
                    byte[] datos = new byte[ficheroEntrada.Length];
                    int cantidad = ficheroEntrada.Read(datos, 0, tamanyoFicheroEntrada);

                    Console.WriteLine("Datos leídos correctamente");
                    ficheroEntrada.Close();

                    // ESCRIBIR
                    if (File.Exists(nombreFicheroSalida))
                    {
                        Console.WriteLine("El fichero de salida ya existe");
                    }
                    else
                    {
                        FileStream ficheroSalida = File.Create(nombreFicheroSalida);
                        ficheroSalida.Write(datos, 0, cantidad);

                        Console.WriteLine("Datos creados correctamente");
                        ficheroSalida.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Fichero no encontrado");
            }
        }
    }
}
