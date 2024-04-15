/*Debes crear un programa capaz de leer un fichero en formato PGM ASCII (cabecera P2)
 * y crear un fichero PGM binario (cabecera P5), con comentarios
 * (si los hubiera en el fichero original).
 * El programa deber comportarse correctamente con imágenes de distinto ancho y alto.
 */
 
// kathy (...), retoques por Nacho
// Nota: falta comprobación de errores con try-catch

using System;
using System.IO;
using System.Collections.Generic;

class ejercicio_222
{
    static void Main(string[] args)
    {
        // Verificar si se proporcionó un nombre de archivo de entrada en la línea de comandos
        string ficheroEntrada;
        if (args.Length > 0)
        {
            ficheroEntrada = args[0];
        }
        else
        {
            Console.Write("Introduce el nombre del archivo de entrada: ");
            ficheroEntrada = Console.ReadLine();
        }

        // Verificar si el archivo de entrada existe
        if (!File.Exists(ficheroEntrada))
        {
            Console.WriteLine("El archivo '" + ficheroEntrada + "' no existe.");
            return;
        }

        // Generar el nombre de archivo de salida
        string[] nombreYExtension = ficheroEntrada.Split('.');
        string nombreSinExtension = nombreYExtension[0];
        string extension = nombreYExtension[1];
        string ficheroSalida = nombreSinExtension + "2." + extension;

        // Verificar si el archivo de salida ya existe
        if (File.Exists(ficheroSalida))
        {
            Console.WriteLine("El archivo de salida '" + 
                ficheroSalida + "' ya existe." +
                " Interrumpiendo la ejecución.");
            return;
        }

        // Leer el contenido del archivo de entrada
        List<string> lineas = new List<string>();
        using (StreamReader lectura = new StreamReader(ficheroEntrada))
        {
            string linea;
            do
            {
                linea = lectura.ReadLine();
                if (linea != null)
                {
                    if (!linea.StartsWith("#"))
                        lineas.Add(linea);
                }
            } while (linea != null);
        }
        int ancho, alto, IntensidadMaxima;
        // Obtener el ancho, alto y máxima intensidad (cosas del formato bgm) parseado a int
        string[] dimensiones = lineas[1].Split(' ');
        ancho = Convert.ToInt32(dimensiones[0]);
        alto = Convert.ToInt32(dimensiones[1]);
        IntensidadMaxima = Convert.ToInt32(lineas[2]);
        
        // Escribir la cabecera del archivo de salida
        StreamWriter fs1 = new StreamWriter(ficheroSalida);
        fs1.Write("P5\n" + ancho + " " + alto + "\n" + IntensidadMaxima + "\n");
        fs1.Close();

        // Escribir el resto de datos
        using (FileStream fs = new FileStream(ficheroSalida, FileMode.Append))
        {
            BinaryWriter escritor = new BinaryWriter(fs);
            // Escribir los datos de la imagen en formato binario
            for (int i = 3; i < lineas.Count; i++)
            {
                string[] valoresPixeles = lineas[i].Split(' ');
                foreach (string pixel in valoresPixeles)
                {
                    if ((pixel != " ") && (pixel != ""))
                    {
                        byte valorPixel = Convert.ToByte(pixel);
                        escritor.Write(valorPixel);
                    }
                }
            }
        }

        Console.WriteLine("El archivo de salida '" + ficheroSalida + "' se ha creado correctamente.");
    }
}
