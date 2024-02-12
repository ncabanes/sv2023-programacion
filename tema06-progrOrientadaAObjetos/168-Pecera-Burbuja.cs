/* 168. A partir de la última versión "oficial" del simulador de pecera
(ejercicio 157), realiza los siguientes cambios:

Existirá una clase base "SpriteTexto", abstracta, con un método Dibujar
y un método Mover, ambos abstractos. De ella heredará la clase Pez.

En la clase Pez, el método Nada pasará a llamarse Mover.

Existirá una nueva clase "Burbuja", sellada, que también heredará de
"SpriteTexto". Una burbuja tendrá como "imagen" una letra O y se moverá
hacia arriba (hasta llegar a la parte superior de la pantalla, momento
en el que volverá a aparecer por debajo).

Añade dos burbujas al simulador.
*/

using System;
using System.Threading;

// ---------------

abstract class SpriteTexto
{
    protected byte x, y, velocidad;

    public int GetX() { return Convert.ToInt32(x); }
    public int GetY() { return Convert.ToInt32(y); }

    public void SetX(int x) { this.x = (byte)x; }
    public void SetY(int y) { this.y = (byte)y; }

    public abstract void Dibujar();
    public abstract void Mover();
}
// ---------------

class Pez : SpriteTexto
{
    protected string nombre, especie, imagenDerecha, imagenIzquierda;
    protected bool haciaLaDerecha;

    public string GetNombre() { return nombre; }
    public string GetEspecie() { return especie; }

    public void SetNombre(string nombre) { this.nombre = nombre; }
    public void SetEspecie(string especie) { this.especie = especie; }



    public Pez(string nombre, string especie, int x, int y)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.x = (byte)x;
        this.y = (byte)y;
        haciaLaDerecha = true;
        imagenDerecha = "><(((º>";
        imagenIzquierda = "<º)))><";
        velocidad = 1;
    }

    public Pez(int x, int y) : this("", "", x, y) { }

    public Pez(string imagenDerecha, string imagenIzquierda, byte velocidad) :
        this("", "", 20, 8)
    {
        this.imagenDerecha = imagenDerecha;
        this.imagenIzquierda = imagenIzquierda;
        this.velocidad = velocidad;
    }

    public override void Mover()
    {
        if (haciaLaDerecha)
        {
            x += velocidad;
            if (x > 50) haciaLaDerecha = false;
        }
        else
        {
            x -= velocidad;
            if (x < 10) haciaLaDerecha = true;
        }
    }

    public override void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        if (haciaLaDerecha) Console.Write(imagenDerecha);
        else Console.Write(imagenIzquierda);
    }
}

// ---------------

class PezMenor : Pez
{
    public PezMenor(string nombre, string especie, int x, int y) :
        base(nombre, especie, x, y)
    {
        imagenDerecha = "><=>";
        imagenIzquierda = "<=><";
    }

    public PezMenor(int x, int y) : this("", "", x, y) { }
}


// ---------------

class PezMasGrande : Pez
{
    public PezMasGrande(string nombre, string especie, int x, int y) :
        base(nombre, especie, x, y)
    {
        imagenDerecha = "></////////]º>";
        imagenIzquierda = "<º[\\\\\\\\\\\\\\><";
    }

    public PezMasGrande(int x, int y) : this("", "", x, y) { }
}

// ---------------

class Burbuja : SpriteTexto
{
    public Burbuja(int x, int y)
    {
        this.x = (byte)x;
        this.y = (byte)y;
        velocidad = 1;
    }
    public override void Mover()
    {
        y -= velocidad;
        if (y <= 2) y = 20;
    }

    public override void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("o");
    }
}

// ---------------

    class SimuladorDePecera
{
    static void Main()
    {
        SpriteTexto[] elementosPecera = new SpriteTexto[6];
        elementosPecera[0] = new Pez(15, 15);
        elementosPecera[1] = new PezMenor(5, 5);
        elementosPecera[2] = new PezMasGrande(20, 10);
        elementosPecera[3] = new Pez("><>", "<><", 2);
        elementosPecera[4] = new Burbuja(10,20);
        elementosPecera[5] = new Burbuja(50,10);


        bool salir = false;
        do
        {
            // Dibujado de pantalla
            Console.Clear();
            foreach (SpriteTexto p in elementosPecera)
                p.Dibujar();

            // Comprobación de teclas
            Thread.Sleep(100);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape)
                    salir = true;
            }
            // Movimiento de elementos
            foreach (SpriteTexto p in elementosPecera)
                p.Mover();
        }
        while (!salir);
    }
}
