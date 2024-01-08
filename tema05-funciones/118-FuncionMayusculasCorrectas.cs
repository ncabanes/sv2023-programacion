/*118. Crea una función llamada "MayusculasCorrectas", que recibirá una cadena
 * como parámetro y la devolverá en minúsculas excepto por la primera letra y 
 * las que están precedidas por un punto (y quizá algún espacio en blanco), 
 * que se convertirán a mayúsculas. 
 * Por ejemplo, para el texto "hOLa.que . tal" debería devolver "Hola.Que . Tal".
*/

// Noelia (...)

using System;

class Ejercicio118
{
    static string MayusculasCorrectas(string texto)
    {
        string textoMin = texto.ToLower();

        char[] caracteres = new char[texto.Length];

        for (int i = 0; i < texto.Length; i++)
        {
        
            if (i == 0 || texto[i - 1] == '.' || texto[i - 1] == ' ')
            {
                caracteres[i] = char.ToUpper(texto[i]);
            }
            else
            {
                caracteres[i] = texto[i];
            }
        }
        string resultado = new string(caracteres);

        return resultado;
    }

    static void Main()
    {
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        string mayusCorregidas = MayusculasCorrectas(texto);

        Console.WriteLine(mayusCorregidas);
    }
}

