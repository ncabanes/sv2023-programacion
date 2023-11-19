/*
81. Crea un programa que pida al usuario 12 números reales de simple precisión, 
los guarde en una matriz bidimensional de 2x6 datos, y luego calcule y muestre 
el promedio de los valores que hay guardados en la primera mitad de la matriz, 
luego el promedio de los valores en la segunda mitad de la matriz y finalmente 
el promedio global.
*/ //Boris (...)

using System;
class E81
{
    static void Main()
    {
        const int columnas = 2, filas = 3;

        float[,] array = new float[columnas, filas];
        float[] suma = new float[2];

        Console.WriteLine("Introduce los valores");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Número {0}.{1}: ", i + 1, j + 1);
                array[i, j] = Convert.ToSingle(Console.ReadLine());
            }
        }

        // Comprobación, no es necesario hacerlo
        /*
        Console.WriteLine("Muestra de valores");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine(); //Salto de línea
        }
        */

        //Console.WriteLine("Suma de valores por columnas");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                suma[i] += array[i, j];
            }
        }
        
        //Console.WriteLine("Suma-1: {0}", suma[0]);
        //Console.WriteLine("Suma-2: {0}", suma[1]);

        Console.WriteLine("Promedio por columnas");
        Console.WriteLine("Promedio-1: {0}", suma[0] / filas);
        Console.WriteLine("Promedio-2: {0}", suma[1] / filas);
        //Console.WriteLine("Suma general: {0}", (suma[0] + suma[1]));
        Console.WriteLine("Promedio general: {0}", 
            (suma[0] + suma[1])/(columnas * filas));
    }
}
