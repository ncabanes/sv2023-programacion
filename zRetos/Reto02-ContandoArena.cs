/*Contando en la arena Es ampliamente conocido que escribimos los números 
utilizando base 10, en la que expresamos las cantidades utilizando 10 dígitos 
distintos (0…9). El valor de cada uno de ellos depende de la posición que ocupe 
dentro del número, pues cada dígito se multiplica por una potencia de 10 
distinta según cuál sea esa posición. La descomposición, por ejemplo, del 
número 1.234 es:

1.234 = 1×103 + 2×102 + 3×101 + 4×100

Otra base muy conocida es la base 2 al ser la utilizada por los dispositivos 
electrónicos. En ella sólo hay dos dígitos distintos (0 y 1), que se ven 
multiplicados por potencias de 2.

Mucho antes de que llegaran la base 2, la base 10 e incluso los números 
romanos, los primeros seres humanos contaban haciendo surcos en la arena, 
muescas en un trozo de madera o colocando palos en línea. Estaban, sin saberlo, 
usando base 1. En ella sólo hay un símbolo y cada dígito es multiplicado por 
una potencia de 1. Dado que 1n = 1 el resultado es que todos los dígitos tienen 
el mismo peso.

Entrada La entrada estará compuesta por distintos números mayores que 0 y que 
nunca serán mayores que 1.000, cada uno en una línea.

La entrada termina con un 0, que no debe procesarse.

Salida Para cada número se debe escribir, en una línea independiente, su 
codificación en base 1.

Entrada de ejemplo
1
4
6
0
Salida de ejemplo
 
1 1111 111111 (Nota: original en 
https://www.aceptaelreto.com/problem/statement.php?id=369. Esta web admite 
entrega de fuentes para comprobar si son correctos... pero sólo en Java, C++ y 
C, no en C#).*/

using System;
class Arena
{
    static void Main ()
    {
        int n;
        do
        {
            n = Convert.ToInt32 (Console.ReadLine());
            if ( n != 0 )
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
        }
        while ( n != 0 );
    }
}
