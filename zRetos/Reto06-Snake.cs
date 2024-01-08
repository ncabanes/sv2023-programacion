/*
Snake
Snake, conocido delincuente que aparece en la serie de los Simpson, ha decidido 
reformarse y montar una tienda de tatuajes. En su visión de empresario, ha 
decidido que esa tienda solo realizará tatuajes en forma de serpiente siguiendo 
un patrón dado.

Para formar ese patrón, se utilizan dos números enteros M y N (siendo M un 
numero impar), donde a lo largo de M líneas: En la primera línea se dibujarán N 
caracteres '#'. En la segunda línea se dibujarán N-1 caracteres '.' y el último 
será un carácter '#'. En la tercera línea se dibujarán N caracteres '#'. En la 
cuarta línea se dibujará un carácter '#' y tras ello N-1 caracteres '.'. ..... 
y así sucesivamente.

Por ejemplo, para valores 3 3 el dibujo obtenido será

###
..#
###


Snake quiere realizar un programa de ordenador que simule sus tatuajes para 
poder enseñárselos a los clientes antes de hacérselos.

Entrada

En primer lugar, un valor C indicando el número de casos de prueba. Por cada 
caso de prueba: Una línea con dos números M y N, siendo M impar.

1 <= M;N <= 100

Salida

Por cada caso de prueba se mostrará el texto Çaso N", donde N será el número de 
caso comenzando por 1, y seguidamente un dibujo con la simulación del tatuaje.

Ejemplo de entrada

4
3 3
3 4
5 3
9 9


Ejemplo de salida, para esa entrada

Caso 1
###
..#
###
Caso 2
####
...#
####
Caso 3
###
..#
###
#..
###
Caso 4
#########
........#
#########
#........
#########
........#
#########
#........
#########
*/

// Mario (...)

using System;

class Reto06Snake
{
    static void Main()
    {
        int c = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            string[] snake = Console.ReadLine().Split();
            byte snakeFila = Convert.ToByte(snake[0]);
            byte snakeCol = Convert.ToByte(snake[1]);
            
            Console.WriteLine("Caso " + (i + 1));
            for (byte fila = 0; fila < snakeFila; fila++)
            {
                if ((fila + 1) % 2 != 0)
                {
                    for (int col = 0; col < snakeCol; col++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                else
                {
                    if ((fila + 1) % 4 != 0)
                    {
                        for (int col = 0; col < (snakeCol - 1); col++)
                        {
                            Console.Write(".");
                        }
                        Console.WriteLine("#");
                    }
                    else
                    {
                        Console.Write("#");
                        for (int col = 0; col < (snakeCol - 1); col++)
                        {
                            Console.Write(".");
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
