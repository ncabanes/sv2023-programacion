// Muestra un rectángulo hueco, con el ancho y el alto que elija el 
// usuario, y usando como símbolo el número que escoja el usuario, como
// en este ejemplo:
// 
// Ancho? 4
// Alto? 3
// Número? 2
// 2222
// 2  2
// 2222
// 
// Eric (...), retoques por Nacho

using System;

class RectanguloHuecoVersion1
{
    static void Main()
    {
        int ancho, alto, simbolo;
        
        Console.Write("Ancho? ");
        ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Alto? ");
        alto = Convert.ToInt32(Console.ReadLine());
        Console.Write("Número? ");
        simbolo = Convert.ToInt32(Console.ReadLine());

        for(int fila = 1; fila <= alto; fila++)
        {
            for(int columna = 1; columna <= ancho; columna++)
            {
                if (fila == 1 || fila == alto 
                    || columna == 1 || columna == ancho) 
                { 
                    Console.Write(simbolo);
                }
                else 
                { 
                    Console.Write(" "); 
                }
            }
            Console.WriteLine();
        }
    }
}
