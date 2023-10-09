/*
22. Pide al usuario un número, que guardarás en una variable "numero". 
Dale a una variable llamada "impar" el valor 1 si "numero" es impar, o 
un valor 0 si es par. Hazlo de dos formas, como parte de un mismo 
programa: primero con "if" y luego con el operador ternario. Al igual 
que en el ejercicio anterior, tu programa pedirá el dato una única vez 
y mostrará la respuesta dos veces (una vez con "if" y otra vez con el 
"operador ternario"). Recuerda que para saber si es par o impar, puedes 
mirar el resto de su división entre 2.
*/

// Francisco Javier (...); retoques por Nacho

using System;

class Ejercicio22
{
    public static void Main(string[] args)
    {
        int numero, impar;
        
        Console.Write("Dime un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        // Con "if"

        if(numero % 2 == 0)
        {
            impar = 0;
        }
        else
        {
            impar = 1;
        }
        Console.WriteLine("Impar (if): {0}", impar);

        // Con el ternario

        impar = numero % 2 == 0 ? 0 : 1;
        Console.WriteLine("Impar (ternario): {0}", impar);
    }
}
