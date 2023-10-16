/*Programa para mostrar la tabla de multiplicar
 * con 2 numeros introducidos por el usuario
 * tiene que funcionar incluso si el primer 
 * numero es mayor que el segundo numero
 */
 
//Francisco (...), retoques por Nacho
 
using System;
class TablaDeMultiplicarCon2Numeros
{
    static void Main()

    {
        int n1, n2;
        int desde, hasta;
    
        Console.WriteLine("Introduce el primer numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo numero");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 <= n2)
        {
            desde = n1;
            hasta = n2;
        }
        else
        {
            desde = n2;
            hasta = n1;
        }

        for (int tabla = desde; tabla <= hasta; tabla++) 
        {
            for (int numero = 0; numero <= 10; numero++)            
                Console.WriteLine("{0} X {1} = {2}", 
                    tabla, numero, tabla*numero);
            Console.WriteLine();
        }
    }
}
