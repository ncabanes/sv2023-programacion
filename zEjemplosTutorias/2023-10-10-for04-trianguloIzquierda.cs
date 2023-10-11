using System;

class TrianguloIzquierda 
{
    static void Main() 
    {
        for (int fila = 1; fila <= 4; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

/*

*
**
***
****

*
**
***
****

*/




