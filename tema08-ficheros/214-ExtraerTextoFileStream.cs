/*
214. Crea una variante del ejercicio anterior: un programa que extraiga los 
caracteres imprimibles (código ASCII 32 a 127, además del 10 y el 13) de un 
fichero y los vuelque a otro fichero. Todos los demás caracteres se convertirán 
a espacio (ASCII 32). El nombre del fichero de origen se tomará de la línea de 
comandos y el de destino se creará añadiendo ".2.txt" al nombre de origen. 
Debes usar FileStream y un bloque con el tamaño de todo el archivo. Si el 
fichero de destino ya existe, lo sobreescribirás sin preguntar.
*/

// Mario (...)

using System;
using System.IO;

class Ejercicio214
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Introduzca el nombre de fichero en la línea" +
                " de comandos.");
        }
        else
        {
            string nombre = args[0];
            string salida = nombre + ".2.txt";

            FileStream lectura = new FileStream(nombre, FileMode.Open);
            FileStream escritura = new FileStream(salida, FileMode.Create);
            byte[] datos = new byte[lectura.Length];

            for (int i = 0; i < lectura.Length; i++)
            {
                datos[i] = (byte) lectura.ReadByte();
                if ((datos[i] < 32 || datos[i] > 127) && datos[i] != 10 &&
                    datos[i] != 13)
                {
                    datos[i] = 32;  
                }
            }
            escritura.Write(datos, 0, datos.Length);

            lectura.Close();
            escritura.Close();
        }
    }
}
