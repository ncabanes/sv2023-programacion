/* 100. Crea un procedimiento (función "void") llamado 
"DibujarRectanguloHueco", que mostrará un rectángulo hueco con el ancho, el 
alto y el carácter que se indiquen como parámetros. Añade un "Main" de prueba.

Julio, retqoues menores por Nacho
*/

using System;

class Funcion04
{
    static void DibujarRectanguloHueco(int ancho, int alto, char caracter)
    {
        for (int fila = 0; fila < alto; fila++)
        {
            for (int columna = 0; columna < ancho; columna++)
            {
                if (fila == 0 || fila == alto - 1 
                        || columna == 0 || columna == ancho - 1)
                    Console.Write(caracter);

                else
                    Console.Write(" ");

            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int alto = 10;
        int ancho = 6;
        char caracter = '*';
        DibujarRectanguloHueco(ancho, alto, caracter);
    }
}
