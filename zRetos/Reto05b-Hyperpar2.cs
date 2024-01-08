/* Diana (...), retoques por Nacho
 * 
 * Crea un programa que reciba una serie de números hasta que escriba
 * un número negativo,  * y diga SI si es hyperpar el número 
 * (todos sus dígitos son pares) y NO cuando no sea así.
 * Los números han de ser no negativos y menores o iguales que 10^9I

Entrada de ejemplo

2460
1234
2
-1

Salida de ejemplo, para esa entrada

SI
NO
SI

 */

using System;

public class NumeroHyperpar
{
    public static int PedirNum()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static bool EsHyperpar(int numero)
    {
        bool hiperpar=true;
        int digito;
        while(hiperpar && numero>0)
        {
            digito=numero%10;
            if(digito%2!=0)
            {
                hiperpar=false;
            }
            numero/=10;
        }
        return hiperpar;
    }
    
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

}
