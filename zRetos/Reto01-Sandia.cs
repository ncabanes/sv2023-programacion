/*La sandía Un caluroso día de verano, Pete y su amigo Billy decidieron comprar 
una sandía. Escogieron la más grande y la más madura, en su opinión. Después de 
eso, se pesó la sandía y las báscula mostraba W kilos. Fueron corriendo a casa, 
muertos de sed, y decidieron dividir la sandía, pero se encontraron con un 
problema difícil.

A Pete y Billy les encantan los números pares. Por eso, quieren dividir la 
sandía de tal manera que cada una de las dos partes pese un número par de 
kilos, pero no es obligatorio que las partes sean iguales. Los niños están 
extremadamente cansados ​​y quieren comenzar su comida lo antes posible, así 
que debes ayudarles y averiguar si pueden dividir la sandía de la manera que 
quieren. Por supuesto, cada uno de ellos debe obtener una parte que tenga peso 
positivo.

Entrada La primera (y la única) línea de entrada contiene un número entero W (1 
≤ W ≤ 100): el peso de la sandía que compraron los niños.

Salida Escribe YES, si los niños pueden dividir la sandía en dos partes, cada 
una de las cuales pese una cantidad de kilos par; y NO en el caso opuesto.

Ejemplos
entrada

8

salida

YES

Nota: Por ejemplo, pueden dividir la sandía en dos partes de 2 y 6 kilos 
respectivamente (otra alternativa sería hacer dos partes de 4 y 4 kilos).

Origen: http://codeforces.com/problemset/problem/4/A   */

// Miguel Ángel (...)

using System;

class sandia
{
    static void Main()
    {
        byte peso = Convert.ToByte(Console.ReadLine());
        
        if (peso > 2 && peso % 2 == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
    
}
