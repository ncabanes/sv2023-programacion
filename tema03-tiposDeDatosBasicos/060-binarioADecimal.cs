/*
60. Pide al usuario un n�mero binario (por ejemplo 1101) y muestra su equivalente en decimal. 
Debes hacerlo de la siguiente forma:  leer�s un n�mero entero largo n, 
e ir�s extrayendo cada vez su �ltima cifra (con "cifra = n % 10") 
y eliminando esa cifra (con "n = n / 10"); si esa cifra es 1, 
deber�s sumar la correspondiente potencia de 2 (que ser� 1 para la primera cifra que elimines, 
luego 2 para la siguiente, despu�s 4, a continuaci�n 8, luego 16 y as� sucesivamente, multiplicando por 2 en cada nuevo paso). 

Por ejemplo, el n�mero binario 1101 se descompone en 1*8 + 1*4 + 0*2 + 1*1 = 13 
(pero ten en cuenta que tu programa lo calcular� en orden contrario: 1*1, luego 0*2, luego 1*4 y finalmente 1*8).

Finalmente, muestra el equivalente en binario de ese n�mero que has obtenido, 
pero esta vez usando "Convert.ToString(n, 2)" (si todo ha ido bien, deber�a coincidir con el dato original). 
 
Julio

*/

using System;

class DecimalBinario
{
    public static void Main()
    {
        Console.Write("Dime un n�mero binario: ");
        long n = Convert.ToInt64(Console.ReadLine());
        long cifra;
        long resultado = 0;
        long multiplicador = 1;

        Console.Write("{0} en decimal es ", n);

        do
        {
            cifra = n % 10;
            n /= 10;

            if (cifra == 1)
            {
                cifra *= multiplicador;
                resultado = cifra + resultado;
            }
            multiplicador *= 2;
        }
        while (n > 0);

        Console.WriteLine("{0}", resultado);
        Console.WriteLine("{0} Convertido a binario es {1}",
            resultado, Convert.ToString(resultado, 2));
    }
}
