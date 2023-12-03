/*

104. Crea una funci�n llamada "MayusculasAlternas",
que recibir� una cadena como par�metro y 
devolver� otra cadena que tendr� en may�sculas las letras en la primera,
tercera y resto de posiciones impares (contando desde 1) y en min�sculas
las que est�n en posiciones pares (segunda, cuarta y sucesivas). 
Por ejemplo, a partir de "eJEmplo" deber�a devolver "EjEmPlO". Pru�bala desde Main.

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