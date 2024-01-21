/* 142. Añade herencia y constructores adecuados a las clases de tu esqueleto 
de juego (ejercicio 134). Por ejemplo, clases como "Personaje" o "Enemigo" 
podrían heredar de otra llamada "Sprite" o "ElementoGrafico", así como tener un 
constructor que permita fijar a la vez sus coordenadas X e Y). */

// Julio, retoques por Nacho

using System;

class Bienvenida
{
    public void Mostrar() { }
}

class ElementoGrafico
{
    protected int x;
    protected int y;
    
    public ElementoGrafico() { }
    
    public ElementoGrafico(int nuevaX, int nuevaY)
    {
        x = nuevaX;
        y = nuevaY;
    }
    
    public void Mostrar()
    {
    }
}

class Bloque : ElementoGrafico
{
    private int colorCuadrado1;
    private int colorCuadrado2;
    private int colorCuadrado3;
    
    public Bloque(int nuevaX, int nuevaY,
        int nuevoColor1, int nuevoColor2, int nuevoColor3)
    {
        x = nuevaX;
        y = nuevaY;
        colorCuadrado1 = nuevoColor1;
        colorCuadrado2 = nuevoColor2;
        colorCuadrado3 = nuevoColor3;
    }

    public int GetcolorCuadrado1() { return colorCuadrado1;  }
    public int GetcolorCuadrado2() { return colorCuadrado2; }
    public int GetcolorCuadrado3() { return colorCuadrado3; }

    public void setNuevoColorCuadrado1(int nuevoColor1) { colorCuadrado1 = nuevoColor1; }
    public void setNuevoColorCuadrado2(int nuevoColor2) { colorCuadrado2 = nuevoColor2; }
    public void setNuevoColorCuadrado3(int nuevoColor3) { colorCuadrado3 = nuevoColor3; }

    public void Mover() { }

    public void MoverIzquierda() { x--; }
    public void MoverDerecha() { x++; }
    public void MoverAbajo() { y++; }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("*");

        Console.SetCursorPosition(x, y + 1);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("*");

        Console.SetCursorPosition(x, y + 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("*");

        Console.ForegroundColor = ConsoleColor.White;
    }
}

class Marcador  : ElementoGrafico
{
}

class Nivel  : ElementoGrafico
{
    public void AumentarVelocidad() { }
}

class Pantalla
{
    private int coordenadasX;
    private int coordenadasY;
    
    public Pantalla() { }

    public Pantalla(int nuevaX, int nuevaY) 
    {
        coordenadasX = nuevaX;
        coordenadasY = nuevaY;
    }

    public int GetCoordenadasX() { return coordenadasX; }
    public int GetCoordenadasY() { return coordenadasY; }

    public void SetNuevasCoordenadasX (int nuevaX) { coordenadasX = nuevaX; }
    public void SetNuevasCoordenadasY(int nuevaY) { coordenadasY = nuevaY; }
}

class Partida
{
    public void Lanzar() 
    { 
        Pantalla pantalla = new Pantalla(42,12);
        Marcador marcador= new Marcador();
        Nivel nivel = new Nivel();
        Bloque bloque = new Bloque(10, 8,  1, 2, 3);

        bool salir = false;

        do
        {
            Console.Clear();
            bloque.Dibujar();

            ConsoleKeyInfo tecla = Console.ReadKey();
            

            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                bloque.MoverIzquierda();
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                bloque.MoverDerecha();
            }
            else if (tecla.Key == ConsoleKey.DownArrow)
            {
                bloque.MoverAbajo();
            }
            else if (tecla.Key == ConsoleKey.Escape)
                salir = true;

        }
        while (!salir);
    }
    
    public void Finalizar() { }
}

class Juego
{
    static void Main()
    {
        Bienvenida bienvenida = new Bienvenida();
        bienvenida.Mostrar();

        Partida partida = new Partida();
        partida.Lanzar();
    }
}
