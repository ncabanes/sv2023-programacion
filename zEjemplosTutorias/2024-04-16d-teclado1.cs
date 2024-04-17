/*
Muestra una letra X en pantalla, que se pueda mover 
hacia izquierda y derecha con las flechas del cursor.
*/

using System;

class Prueba
{ 
    static void Main()
    {
        int x = 20;
        bool terminado = false;
        do
        {
            Console.Clear();
            Console.SetCursorPosition(x, 10);
            Console.Write("X");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.RightArrow)
                x++;
            if (tecla.Key == ConsoleKey.LeftArrow)
                x--;
            if (tecla.Key == ConsoleKey.Escape)
                terminado = true;
        }
        while (!terminado);
    }
}

