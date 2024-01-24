﻿/* Crea una clase " Encriptador" que utilizaremos para cifrar y 
descifrar textos. Tendrá un método "Encriptar", que recibirá una cadena 
y devolverá otra cadena (el resultado de sumar 1 a cada carácter), y un 
método "Desencriptar", que devolverá también devolverá una cadena (el 
resultado de restar 1 a cada carácter). Ambos métodos serán "static". 
Crea una clase "PruebaDeEncriptador", que compruebe su funcionamiento 
desde "Main".

*/

using System;

class Encriptador
{
    public string Encriptar(string texto)
    {
        string temporal = "";
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];
            letra++;
            temporal += letra;
        }
        return temporal;
    }
    
    public string Desencriptar(string texto)
    {
        string temporal = "";
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];
            letra--;
            temporal += letra;
        }
        return temporal;
    }
}


// -------------------

class PruebaDeEncriptador
{
    static void Main()
    {
        Encriptador e = new Encriptador();
        
        Console.WriteLine(e.Encriptar("Hola"));
        Console.WriteLine(e.Desencriptar("Ipmb"));
    }
}

// Ipmb
// Hola
