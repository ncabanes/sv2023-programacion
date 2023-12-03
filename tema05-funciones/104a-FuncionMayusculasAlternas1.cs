/*104. Crea una función llamada "MayusculasAlternas", que recibirá una cadena 
como parámetro y devolverá otra cadena que tendrá en mayúsculas las letras en 
la primera, tercera y resto de posiciones impares (contando desde 1) y en 
minúsculas las que están en posiciones pares (segunda, cuarta y sucesivas). Por 
ejemplo, a partir de "eJEmplo" debería devolver "EjEmPlO". Pruébala desde 
Main.*/

// Miguel Ángel (...)

using System;

class funcionMayusculasAlternas
{
    static string MayusculasAlternas(string cadena)
    {
        string cadenaAlterna = "";
        
        for (int i = 0; i < cadena.Length; i ++)
        {
            if (i % 2 == 0)
            {
                cadenaAlterna += Convert.ToString(cadena[i]).ToUpper();
            }
            else
            {
                cadenaAlterna += Convert.ToString(cadena[i]).ToLower();
            }
        }
        return cadenaAlterna;
    }
    
    static void Main()
    {
        string cadenaMayAlt;
        
        Console.Write("Dame una cadena de texto: ");
        cadenaMayAlt = MayusculasAlternas(Console.ReadLine());
        
        Console.WriteLine(cadenaMayAlt);
    }
}


