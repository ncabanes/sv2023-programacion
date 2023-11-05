/* 70. Crea un programa en C# que pida al usuario una cadena y la muestre
 * encriptada de dos maneras diferentes: primero sumando 1 a cada carácter,
 * luego con la operación XOR 1. */
 
// Versión alternativa, que encripta y desencripta

using System;

class EncriptarYDesencriptar
{
    static void Main()
    {
        string frase;
        string fraseEncriptada, fraseDesencriptada;

        Console.Write("Introduzca una frase: ");
        frase = Console.ReadLine();
        
        // Parte 1, sumando 1 a cada letra

        fraseEncriptada = "";
        foreach (char letra in frase)
        {
            fraseEncriptada += (char)(letra + 1);
        }
        Console.WriteLine("Encriptada (1) "+ fraseEncriptada);

        fraseDesencriptada = "";
        foreach (char letra in fraseEncriptada)
        {
            fraseDesencriptada += (char)(letra - 1);
        }
        Console.WriteLine("Desencriptada (1) "+ fraseDesencriptada);
        
        // Parte 2, XOR 1

        fraseEncriptada = "";
        foreach (char letra in frase)
        {
            fraseEncriptada += (char)(letra ^ 1);
        }
        Console.WriteLine("Encriptada (2) "+ fraseEncriptada);

        fraseDesencriptada = "";
        foreach (char letra in fraseEncriptada)
        {
            fraseDesencriptada += (char)(letra ^ 1);
        }
        Console.WriteLine("Desencriptada (2) "+ fraseDesencriptada);
    }
}
