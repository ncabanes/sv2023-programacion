/*
104. Crea una función llamada "MayusculasAlternas", que recibirá una cadena 
como parámetro y devolverá otra cadena que tendrá en mayúsculas las letras en 
la primera, tercera y resto de posiciones impares (contando desde 1) y en 
minúsculas las que están en posiciones pares (segunda, cuarta y sucesivas). Por 
ejemplo, a partir de "eJEmplo" debería devolver "EjEmPlO". Pruébala desde Main.
*/
// Mario (...)

using System;
using System.Text;

class Ejercicio104
{
    static string MayusculasAlternas (string texto)
    {
        string mayus = texto.ToUpper();
        string minus = texto.ToLower();
        
        StringBuilder mayusDividido = new StringBuilder(mayus);
        StringBuilder minusDividido = new StringBuilder(minus);
        StringBuilder textoDividido = new StringBuilder(texto);
        
        for (int i=0; i<texto.Length; i+=2)
        {
            textoDividido[i] = mayusDividido[i];
        }
        
        for (int i=1; i<texto.Length; i+=2)
        {
            textoDividido[i] = minusDividido[i];
        }
        
        string textoUnido = textoDividido.ToString();
        
        return textoUnido;
    }
    
    static void Main()
    {
        Console.Write("Introduzca una palabra: ");
        string palabra = Console.ReadLine();
        
        Console.WriteLine(MayusculasAlternas(palabra));
    }
}
