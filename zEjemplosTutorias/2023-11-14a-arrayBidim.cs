// Pide al usuario 2 bloques de 5 enteros. 
// Luego muestra el máximo del segundo bloque.

using System;

class ArrayBidimensional 
{
    static void Main() 
    {
        int[,] datos = new int[2, 5];
        
        for(int fila = 0; fila < datos.GetLength(0); fila ++)
            for(int columna = 0; columna < datos.GetLength(1); columna++)
            {
                Console.Write("Dime el dato, fila {0}, col {1}: ",
                    fila+1, columna+1);
                datos[fila, columna] = Convert.ToInt32( Console.ReadLine() );
            }
            
        int maximo = datos[1,0];
        for (int i = 1; i < datos.GetLength(1); i++)
        {
            if (datos[1,i] > maximo)
                maximo = datos[1,i];
        }
        Console.WriteLine("Maximo de 2ª fila: " + maximo);
    }
}

/*
Dime el dato, fila 1, col 1: 5
Dime el dato, fila 1, col 2: 6
Dime el dato, fila 1, col 3: 7
Dime el dato, fila 1, col 4: 8
Dime el dato, fila 1, col 5: 9
Dime el dato, fila 2, col 1: 1
Dime el dato, fila 2, col 2: 2
Dime el dato, fila 2, col 3: 5
Dime el dato, fila 2, col 4: 3
Dime el dato, fila 2, col 5: 4
Maximo de 2ª fila: 5
*/
