/* 
203. Crea un programa en C# que ordene el contenido de un fichero de 
texto y lo vuelque a otro fichero, convirtiendo cada línea a 
mayúsculas. Usa File.ReadAllLines y File.WriteAllLines. El nombre del 
fichero de texto de entrada se debe preguntar al usuario. El nombre del 
fichero de salida será el mismo que el de entrada, añadiéndole 
".mays.txt". En esta versión no es necesario que compruebes los 
posibles errores con try-catch.
*/

// Versión b, mejorada con try-catch

using System;
using System.IO;

class Ejercicio203
{

    static void Main()
    {
        Console.WriteLine("Introduce el nombre del fichero a convertir a mayúsculas");
        string nombreEntrada = Console.ReadLine();
        string nombreSalida = nombreEntrada + ".mays.txt";
        try
        {
            string[] lineas = File.ReadAllLines(nombreEntrada);
            for (int i = 0; i < lineas.Length; i++)
            {
                lineas[i] = lineas[i].ToUpper();
            }
            File.WriteAllLines(nombreSalida, lineas);
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
        
        Console.WriteLine("Conversión terminada");
    }
}

