/* 205. Crea un programa que pregunte al usuario el nombre de un 
fichero de texto de entrada y vuelque la lista ordenada de palabras que 
contiene (sin duplicados) a un fichero llamado "palabras.txt", 
empleando StreamReader y StreamWriter. Debes comprobar si el fichero de 
entrada existe, y avisar en caso de que no sea así, además de analizar 
el resto de posibles errores con try-catch.
*/

using System;
using System.Collections.Generic;
using System.IO;

class Ejercicio205
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el nombre del fichero de entrada");
        string nombreEntrada = Console.ReadLine();
        string nombreSalida = "palabras.txt";
        
        if (! File.Exists(nombreEntrada))
        {
            Console.WriteLine("Fichero de entrada no encontrado.");
        }
        else
        {
            string linea;
            try
            {
                SortedSet<string> palabras = new SortedSet<string>();
                StreamReader ficheroEntrada = new StreamReader(nombreEntrada);
                do
                {
                    linea = ficheroEntrada.ReadLine();
                    if (linea != null)
                    {
                        linea = linea.Replace(".","");
                        linea = linea.Replace(",","");
                        linea = linea.Replace("-","");
                        string[] trozos = linea.Split();
                        foreach(string trozo in trozos)
                            palabras.Add(trozo);
                    }
                }
                while (linea != null);
                ficheroEntrada.Close();
                
                StreamWriter ficheroSalida = new StreamWriter(nombreSalida);
                foreach(string palabra in palabras)
                    ficheroSalida.WriteLine(palabra);
                ficheroSalida.Close();
                
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Nombre demasiado largo");
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
        Console.WriteLine("Conversión terminada");
    }
}

