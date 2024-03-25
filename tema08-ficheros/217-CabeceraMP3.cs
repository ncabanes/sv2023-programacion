/* Crea un programa que muestre la información almacenada en un archivo 
MP3 (que tenga una cabecera en formato "ID3 TAG V1"): título, artista, 
álbum, año. Deberás comprobar el contenido de los últimos 128 bytes del 
fichero. En caso de tratarse de un MP3 que tenga cabecera en dicho 
formato, deberías encontrar la siguiente secuencia de bytes a partir de 
esa posición:

- Los caracteres TAG (3 bytes)

- Título: 30 caracteres (30 bytes).

- Artista: 30 caracteres (ídem).

- Álbum: 30 caracteres.

- Año: 4 caracteres.

- Un comentario: 30 caracteres.

- Género (musical): un byte.

Todas las etiquetas usan caracteres ASCII (terminados en caracteres 
nulos o quizá en espacios), excepto el género, que es un número entero 
almacenado en un único byte. Tienes un fichero de ejemplo "mp3.mp3" 
compartido en Aules y GitHub.
*/

// Javier (...)

using System;
using System.IO;

class Ejercicio_217
{
    static void Main()
    {
        string nombreFichero= "mp3.mp3";

        byte[] datos = new byte[128];
        FileStream f = File.OpenRead(nombreFichero);
        f.Seek(-128, SeekOrigin.End);
        f.Read(datos,0,128);
        f.Close();

        if (datos[0] == (byte)'T' && datos[1] == (byte)'A' && datos[2] == (byte)'G')
        {
            Console.WriteLine("Es un fichero MP3 con ID3V1");

            string titulo = "";
            for (int i = 3; i < 33; i++)
            {
                titulo += (char)datos[i];
            }
            Console.WriteLine("Titulo: "+titulo);

            string artista = "";
            for (int i = 33; i < 63; i++)
            {
                artista += (char)datos[i];
            }
            Console.WriteLine("Artista: " + artista);

            string album = "";
            for (int i = 63; i < 93; i++)
            {
                album += (char)datos[i];
            }
            Console.WriteLine("Álbum: " + album);

            string anyo = "";
            for (int i = 93; i < 97; i++)
            {
                anyo += (char)datos[i];
            }
            Console.WriteLine("Anyo: " + anyo);

            string comentario = "";
            for (int i = 97; i < 127; i++)
            {
                comentario += (char)datos[i];
            }
            Console.WriteLine("Comentario: " + comentario);

            byte genero = datos[127];
            Console.WriteLine("Género: " + genero);
        }
    }
}
