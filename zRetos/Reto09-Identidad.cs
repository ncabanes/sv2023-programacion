/*
 �Es matriz identidad?

Se dice que una matriz es identidad cuando todos sus elementos son cero 
a excepci�n de la diagonal principal, que se encuentra rellena de unos:

I3 = [
100
010
001
]

Para que una matriz sea identidad debe de ser cuadrada, es decir, tener 
el mismo n�mero de filas que de columnas.

Entrada

La entrada consta de una serie de casos de prueba. Cada uno comienza 
con un n�mero que representa el n�mero de filas, como m�ximo 50, de una 
matriz cuadrada. Tras �l, aparecen los elementos que forman la matriz, 
que ser�n valores entre -1.000 y 1.000 (inclu�dos).

La entrada terminar� con una matriz de 0 filas.

Salida

Para cada caso de prueba se indicar� SI si la matriz es identidad y NO 
en caso contrario.

Entrada de ejemplo

3
1 0 0
0 1 0
0 0 1
2
0 1
1 0
5
1 0 0 0 0
0 5 0 0 0
0 0 1 0 0
0 0 0 1 0
0 0 0 0 1
0

Salida de ejemplo

SI
NO
NO
*/

// Julio, retoques menores por Nacho

using System;

class MatrizIdentidad
{
    static void Main()
    {
        int tamanyo;
        string[] valores;

        do
        {
            bool esIdentidad = true;
            tamanyo = Convert.ToInt32(Console.ReadLine());
            int[,] datos = new int[tamanyo, tamanyo];

            for (int fila = 0; fila < tamanyo; fila++)
            {
                valores = Console.ReadLine().Split(' ');

                for (int columna = 0; columna < tamanyo; columna++)
                {
                    datos[fila, columna] = Convert.ToInt32(valores[columna]);
                }
            }            
            
            for (int fila = 0; fila < tamanyo; fila++)
            {
                for (int columna = 0; columna < tamanyo; columna++)
                {
                    if ((columna == fila && datos[columna, fila] != 1) 
                        || (columna != fila && datos[columna, fila] != 0))
                    {
                        esIdentidad = false;
                    }
                }
            }

            if (tamanyo != 0)
            {
                if (esIdentidad)
                {
                    Console.WriteLine("SI");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        } while (tamanyo != 0);
    }
}
