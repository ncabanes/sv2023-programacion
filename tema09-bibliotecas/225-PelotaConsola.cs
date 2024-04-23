/*
 225. Crea un programa que muestre la hora actual en la esquina superior derecha
de la consola, en color amarillo, con fondo azul oscuro, actualizando cada segundo,
mientras una "pelota" (una letra O) de color rojo rebota en la pantalla. 
La pelota comenzará en unas coordenadas al azar de la pantalla. 
Debe detenerse cuando el usuario pulse Intro.
julio
 */

using System;
using System.Threading;

class PelotaRebota
{
    static void Main()
    {
        char pelota = 'O';
        int direccionX = 1;
        int direccionY = -1;

        Random rnd = new Random();
        int x = rnd.Next(1, 121);
        int y = rnd.Next(1, 30);

        //Console.WriteLine(Console.BufferWidth);
        //Console.WriteLine(Console.BufferHeight);

        bool salir = false;

        while (!salir)
        {
            Console.Clear();

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(pelota);
            
            DateTime fechaActual = DateTime.Now;
            Console.SetCursorPosition(110, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(fechaActual);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Thread.Sleep(20);

            x += direccionX;
            if (x <= 0 || x >= Console.BufferWidth - 1)
            {
                direccionX *= -1;
            }
            
            y += direccionY;
            if (y <= 0 || y >= Console.BufferHeight - 1)
            {
                direccionY *= -1;
            }

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                salir = true;
        }
    }
}
