/*
60. Pide al usuario un número binario (por ejemplo 1101) y muestra su equivalente en decimal. 
Debes hacerlo de la siguiente forma:  leerás un número entero largo n, 
e irás extrayendo cada vez su última cifra (con "cifra = n % 10") 
y eliminando esa cifra (con "n = n / 10"); si esa cifra es 1, 
deberás sumar la correspondiente potencia de 2 (que será 1 para la primera cifra que elimines, 
luego 2 para la siguiente, después 4, a continuación 8, luego 16 y así sucesivamente, multiplicando por 2 en cada nuevo paso). 

Por ejemplo, el número binario 1101 se descompone en 1*8 + 1*4 + 0*2 + 1*1 = 13 
(pero ten en cuenta que tu programa lo calculará en orden contrario: 1*1, luego 0*2, luego 1*4 y finalmente 1*8).

Finalmente, muestra el equivalente en binario de ese número que has obtenido, 
pero esta vez usando "Convert.ToString(n, 2)" (si todo ha ido bien, debería coincidir con el dato original). 
 
Julio

*/

using System;

class DecimalBinario
{
    public static void Main()
    {
        Console.Write("Dime un número binario: ");
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
