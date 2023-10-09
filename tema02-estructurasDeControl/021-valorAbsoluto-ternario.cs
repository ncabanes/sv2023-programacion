//Escribe un programa que calcule (y muestre)
//el valor absoluto de un número x: si el
//número es positivo (o cero), su valor absoluto es
// exactamente el número x; en caso contrario, su valor
// absoluto es -x. Hazlo de dos maneras diferentes en el mismo
// programa: usando "if" y usando el "operador condicional" u "operador
// ternario" (?). Tu programa pedirá un dato "x" una única vez y
//mostrará la respuesta dos veces (una vez con "if" y otra vez con el
//"operador ternario")

//Javier (...), retoques por Nacho

using System;

class Ejercicio_21
{
    static void Main()
    {
        int x;
        int absoluto;

        Console.WriteLine("Introduzca el numero cuyo valor");
        Console.WriteLine("absoluto deseas conocer");
        x=Convert.ToInt32(Console.ReadLine());
            
        //primero con if

        if (x >= 0)
            absoluto = x;
        else
            absoluto = -x;

        Console.WriteLine("El valor absoluto de {0} es {1}",
            x, absoluto);

        //ahora con el operador ternario

        absoluto = x>=0 ? x : -x;

        Console.Write("El valor absoluto con el operador ternario ");
        Console.WriteLine("de {0} es {1}", x, absoluto);
    }
}
