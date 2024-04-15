/*

221. [Tiempo máximo recomendado: 1 hora]
Debes crear un programa capaz de convertir fuentes sencillos en C# a JavaScript,
como el que se muestra a continuación. Partirá de un fichero que se leerá de parámetros
(o se pedirá al usuario en caso de no existir parámetros)
y creará un fichero con el mismo nombre y en el que la extensión ".cs" será reemplazada por ".js".

using System;
class Javascript
{
    static void Main()
    {
        Console.WriteLine("Hola, bienvenido a JavaScript");

        Console.WriteLine("\"Console.WriteLine\" escribe string e int en C#");

        int numero = 3;
        if (numero > 2)
        {
            Console.WriteLine("El numero es mayor que 2");
        }

        if (numero == 3)
        {
            Console.WriteLine("El numero es 3");
        }

        for (int i = 10; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        string frase = "ejemplo de frase con Trim y Split";
        frase = frase.Replace("de", "con");
        frase = frase.ToUpper();
        frase = frase.Trim();
        string[] palabras = frase.Split(' ');
        foreach (string unaPalabra in palabras)
            Console.WriteLine(unaPalabra);
    }
}



Su resultado sería:

console.log("Hola, bienvenido a JavaScript");

console.log("\"Console.WriteLine\" escribe string e int en C#");

let numero = 3;
if (numero > 2)
{
    console.log("El numero es mayor que 2");
}

if (numero === 3)
{
    console.log("El numero es 3");
}

for (let i = 10; i <= 20; i += 2)
{
    console.log(i);
}

let frase = "ejemplo de frase con Trim y Split";
frase = frase.replace("de", "con");
frase = frase.toUpperCase();
frase = frase.trim();
let palabras = frase.split(" ");
for (let unaPalabra of palabras)
    console.log(unaPalabra);

En "Aules" (y GitHub), en la carpeta de ejercicios de clase, tendrás dos ficheros de prueba, llamados "cs2js1.cs" y "cs2js2.cs".

Los pasos que debes seguir y su valoración si fuera un ejercicio con nota, son:

 - Leer un archivo de texto de principio a fin, cuyo nombre será 
   introducido por el usuario en línea de comandos o (si no se indica 
   en línea de comandos) de forma interactiva: hasta 2 puntos.

 - Volcar todo el contenido a otro archivo de texto, cuyo nombre será 
   el mismo, pero con la extensión ".js" en lugar de ".cs": hasta 4 puntos.

 - Reemplazar "Console.WriteLine" con "console.log", "==" con "===", 
   "!=" con "!==" y cambiar por su equivalente que comience por 
   minúsculas los métodos "Trim", "Replace", "ToUpper" (que será 
   "toUpperCase") : hasta 5 puntos.

 - Cambiar string, int y demás tipos de datos por "let", sólo donde 
   corresponda: hasta 6 puntos.

 - Eliminar las líneas using, class, Main y tabular adecuadamente: hasta 7 puntos.

 - Que "split" funcione con cualquier separador y que los corchetes 
   se conviertan en "charAt": hasta 8 puntos.

 - Formato correcto para "foreach": hasta 9 puntos.

 - Que cualquier método (letra que siga a un punto) se convierta a 
   minúsculas (como ".startsWith") y que el programa resultante
   funcione correctamente en la consola del navegador (pulsando F12), 
   para ambos programas de prueba: hasta 10 puntos.

Es deseable que el fuente resultante quede correctamente tabulado (si 
el original lo estaba). DEBES emplear StreamReader y StreamWriter, no 
ReadAllLines ni ReadAllText.
*/

//julio

using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

class ConvertidorJs
{
    static void Main(string[] args)
    {
        string nombreFicheroEntrada;
        if (args.Length == 0)
        {
            Console.Write("Introduce el nombre del fichero: ");
            nombreFicheroEntrada = Console.ReadLine();
            //nombreFicheroEntrada = "cs2js1.cs";
            Console.WriteLine();
        }
        else
        {
            nombreFicheroEntrada = args[0];
        }

        try
        {
            string nombreFicheroSalida = nombreFicheroEntrada.Replace(".cs", ".js");

            if (File.Exists(nombreFicheroSalida))
            {
                Console.WriteLine("Error, el fichero ya existe");
            }
            else
            {
                StreamReader ficheroEntrada = new StreamReader(nombreFicheroEntrada);
                StreamWriter ficheroSalida = new StreamWriter(nombreFicheroSalida);
                string linea;
                int cuentaLineas = 0;

                do
                {
                    linea = ficheroEntrada.ReadLine();
                    cuentaLineas++;
                    if (linea != null && cuentaLineas > 5)
                    {
                        linea = linea.Replace("        ", "");
                        linea = linea.Replace("Console.WriteLine", "console.log");
                        linea = linea.Replace("===", "==");
                        linea = linea.Replace("!=", "!==");
                        linea = linea.Replace("int", "let");
                        linea = linea.Replace("string", "let");
                        linea = linea.Replace("foreach", "for");
                        linea = linea.Replace("in ", "of ");
                        linea = linea.Replace("[]", "");

                        if (linea.Contains('.') && !linea.Contains("Console"))
                        {
                            string[] palabra = linea.Split('.');
                            string lineaModificada = "";

                            for (int k = 0; k < palabra.Length; k++)
                            {
                                if (k > 0)
                                {
                                    palabra[k] = palabra[k].Replace(palabra[k].Substring(0, 1), "." + palabra[k].Substring(0, 1).ToLower());
                                }
                                lineaModificada += palabra[k];
                            }
                            linea = lineaModificada;
                        }
                        ficheroSalida.WriteLine(linea);
                    }
                }
                while (linea != null);
                ficheroEntrada.Close();
                ficheroSalida.Close();
                Console.WriteLine("Fichero creado");
            }
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine("Ruta demasiado larga " + e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("Error al acceder al fichero " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error General " + e.Message);
        }
    }
}

