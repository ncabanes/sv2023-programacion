/*Mario (...)
 * 213. Crea una programa que extraiga los caracteres imprimibles (código 
 * ASCII 32 a 127, además del 10 y el 13) de un fichero y los vuelque a otro 
 * fichero, usando BinaryReader y BinaryWriter. El nombre del fichero de origen 
 * se tomará de la línea de comandos y el de destino se creará añadiendo ".txt" 
 * al nombre de origen. Si el fichero de destino ya existe, lo sobreescribirás 
 * sin preguntar. Puedes comprobar su funcionamiento con cualquier imagen o
 * cualquier fichero ejecutable (que no sea exactamente el que acabas de 
 * lanzar, que estará bloqueado por el sistema operativo).
 */
using System;
using System.IO;

class Ejercicio_213
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("Introduce el nombre de fichero a analizar" +
                    " en la linea de comandos");
            }
            else
            {
                string nombreLeer = args[0];
                string nombreEscribir = nombreLeer + ".txt";
                byte unDato;

                BinaryReader ficheroLeer = new BinaryReader
                    (File.Open(nombreLeer, FileMode.Open));

                BinaryWriter ficheroEscribir = new BinaryWriter
                    (File.Open(nombreEscribir, FileMode.Create));
                int tamanyo = (int)ficheroLeer.BaseStream.Length;

                for (int i = 0; i < tamanyo; i++)
                {
                    unDato = (byte)ficheroLeer.ReadByte();
                    if ((unDato >= 32 && unDato <= 127)
                        || (unDato == 10) || (unDato == 13))
                    {
                        ficheroEscribir.Write(unDato);
                    }
                }
                ficheroLeer.Close();
                ficheroEscribir.Close();
            }  
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: "+e.Message);
            return;
        }
    }
}
