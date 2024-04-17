/*
Mejora el ejercicio anterior, para que además, 
cada segundo se mueva una posición hacia arriba, 
comenzando desde la fila 20.
*/

using System;
using System.Threading;

class Prueba
{ 
    static void Main()
    {
        int x = 20;
        int y = 20;
        bool terminado = false;
        do
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("X");
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.RightArrow)
                    x++;
                if (tecla.Key == ConsoleKey.LeftArrow)
                    x--;
                if (tecla.Key == ConsoleKey.Escape)
                    terminado = true;
            }
            Thread.Sleep(1000);
            y--;
        }
        while (!terminado);
    }
}
