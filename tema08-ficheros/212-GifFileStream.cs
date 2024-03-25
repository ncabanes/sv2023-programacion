/*
212. Crea una variante del ejercicio anterior: un programa que pida el 
nombre de un fichero GIF y compruebe si realmente se trata de una 
imagen en ese formato. Debes hacerlo con FileStream, leyendo un bloque 
de 5 bytes. Deberás comprobar que los 4 primeros bytes corresponden a 
los caracteres G, I, F, 8. El quinto byte permite saber la versión 
concreta de fichero GIF del que se trata (GIF87 o GIF89), que deberás 
mostrar en pantalla. Tienes un fichero de ejemplo "welcome8.gif" 
compartido en Aules y GitHub.
*/

// Javier (...)

using System;

using System.IO;

class Ejercicio_212
{
    static void Main()
    {
        Console.WriteLine("Nombre del fichero");
        string nombre=Console.ReadLine();

        byte[] datos = new byte[5];
        FileStream fichero = new FileStream(nombre, FileMode.Open);
        int leidos = fichero.Read(datos, 0, 5);
        fichero.Close();
        
        if (leidos != 5)
        {
            Console.WriteLine("Fichero incompleto!");
        }
        else
        {
            if (datos[0] == 'G' && datos[1] == 'I' &&
                datos[2] == 'F' && datos[3] == '8'
                && datos[4] == '7')
            {
                Console.WriteLine("Se trata de un fichero GIF87");
            }

            else if (datos[0] == 'G' && datos[1] == 'I' &&
               datos[2] == 'F' && datos[3] == '8'
               && datos[4] == '9')
            {
                Console.WriteLine("Se trata de un fichero GIF89");
            }

            else
            {
                Console.WriteLine("El fichero no es un GIF");
            }
        }
    }
}
