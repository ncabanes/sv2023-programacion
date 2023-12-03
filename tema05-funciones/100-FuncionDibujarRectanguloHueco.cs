/* 100. Crea un procedimiento (funci�n "void") llamado 
"DibujarRectanguloHueco", que mostrar� un rect�ngulo hueco con el ancho, el 
alto y el car�cter que se indiquen como par�metros. A�ade un "Main" de prueba.

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
