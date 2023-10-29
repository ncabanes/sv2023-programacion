/*59. Crea un programa que calcule las soluciones ("raíces", x1 y x2) de una 
 * ecuación de segundo grado, y = Ax2 + Bx + C, a partir de los valores de A, B y C.
 * Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x). 
 * (si no recuerdas la fórmula, puedes verla en la Wikipedia) 
 * https://es.wikipedia.org/wiki/Ecuaci%C3%B3n_de_segundo_grado#Soluciones_de_la_ecuaci%C3%B3n_de_segundo_grado
*/

// Noelia(...)


using System;

class Ejercicio059
{
    static void Main()
    {
        int a, b, c;
        double x1, x2;

        Console.Write("Valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Valor de b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Valor de c: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        double raiz = b * b - 4 * a * c;

        if (raiz < 0) //si da negativo no tiene solucion real
        {
            Console.WriteLine("no tiene solución real");
        }
        
        else
        {
            x1 = (-b + Math.Sqrt(raiz)) / (2 * a);
            x2 = (-b - Math.Sqrt(raiz)) / (2 * a);
            
            if (raiz > 0 ) //si es mayor que 0 da dos resultados
            {
                Console.WriteLine("x1 = {0}", x1.ToString("N2"));
                Console.WriteLine("x2 = {0}", x2.ToString("N2"));
            }
            else  //si es igual a 0, x1 y x2 valen los mismo
            {
                Console.WriteLine("x1 = x2 = {0}", x1.ToString("N2"));
            }
        }
    }
}



