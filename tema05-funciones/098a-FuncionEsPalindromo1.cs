/*98. Crea una función booleana llamada "EsPalindromo", que devolverá "true" si 
el parámetro, un texto, es una palabra palíndroma (que se lee igual de 
izquierda a derecha que de derecha a izquierda), o "false" en caso contrario. 
Pide al usuario un texto en "Main" y responde si es palíndromo.*/

// Miguel Ángel (...)

using System;

class FuncionBoolEsPalindromo
{
    static bool EsPalindromo(string texto)
    {
        string textoReves = "";
        
        for (int i = texto.Length - 1; i >= 0; i --)
        {
            textoReves += texto[i];
        }
        if (textoReves.ToUpper() == texto.ToUpper())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    static void Main()
    {
        string frase;
        
        Console.Write("Escribe un texto: ");
        frase = Console.ReadLine();
        
        if (EsPalindromo(frase) == true)
        {
            Console.WriteLine("La frase es palíndroma");
        }
        else
        {
            Console.WriteLine("La frase no es palíndroma");
        }
    }
}
