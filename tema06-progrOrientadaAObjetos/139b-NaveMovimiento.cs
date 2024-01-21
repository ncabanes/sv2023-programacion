/* A partir de las clases "NaveEnemiga" y "NaveJugador", crea un 
programa que permita mover la nave del jugador cuando se pulsen las 
flechas del teclado, para lo que te puedes ayudar del siguiente 
fragmento de código:

ConsoleKeyInfo tecla = Console.ReadKey();
if (tecla.Key == ConsoleKey.LeftArrow)
    n.MoverIzquierda();
else if (tecla.Key == ConsoleKey.RightArrow)
    n.MoverDerecha();
else if (tecla.Key == ConsoleKey.Escape)
    salir = true;

Quizá te interese borrar la pantalla con Console.Clear(); */

// Iván (...), retoques menores por Nacho

using System;

class SpriteTexto
{
    protected int x, y;
    protected char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetCaracter() { return caracter; }

    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }

    public SpriteTexto() {}
    public SpriteTexto(int xInicial, int yInicial, char caracterInicial)
    { 
        x = xInicial; 
        y = yInicial;
        caracter = caracterInicial;
    }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(caracter);
    }

    public void MoverDerecha()
    {
        x++;
    }

    public void MoverIzquierda()
    {
        x--;
    }
}

// ------------------

class SpriteTextoColor : SpriteTexto
{
    protected string color;

    public SpriteTextoColor() {}
    public SpriteTextoColor (
        int xInicial, int yInicial, char caracterInicial, 
        string colorInicial)
    {
        x = xInicial; 
        y = yInicial;
        caracter = caracterInicial;
        color = CambiarColor(colorInicial);
    }

    public string CambiarColor(string color)
    {
        if (color == "amarillo")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        if (color == "blanco")
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        if (color == "cyan")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        
        return color;
    }
}

// ------------------

class NaveEnemiga : SpriteTextoColor
{
    public NaveEnemiga(int xInicial, int yInicial) 
    {
        x = xInicial; 
        y = yInicial;
        color = CambiarColor("cyan");
        caracter = 'W';
    }
}

// ------------------

class NaveJugador : SpriteTextoColor
{
    public NaveJugador(int xInicial, int yInicial)
    {
        x = xInicial; 
        y = yInicial;
        color = CambiarColor("amarillo");
        caracter = 'A';
    }
}

// ------------------


class PruebaDeSprite
{
    static void Main()
    {
        bool salir = false;

        ConsoleColor originalColor = Console.ForegroundColor;

        NaveEnemiga ne = new NaveEnemiga(10, 5);
        NaveJugador nj = new NaveJugador(20, 20);

        while (!salir)
        {
            // Dibujamos elementos
            Console.Clear();
            ne.Dibujar();
            nj.Dibujar();

            // Y comprobamos teclas
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                nj.MoverIzquierda();
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                nj.MoverDerecha();
            }
            else if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
        }
        Console.ForegroundColor = originalColor;
    }
}
