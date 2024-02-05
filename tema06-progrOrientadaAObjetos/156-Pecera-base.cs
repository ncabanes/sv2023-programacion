/*
156. partir de la "solución oficial" del ejercicio 151 (simuladorDePecera3), 
crea una variante con los siguientes cambios:

- El constructor de PezMenor y el de PezMasGrande usarán "base", para 
reutilizar código en vez de reescribirlo.

- No habrá constructor sin parámetros en Pez.

- Existirá, en las 3 clases, un constructor que sólo reciba dos parámetros (x e 
y), y que se basará en el que recibe 4 parámetros, utilizando "this" y dejando 
vacíos tanto el nombre como la especie.

Comprueba que todo sigue funcionando igual.
*/

// Mario (...)

using System;
using System.Threading;

// ---------------

class Pez
{
    protected string nombre, especie;
    protected byte x, y;
    protected bool haciaLaDerecha;

    public string GetNombre() { return nombre; }
    public string GetEspecie() { return especie; }
    public int GetX() { return Convert.ToInt32(x); }
    public int GetY() { return Convert.ToInt32(y); }

    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetEspecie(string nuevaEspecie) { especie = nuevaEspecie; }
    public void SetX(int nuevaX) { x = (byte)nuevaX; }
    public void SetY(int nuevaY) { y = (byte)nuevaY; }


    public Pez(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY)
    {
        nombre = nuevoNombre;
        especie = nuevaEspecie;
        x = (byte)nuevaX;
        y = (byte)nuevaY;
        haciaLaDerecha = true;
    }

    public Pez(int nuevaX, int nuevaY) : this("", "", nuevaX, nuevaY) { }

    private void NadarDerecha()
    {
        x++;
        if (x > 50)
        {
            haciaLaDerecha = false;
        }
    }

    private void NadarIzquierda()
    {
        x--;
        if (x < 10)
        {
            haciaLaDerecha = true;
        }
    }

    public void Nadar()
    {
        if (haciaLaDerecha) NadarDerecha();
        else NadarIzquierda();
    }

    private void DibujarDerecha()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("><(((º>");
    }

    private void DibujarIzquierda()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("<º)))><");
    }

    public virtual void Dibujar()
    {
        if (haciaLaDerecha) DibujarDerecha();
        else DibujarIzquierda();
    }

    ~Pez()
    {
        Console.Write("Aquí acabó la vida del pez");
    }
}

// ---------------

class PezMenor : Pez
{
    public PezMenor(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY) :
        base (nuevoNombre, nuevaEspecie, nuevaX, nuevaY)
    {
        haciaLaDerecha = true;
    }

    public PezMenor(int nuevaX, int nuevaY) : this("", "", nuevaX, nuevaY) { }

    private void DibujarDerecha()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("><=>");
    }

    private void DibujarIzquierda()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("<=><");
    }

    public override void Dibujar()
    {
        if (haciaLaDerecha) DibujarDerecha();
        else DibujarIzquierda();
    }
}


// ---------------

class PezMasGrande : Pez
{
    public PezMasGrande(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY) :
        base(nuevoNombre, nuevaEspecie, nuevaX, nuevaY)
    {
        haciaLaDerecha = true;
    }

    public PezMasGrande(int nuevaX,int nuevaY) : this ("", "", nuevaX, nuevaY) { }

    private void DibujarDerecha()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("></////////]º>");
    }

    private void DibujarIzquierda()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("<º[\\\\\\\\\\\\\\><");
    }

    public override void Dibujar()
    {
        if (haciaLaDerecha) DibujarDerecha();
        else DibujarIzquierda();
    }
}

// ---------------

class SimuladorDePecera
{
    static void Main()
    {
        Pez[] pez = new Pez[3];
        pez[0] = new Pez("Juan", "sardina", 15, 15);
        pez[1] = new PezMenor("Pepe", "boqueron", 5, 5);
        pez[2] = new PezMasGrande("Er Maquina", "tiguron", 20, 10);


        bool salir = false;
        do
        {
            // Dibujado de pantalla
            Console.Clear();
            pez[0].Dibujar();
            pez[1].Dibujar();
            pez[2].Dibujar();

            // Comprobación de teclas
            Thread.Sleep(100);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape)
                    salir = true;
            }
            // Movimiento de elementos
            pez[0].Nadar();
            pez[1].Nadar();
            pez[2].Nadar();
        }
        while (!salir);
    }
}
