/*

104. Crea una función llamada "MayusculasAlternas",
que recibirá una cadena como parámetro y 
devolverá otra cadena que tendrá en mayúsculas las letras en la primera,
tercera y resto de posiciones impares (contando desde 1) y en minúsculas
las que están en posiciones pares (segunda, cuarta y sucesivas). 
Por ejemplo, a partir de "eJEmplo" debería devolver "EjEmPlO". Pruébala desde Main.

 Julio
 */

using System;

class Funcion07
{
    public static string MayusculasAlternas(string cadena)
    {
        string nuevaCadena = "";

        for (int i = 0; i < cadena.Length; i++)
        {
            if (i % 2 == 0)
                nuevaCadena += cadena[i].ToString().ToUpper();

            else
                nuevaCadena += cadena[i].ToString().ToLower();
        }
        return nuevaCadena;
    }

    public static void Main()
    {
        string cadena = "eJEmplo";
        Console.WriteLine(MayusculasAlternas(cadena));
    }
}