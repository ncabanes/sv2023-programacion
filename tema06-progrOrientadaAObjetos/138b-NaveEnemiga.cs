/* 138. Crea una clase "NaveEnemiga", que herede de "SpriteTextoColor", 
y cuyo constructor prefije el color a cyan y el carácter a "W". Crea 
una clase "NaveJugador", que herede de "SpriteTextoColor", y cuyo 
constructor prefije el color a amarillo y el carácter a "A". Muestra un 
objeto de cada clase desde "Main". */

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
        ConsoleColor originalColor = Console.ForegroundColor;

        NaveEnemiga ne = new NaveEnemiga(10, 20);
        ne.Dibujar();

        NaveJugador nj = new NaveJugador(20, 10);
        nj.Dibujar();
        
        Console.ForegroundColor = originalColor;
    }
}
