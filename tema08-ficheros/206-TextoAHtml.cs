/*206. Crea un "convertidor básico de texto a HTML", que leerá un 
archivo de texto de origen y creará un archivo HTML a partir de su 
contenido. Por ejemplo, si el archivo contiene:

Hola
Soy yo
Ya he terminado


El archivo HTML resultante debe contener

<html>
<head>
  <title>fichero.txt</title>
</head>
<body>
  <p>Hola</p>
  <p>Soy yo</p>
  <p>Ya he terminado</p>
</body>
</html>


El nombre del fichero de entrada se leerá de línea de comandos. Si no 
hay parámetros en línea de comandos, se le preguntará al usuario. El 
fichero de salida tendrá el mismo nombre que el de entrada, pero 
añadiendo ".html". Debes usar StreamReader y StreamWriter. Recuerda 
comprobar los posibles errores de funcionamiento.
*/

using System;
using System.IO;

class TextoAHtml1
{
    static void Main(string[] args)
    {               
        string nombreFichero;
        string nombreNuevoFichero;
        StreamReader ficheroLectura;
        StreamWriter ficheroEscritura;
        string linea;
        
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
            ficheroLectura = File.OpenText(nombreFichero);
            ficheroEscritura = File.CreateText(nombreNuevoFichero);

            ficheroEscritura.WriteLine("<html>");
            ficheroEscritura.WriteLine("<body>");

            do
            {
                linea = ficheroLectura.ReadLine();

                if (linea != null)
                    ficheroEscritura.WriteLine("<p>" + linea + "</p>");

            } while (linea != null);

            ficheroLectura.Close();

            ficheroEscritura.WriteLine("</body>");
            ficheroEscritura.WriteLine("</html>");
            ficheroEscritura.Close();
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
