/*
Mario (...), retoques menores por Nacho

221. [Tiempo máximo recomendado: 1 hora] Debes crear un programa capaz de 
convertir fuentes sencillos en C# a JavaScript, como el que se muestra a 
continuación. Partirá de un fichero que se leerá de parámetros (o se 
pedirá al usuario en caso de no existir parámetros) y creará un fichero 
con el mismo nombre y en el que la extensión ".cs" será reemplazada por ".js".

Los pasos que debes seguir y su valoración si fuera un ejercicio con nota, son:

Leer un archivo de texto de principio a fin, cuyo nombre será introducido por 
el usuario en línea de comandos o (si no se indica en línea de comandos) de 
forma interactiva: hasta 2 puntos.
- Volcar todo el contenido a otro archivo de texto, cuyo nombre será el mismo, 
    pero con la extensión ".js" en lugar de ".cs": hasta 4 puntos.
- Reemplazar "Console.WriteLine" con "console.log", "==" con "===", "!=" con 
    "!==" y cambiar por su equivalente que comience por minúsculas los métodos 
    "Trim", "Replace", "ToUpper" (que será "toUpperCase") : hasta 5 puntos.
- Cambiar string, int y demás tipos de datos por "let", sólo donde 
    corresponda: hasta 6 puntos.
- Eliminar las líneas using, class, Main y tabular adecuadamente: hasta 7 puntos.
- Que "split" funcione con cualquier separador y que los corchetes se conviertan 
    en "charAt": hasta 8 puntos.
- Formato correcto para "foreach": hasta 9 puntos.
- Que cualquier método (letra que siga a un punto) se convierta a minúsculas 
    (como ".startsWith") y que el programa resultante funcione correctamente en 
    la consola del navegador (pulsando F12), para ambos programas de prueba: 
    hasta 10 puntos.
- Es deseable que el fuente resultante quede correctamente tabulado (si el 
    original lo estaba). DEBES emplear StreamReader y StreamWriter, 
    no ReadAllLines ni ReadAllText.
 */
using System;
using System.IO;

class Ejercicio_221
{
    static void Main(string[] args)
    {
        string nombreEntrada = "cs2js1.cs";
        int contador = 0;
        StreamReader archivoEntrada;
        StreamWriter archivoSalida;
        string linea, lineaSalida;
        /*
        if (args.Length <= 0)
        {
            Console.WriteLine("Introduce el nombre del archivo en la linea de comandos");
            nombreEntrada = Console.ReadLine();
        }
        else
        {
            nombreEntrada = args[0];
        }
        */
        string nombreSalida = nombreEntrada.Replace(".cs", ".js");
        try
        {
            archivoEntrada = File.OpenText(nombreEntrada);
            archivoSalida = File.CreateText(nombreSalida);
            do
            {
                if ((contador >= 0 && contador <= 4))
                {
                    linea = archivoEntrada.ReadLine();
                    contador++;
                }
                else
                {
                    linea = archivoEntrada.ReadLine();
                    if (linea != null) { 
                        Console.WriteLine("eviando la linea {0} que dice {1}", contador, linea);
                        lineaSalida = CambiaTexto(linea);
                        Console.WriteLine(contador);
                        contador++;
                        archivoSalida.WriteLine(lineaSalida);
                    }
                }

            }
            while (linea != null);
            archivoEntrada.Close();
            archivoSalida.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Nombre de archivo demasiado largo");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error de lectura o escritura: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error general: " + e.Message);
        }
    }

    public static string CambiaTexto (string texto)
    {
        texto = texto.Replace("Console.WriteLine(", "console.log(");
        texto = texto.Replace("        ", "");
        texto = texto.Replace("int ", "let ");
        texto = texto.Replace("string[] ", "let ");
        texto = texto.Replace("string ", "let ");
        texto = texto.Replace("==", "===");
        texto = texto.Replace("!=", "!==");
        texto = texto.Replace(".Replace", ".replace");
        texto = texto.Replace(".ToUpper", ".toUpperCase");
        texto = texto.Replace(".Trim", ".trim");
        texto = texto.Replace(".Split", ".split");
        texto = texto.Replace("foreach", "for");
        texto = texto.Replace(" in ", " of ");

        return texto;
    }
}
