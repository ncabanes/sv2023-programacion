/* 104. Crea una función llamada "MayusculasAlternas", que recibirá una cadena
 * como parámetro y devolverá otra cadena que tendrá en mayúsculas las letras
 * en la primera, tercera y resto de posiciones impares (contando desde 1) y en
 * minúsculas las que están en posiciones pares (segunda, cuarta y sucesivas).
 * Por ejemplo, a partir de "eJEmplo" debería devolver "EjEmPlO". Pruébala desde
 * Main.
 *
 * VICTOR (...) - 1º DAM SEMI */

using System;
using System.Text;

class exercise_05_01_103
{
    static string MayusculasAlternas(string frase)
    {
        StringBuilder fraseModificable = new StringBuilder(frase);
        for(int i=0; i < fraseModificable.Length; i++)
        {
            if(i % 2 == 0)
            {
                fraseModificable[i] = Convert.ToChar(Convert.ToString(
                    fraseModificable[i]).ToUpper());
            }
            else if(i % 2 != 0)
            {
                fraseModificable[i] = Convert.ToChar(Convert.ToString(
                    fraseModificable[i]).ToLower());
            }
        }
        frase = Convert.ToString(fraseModificable);
        return frase;
    }

    static void Main()
    {
        Console.WriteLine(MayusculasAlternas("eJEmplo"));
    }
}
