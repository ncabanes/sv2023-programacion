/*219. [Tiempo máximo recomendado: 40 minutos] Mostrar un BMP en consola 
(examen del tema 8, grupo presencial, 2013-2014; resuelto en un video de Udemy)

Crea un programa que sea capaz de mostrar una imagen en blanco y negro en 
formato BMP de 256 colores en la consola, como el archivo de ejemplo que tienes 
compartido, llamado "welcome8.bmp".

La estructura de la cabecera de un fichero BMP es:
TYPE OF INFORMATION   POSITION IN THE FILE
File type (letters BM)  0-1
File Size  2-5
Reserved 6-7 
Reserved 8-9
Start of image data 10-13
Size of bitmap header 14-17
Width (pixels) 18-21
Height (pixels) 22-25
Number of planes 26-27
Size of each point 28-29
Compression (0=not compressed) 30-33
Image size 34-37
Horizontal resolution 38-41
Vertical resolution 42-45
Size of color table 46-49
Important colors counter 50-53


Puedes leer el ancho (bytes 18 a 21) y el alto (bytes 22 a 25) de la imagen, ya 
sea usando BinaryReader (cada uno es un entero de 32 bits) o FileStream (de la 
forma que puedes ver en la página 24 de los apuntes).

Los bytes 10 a 13 (que también forman un Int32) se pueden usar para saber en 
qué posición del fichero comienzan los datos de la imagen. Como alternativa, ya 
que cada píxel corresponde a un byte, puedes situarte a "-ancho*alto" desde el 
final del archivo y comenzar a leer desde ahí. 

Debes dibujar un "." si el valor del píxel es > 127, o un "*" en caso 
contrario.

Lo tienes resuelto en el video 8.12 de Udemy. Es un video de menos de 20 
minutos, por lo que irlo haciendo mientras ves el video no debería llevarte más 
de 30 minutos.*/ 

// Miguel Ángel (...)

using System; 
using System.IO;

class MostrarBMP
{
    static void Main()
    {
        Console.Write("Nombre del fichero BMP:");
        string nombre = Console.ReadLine();

        if (!File.Exists(nombre))
        {
            Console.WriteLine("¡No encontrado!");
        }
        else
        {
            BinaryReader fichero = new BinaryReader(
                File.Open(nombre, FileMode.Open));

            char marca1 = Convert.ToChar(fichero.ReadByte());
            char marca2 = Convert.ToChar(fichero.ReadByte());

            if ((marca1 !='B') || (marca2 !='M'))
            {
                Console.WriteLine("No parece un fichero BMP");
            }
            else
            {
                try
                {
                    fichero.BaseStream.Seek(18, SeekOrigin.Begin);
                    int ancho = fichero.ReadInt32();
                    int alto = fichero.ReadInt32();

                    fichero.BaseStream.Seek(10, SeekOrigin.Begin);
                    int principioImagen = fichero.ReadInt32();

                    fichero.BaseStream.Seek(principioImagen, SeekOrigin.Begin);
                    for (int i = 0; i < alto; i++)
                    {
                        Console.SetCursorPosition(0, alto - i);
                        for (int j = 0; j < ancho; j++)
                        {
                            byte pixel = fichero.ReadByte();
                            if (pixel > 127)
                            {
                                Console.Write(".");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine();
                    }
                    fichero.Close();
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine(
                        "Error, ruta del fichero es demasiado larga");
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

