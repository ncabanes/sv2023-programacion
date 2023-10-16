/*
38. Muestra un tri�ngulo decreciente 
alineado a la izquierda, con letras X, 
con el tama�o indicado por el usuario, usando "for":
Tama�o? 5

XXXXX
XXXX
XXX
XX
X

Julio (...) , ampliado por Nacho

*/

using System;

class Triangulo
{
    public static void Main()
    {
        Console.Write("Tama�o: ");
        int tamanyo = Convert.ToInt32(Console.ReadLine());

        // Planteamiento 1: cambiando l�mite superior en cada fila
        
        for (int fila = 0; fila < tamanyo; fila++)
        {
            for (int columna = 0; columna < tamanyo-fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        // Planteamiento 2: cambiando l�mite inferior en cada fila
        
        for (int fila = 0; fila < tamanyo; fila++)
        {
            for (int columna = fila; columna < tamanyo; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        // Planteamiento 3: contador adicional, comenzando en 1
        
        int asteriscos = tamanyo;
        for (int fila = 1; fila <= tamanyo; fila++)
        {
            for (int columna = 1; columna <= asteriscos; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            asteriscos--;
        }
    }
}
