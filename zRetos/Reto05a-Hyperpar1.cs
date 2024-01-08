/*Número hyperpar Se dice que un número es hyperpar cuando todos sus dígitos 
son pares. ¿Sabes identificarlos?

Entrada

La entrada consta de una serie de casos de prueba. Cada uno está compuesto de 
una única línea con un número no negativo ni mayor que 109.

Los casos de prueba terminan con un número negativo que no habrá que procesar.

Salida

Para cada caso de prueba se escribirá, en una línea independiente, "SI" si el 
número es hyperpar y "NO" si no lo es.

Entrada de ejemplo

2460
1234
2
-1

Salida de ejemplo, para esa entrada

SI
NO
SI
Origen: https://www.aceptaelreto.com/problem/statement.php?id=165*/

// Miguel Ángel (...)

using System;

class numeroHyperpar
{
    static void Main()
    {
        int num = 0;
        
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num > 0)
            {
                if (EsHyperpar(num))
                {
                    Console.WriteLine("SI");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        while (num > 0);
    }
    
    static bool EsHyperpar(int num)
    {
        if (num == 0)
        {
            return true;
        }
        if (num%2 !=0)
        {
            return false;
        }
        return EsHyperpar(num/10);
    }
}
