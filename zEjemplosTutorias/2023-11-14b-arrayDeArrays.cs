// Pide al usuario 2 bloques de enteros, 
// cada uno con el tamaño que él/ella elija.
// Luego muestra el máximo del segundo bloque.

using System;

class ArrayDeArrays
{
    static void Main() 
    {
        int[][] datos = new int[2][];
        
        Console.Write("Datos del primer grupo? ");
        int cantidad1 = Convert.ToInt32( Console.ReadLine() );
        datos[0] = new int[cantidad1];
        
        Console.Write("Datos del segundo grupo? ");
        int cantidad2 = Convert.ToInt32( Console.ReadLine() );
        datos[1] = new int[cantidad2];
        
        for(int fila = 0; fila < datos.Length; fila ++)
            for(int columna = 0; columna < datos[fila].Length; columna++)
            {
                Console.Write("Dime el dato, fila {0}, col {1}: ",
                    fila+1, columna+1);
                datos[fila][columna] = Convert.ToInt32( Console.ReadLine() );
            }
            
        int maximo = datos[1][0];
        for (int i = 1; i < datos[1].Length; i++)
        {
            if (datos[1][i] > maximo)
                maximo = datos[1][i];
        }
        Console.WriteLine("Maximo de 2ª fila: " + maximo);
    }
}

/*
Datos del primer grupo? 2
Datos del segundo grupo? 4
Dime el dato, fila 1, col 1: 6
Dime el dato, fila 1, col 2: 7
Dime el dato, fila 2, col 1: 1
Dime el dato, fila 2, col 2: 2
Dime el dato, fila 2, col 3: 4
Dime el dato, fila 2, col 4: 3
Maximo de 2ª fila: 4
*/
