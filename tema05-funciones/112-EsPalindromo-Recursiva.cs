/* Diana (...) 1ºDAW SEMI
 * 112.Crea una función recursiva EsPalindromo como alternativa a la que
 * hiciste en el ejercicio 98, que devolverá "true" si la cadena de 
 * caracteres indicada como parámetro es simétrica. Pista: como caso base,
 * una cadena de 1 letra o menos será palíndroma siempre; para una
 * cadena de mayor longitud, se puede mirar los dos caracteres de los
 * extremos y descartarlos en caso de que sean iguales
 */

using System;

public class Ejer112
{   
    public static bool EsPalindromo(string texto)
    {
        string texto2 = texto.ToUpper();
        if(texto.Length <= 1)
        {
            return true;
        }
        else
        {
            if(texto2[0] == texto2[texto.Length-1])
            {
                return EsPalindromo(texto.Substring(1,texto.Length-2));
            }
            else
            {
                return false;
            }
        }
    }
    
    public static void Main()
    {
        string cadena;
        Console.WriteLine("Introduzca un texto: ");
        cadena=Console.ReadLine();
        bool palindromo=EsPalindromo(cadena);
        if(palindromo)
        {
            Console.WriteLine("Es un palíndromo");
        }
        else
        {
            Console.WriteLine("No es un palíndromo");
        }
    }
}
