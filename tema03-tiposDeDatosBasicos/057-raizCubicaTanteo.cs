/* 57. Partiendo de la idea del ejercicio 45 y empleando números reales, 
 * vamos a tantear raíces cúbicas: Pide un número real al usuario y 
 * calcula su raíz cúbica con una cifra decimal, por aproximación, 
 * tanteando los valores que sea necesario. Por ejemplo, para el número 
 * 27, la respuesta debería ser 3 (exacta), mientras que para el número 
 * 35 la respuesta debería ser 3,2 (porque la respuesta "correcta" 
 * es mayor que 3,2 pero menor que 3,3).
 * */

// Juan Luis (...), retoques por Nacho

using System;

class Ejercicio57
{
    static void Main ()
    {
        double numero, i=0, raiz, limiteInferior, limiteSuperior;
        
        Console.Write("Dime un número: ");
        numero = Convert.ToDouble(Console.ReadLine());
        limiteInferior = numero-0.001;
        limiteSuperior = numero+0.001;
        
        do
        {
            raiz = i*i*i;
            if (raiz < limiteInferior) 
                i+=0.1;
        }
        while(raiz < limiteInferior);
        
        
        if ((raiz > limiteInferior) && (raiz < limiteSuperior))
        {
            Console.Write("La raíz cúbica de {0} es ", numero);
            Console.Write(i.ToString("0"));
            Console.Write(" (exacta)");
        }
        else
        {
            i-=0.1;
            Console.Write("La raíz cúbica de {0} es ", numero);
            Console.Write(i.ToString("0.0"));
            Console.Write(" (aproximada)");
        }
    }
}
