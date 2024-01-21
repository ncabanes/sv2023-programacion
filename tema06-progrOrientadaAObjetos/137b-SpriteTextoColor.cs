/* 137. Crea una clase "SpriteTextoColor", que será un subtipo de 
"SpriteTexto", y tendrá un nuevo atributo llamado "color", de tipo 
"string". En esta primera versión, ese atributo podrá tener los valores 
"blanco" (que cambiará el color del texto haciendo 
"Console.ForegroundColor = ConsoleColor.White;"), "cyan" (que hará 
"Console.ForegroundColor = ConsoleColor.Cyan;") y "amarillo" (que usará 
"Console.ForegroundColor = ConsoleColor.Yellow;"). Añade también un 
constructor a esta clase, que permita fijar, además de los tres 
atributos anteriores, el color. Los atributos de "SpriteTexto" pasarán 
a ser "protected". Pruéba la nueva clase desde Main de modo que 
dibujes, en las coordenadas (30, 8), un carácter "X" en color amarillo.
*/

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

class PruebaDeSprite
{
    static void Main()
    {
        ConsoleColor originalColor = Console.ForegroundColor;

        SpriteTexto nave = new SpriteTexto(40, 12, 'A');

        nave.MoverDerecha();
        nave.Dibujar();

        SpriteTextoColor spt = new SpriteTextoColor(30, 8, 'X', "amarillo");

        spt.Dibujar();

        Console.ForegroundColor = originalColor;
    }
}
