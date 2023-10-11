using System;

class TrianguloDerecha
{
    static void Main() 
    {
        int anchura = 6;
        int asteriscos = 1;
        int espacios = anchura-asteriscos;
    
        // Tengo varias filas
        for (int fila = 1; fila <= anchura; fila++)
        {
            // En cada fila, empiezo con varios espacios
            for (int columna = 1; columna <= espacios; columna++)
            {
                Console.Write(" ");
            }
            espacios --;
            
            // Termino con varios asteriscos
            for (int columna = 1; columna <= asteriscos; columna++)
            {
                Console.Write("*");
            }
            asteriscos++;
            
            // Y salto de línea al final de la fila
            Console.WriteLine();
        }
    }
}

/*

     *
    **
   ***
  ****
 *****
******

*/




