/*166. Crea una clase "Encriptador" que utilizaremos para cifrar y descifrar 
textos.

Tendrá un método "Encriptar", abstracto, que recibirá una cadena y devolverá 
otra cadena, y en método "Desencriptar", también abstracto, y con mismo 
parámetro y valor devuelto.

Crea una clase "EncriptadorXOR", que herede de "Encriptador" y que haga una 
operación "XOR 1" a cada carácter, tanto para obtener el texto cifrado como 
para descrifrarlo (recuerda que habíamos estudiado las operaciones a nivel de 
bits en el apartado 3.1.6, del tema 3).*/

// Miguel Ángel (...), retoques por Nacho

using System;

abstract class Encriptador
{
    public abstract string Encriptar(string cadena);
    public abstract string Desencriptar(string cadena);
}

// ------------

class EncriptadorXOR : Encriptador
{
    public override string Encriptar(string cadena)
    {
        string cadenaEncriptada = "";
        for (int i = 0; i < cadena.Length; i++)
        {
            char letra = cadena[i];
            letra = (char) (letra^1);
            cadenaEncriptada += letra;
        }
        return cadenaEncriptada;
    }

    public override string Desencriptar(string cadena)
    {
        return Encriptar(cadena);
    }
}

// ------------

class PruebaDeDesencriptador
{
    static void Main()
    {
        Encriptador eXOR = new EncriptadorXOR();

        string texto = "Este texto se va a enciptar";

        string textoEncriptado = eXOR.Encriptar(texto);
        Console.WriteLine("El texto a encriptar es : " + texto);
        Console.WriteLine("El texto encripatado es : " + textoEncriptado);
        Console.WriteLine("El texto desencriptado es : " + 
            eXOR.Desencriptar(textoEncriptado)); 
    }
}
