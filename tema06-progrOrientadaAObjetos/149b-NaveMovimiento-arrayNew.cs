/*
 149. Crea una nueva versión del proyecto de NaveJugador y NaveEnemiga (139) 
en la que haya un array de 5 objetos de tipo SpriteTexto: 4 serán de 
subtipo NaveEnemiga y uno de NaveJugador. Usa "new" en vez de 
"virtual+override" y comprueba si se comporta bien (es previsible que 
no sea así).

Julio, retoques menores por Nacho
 */

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

    public SpriteTexto() { }
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

    public SpriteTextoColor() { }
    public SpriteTextoColor(
        int xInicial, int yInicial, char caracterInicial,
        string colorInicial)
    {
        x = xInicial;
        y = yInicial;
        caracter = caracterInicial;
        color = CambiarColor(colorInicial);
    }
    
    public new void Dibujar()
    {
        CambiarColor(color);
        Console.SetCursorPosition(x, y);
        Console.Write(caracter);
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
        color = "cyan";
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
        color = "amarillo";
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

        SpriteTexto[] spriteNave = new SpriteTexto[5];

        spriteNave[0] = new NaveEnemiga(10, 5);
        spriteNave[1] = new NaveEnemiga(12, 6);
        spriteNave[2] = new NaveEnemiga(15, 18);
        spriteNave[3] = new NaveEnemiga(18, 21);
        spriteNave[4] = new NaveJugador(5, 10);

        while (!salir)
        {
            // Dibujamos elementos
            Console.Clear();

            for (int i = 0; i < spriteNave.Length - 1; i++)
            {
                spriteNave[i].Dibujar();
            }

            spriteNave[4].Dibujar();

            // Y comprobamos teclas
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                spriteNave[4].MoverIzquierda();
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                spriteNave[4].MoverDerecha();
            }
            else if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
        }
        Console.ForegroundColor = originalColor;
    }
}
