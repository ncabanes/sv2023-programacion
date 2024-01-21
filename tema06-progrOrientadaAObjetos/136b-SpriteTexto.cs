/* Crea una nueva versión de la clase "SpriteTexto" (ejercicio 127), 
con un constructor que permita asignar valores a sus tres atributos. 
Adapta el programa de prueba para que use ese constructor.*/

// Iván (...)

using System;

class SpriteTexto
{
    private int x, y;
    private char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetCaracter() { return caracter; }

    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }

    public SpriteTexto(int nuevaX, int nuevaY, char nuevoCaracter)
    { 
        x = nuevaX; 
        y = nuevaY;
        caracter = nuevoCaracter;
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

// ----------------------

class PruebadeSprite
{
    static void Main()
    {
        SpriteTexto nave = new SpriteTexto(40, 12, 'A');

        nave.MoverDerecha();
        nave.Dibujar();
    }
}
