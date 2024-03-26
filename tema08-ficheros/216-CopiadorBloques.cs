/*216. Crea una variante del ejercicio anterior (copiar un archivo de origen a 
un archivo de destino), que en esta ocasión utilizará FileStream con un bloque 
de 10 KiB (10240 bytes) de tamaño.*/

//Miguel Ángel (...)

using System;
using System.IO;

class micopiador
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Falta archivo de origen y/o archivo de destino");
        }
        else
        {
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("El archivo de origen no existe");
            }
            if (File.Exists(args[1]))
            {
                Console.WriteLine("El archivo de destino ya existe");
            }
            else if (File.Exists(args[0]))
            {
                const int TAMANYO_BUFFER = 10240;
                
                try
                {
                    FileStream ficheroSalida = File.Create(args[1]);
                    FileStream ficheroEntrada = File.OpenRead(args[0]);
                    
                    int leidos;
                    do
                    {
                        int posicion = 0;
                        byte[] datos = new byte[TAMANYO_BUFFER];
                        leidos = ficheroEntrada.Read(
                            datos, posicion, TAMANYO_BUFFER);
                        ficheroSalida.Write(datos, posicion, leidos);
                    }
                    while (leidos == 10240);
                    
                    ficheroEntrada.Close();
                    ficheroSalida.Close();
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Error, ruta del fichero es demasiado larga");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error de lectura: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error general: " + e.Message);
                }
                
            }
        }
    }
}
