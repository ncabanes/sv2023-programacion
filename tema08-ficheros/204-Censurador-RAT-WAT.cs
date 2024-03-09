/* 204. Crea un programa en C# que lea el contenido de un fichero de 
texto en una sola pasada, con File.ReadAllText. Luego, censura al menos 
5 palabras escogidas por ti (por ejemplo, cambia la palabra "suspenso" 
por "[Censurado]" y guarda el resultado en otro fichero con la orden 
"File.WriteAllText (nombreFichero, texto);". El nombre del fichero de 
texto de entrada se tomará de la línea de comandos. El nombre del 
fichero de salida será el mismo que el de entrada, añadiéndole 
".censurado.txt". Debes comprobar los posibles errores con try-catch. 
*/

using System;
using System.IO;

class Ejercicio204
{

    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Indique el fichero en línea de comandos");
            return;
        }
        try
        {
            string texto = File.ReadAllText(args[0]);
            texto = texto.Replace("suspenso", "[Censurado]");
            texto = texto.Replace("difícil", "[Censurado]");
            texto = texto.Replace("complicado", "[Censurado]");
            texto = texto.Replace("trabajoso", "[Censurado]");
            texto = texto.Replace("complejo", "[Censurado]");
            File.WriteAllText(args[0]+".censurado.txt", texto);
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

