// Ejemplo de uso de "char"

using System;

class EjemploDeChar
{
    static void Main()
    {
        // Letras de la A a la Z
        for (char letra = 'A'; letra <= 'Z'; letra++)
            Console.Write("{0} ", letra);
        Console.WriteLine();

        // Letras de ASCII 32 al 127
        for (byte i = 32; i <= 127; i++)
        {
            Console.Write(Convert.ToChar(i));
            if (Convert.ToChar(i) == '\'')
                Console.Write(" {0} ", i);
        }
    }
}

// A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
// !"#$%&' 39 ()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~
