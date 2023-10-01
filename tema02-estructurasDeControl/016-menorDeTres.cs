// 16. Pide tres números y di cuál es el menor de ellos. Por ejemplo, si 
// introduce 4, 6 y 4, la respuesta deberá ser 4. Como puedes observar, deberá 
// comportarse correctamente si hay datos repetidos.

// Mario (...)

using System;

class MenorEntre3
{
    static void Main()
    {
        int n1, n2, n3;
        
        Console.WriteLine("Vamos a comparar 3 números");
        Console.WriteLine("Introduce el primer número");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el tercer número");
        n3 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("El menor es: ");
        if ((n1<=n2) && (n1<=n3))
        {
            Console.WriteLine(n1);
        }
        else
        {
            if (n2<=n3)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n3);
            }
        }
    }
}
