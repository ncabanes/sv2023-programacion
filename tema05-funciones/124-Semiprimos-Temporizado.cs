/* Diana (...)
 * 
 * 124. Crea una función llamada "EsPrimo( n )", que devolverá true si 
 * el parámetro (un número entero largo) es un número primo, o false en 
 * caso contrario. Crea una nueva función 
 * "BuscarYMostrarSemiprimos(desde, hasta);", que llame a la función 
 * "EsPrimo( n )" (puedes ayudarte, si lo deseas, de una funcion más, 
 * llamada "EsSemiprimo( n )") y que muestre qué números hay entre dos 
 * números dados (inclusive) que sean "semiprimos" (o "biprimos": 
 * producto de dos números primos no necesariamente distintos). 
 * Por ejemplo, para los números 10 y 20, la respuesta sería 10 14 15. 
 * Ayudándote de esa función "BuscarYMostrarSemiprimos(desde, hasta);", 
 * crea un programa que pida al usuario dos números enteros largos y 
 * muestre qué semiprimos hay entre ellos. Si el resultado te parece 
 * lento con números grandes, puedes usar el siguiente fragmento de 
 * código para medir tiempos y así poder comprobar el resultado de las 
 * mejoras que se te ocurran:
 * DateTime comienzo = DateTime.Now;
 * BuscarYMostrarSemiprimos(numero1,numero2);
 * Console.WriteLine("Tiempo transcurrido: "+ (DateTime.Now-comienzo));
 * Empieza por ver el efecto de tus mejoras al buscar números pequeños 
 * (del 1 al 50, luego del 100 al 200, después del 2000 al 2500, y así 
 * sucesivamente). Como resultado final, sería deseable conseguir que 
 * localice los números semiprimos que hay entre 1 y 9000 en menos de 
 * un segundo. Algunas de las mejoras que puedes aplicar son:
 * A la hora de comprobar si un número es primo, ¿es necesario llegar 
 * hasta n?  ¿se podría limitar la búsqueda a n/2?  ¿y a raíz( n )?
 * A la hora de probar posibles divisores para ver si un número es primo, 
 * ¿necesitas probar todos los números pares?
 * ¿Se puede interrumpir la comprobación de si es primo antes de contar 
 * todos los divisores?
 */
 
using System;

public class Ejer124
{
    public static long PedirNum()
    {
        return Convert.ToInt64(Console.ReadLine());
    }
    
    public static bool EsPrimo(long n)
    {
        bool primo=true;
        if(n==1 || (n>2 && n%2==0))
        {
            primo=false;
        }
        else
        {
            long divisor=3;
            while(primo && divisor<=n/2)
            {
                if(n%divisor==0)
                {
                    primo=false;
                }
                divisor+=2;
            }
        }
        return primo;
    }
    
    public static bool EsSemiprimo(long n)
    {
        bool semiprimo=false;
        long divisor=2;
        while(divisor<=n/2)
        {
            if(n%divisor==0 && EsPrimo(divisor) && EsPrimo(n/divisor))
            {
                semiprimo=true;
                divisor=n/2; //al salir se le suma 1 y sale del bucle
            }
            divisor++;
        }
        return semiprimo;
    }
    
    public static void OrdenarMenorMayor(ref long numero1, ref long numero2)
    {
        long temporal;
        if(numero1>numero2)
        {
            temporal=numero1;
            numero1=numero2;
            numero2=temporal;
        }
    }
    
    public static void BuscarYMostrarSemiprimos(long numDesde, long numHasta)
    {
        for(long i=numDesde;i<=numHasta;i++)
        {
            if(EsSemiprimo(i))
            {
                Console.Write("{0} ",i);
            }
        }
    }
    
    public static void Main()
    {
        long num1,num2;
        Console.Write("Escribe dos números: ");
        num1=PedirNum();
        num2=PedirNum();
        OrdenarMenorMayor(ref num1, ref num2);
        
        DateTime comienzo = DateTime.Now;
        BuscarYMostrarSemiprimos(num1,num2);
        Console.WriteLine("Tiempo transcurrido: "+
                (DateTime.Now-comienzo));
        //entre 1 y 9000 tarda 0,7 s
    }
}
