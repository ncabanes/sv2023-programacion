/*
Números reversibles (Acepta el reto 193)
Se denomina número reversible a aquél que al ser sumado a sí mismo tras 
invertir sus dígitos da como resultado un número en el que todos los dígitos 
son impares.

Por ejemplo, el número 36 es reversible pues 36 + 63 = 99, y los dos dígitos de 
99 son impares. Fíjate que esto significa que también el número 63 es 
reversible. También lo son el 409 y el 904.

Para ser considerado número reversible, la cantidad de dígitos del número y de 
su versión invertida debe ser el mismo. Por tanto, el número 1000 no es 
reversible, incluso aunque 1000 + 0001 = 1001. No se considera válido porque 
0001 es en realidad el número 1, que tiene menos dígitos que 1000.

Hay más números reversibles de lo que podría parecer. Por ejemplo, hay 20 de 2 
dígitos, y 100 de 3.

Entrada

La entrada está compuesta de una serie de casos de prueba. Cada uno contendrá 
una línea, con un número positivo menor que 109.

Un caso de prueba con un 0 indica el final, y no deberá procesarse.

Salida

Para cada caso de prueba el programa deberá escribir SI si el número es 
reversible, y NO si no lo es.


Entrada de ejemplo

36
904
1000
37
209
0

Salida de ejemplo

SI
SI
NO
NO
SI

Origen: Acepta el reto, 193 - 
https://www.aceptaelreto.com/problem/statement.php?id=193
*/
// Mario (...)

using System;

class Reto13
{
    static void Main()
    {
        int n;
        do
        {
            n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                Console.WriteLine(Reversible(n));
            }
        }
        while (n != 0);
    }

    static string Reversible(int n)
    {
        string salida = "SI";
        if (n % 10 == 0)
        {
            salida = "NO";
        }
        else
        {
            string nP = n.ToString();
            char[] c = nP.ToCharArray();

            // El resultado de la suma de un número por el mismo invertido será
            // impar si la suma del primer y último digito es impar
            if ((Convert.ToByte(c[0]) + Convert.ToByte(c[c.Length - 1])) % 2 == 0)
            {
                salida = "NO";
            }

            // Otra forma és dandole la vuela a todo el número y sumándolos.
            /*
            string nI = "";
            for (int i = c.Length -1 ; i >= 0; i--)
            {
                nI += c[i];   
            }

            int s = Convert.ToInt32(nI);

            if ((n + s) % 2 == 0)
            {
                salida = "NO";
            }
            */
        }
        return salida;
    }
}
