/* 151. Crea una nueva versión del ejercicio 141 (Pez y clase 
derivada), en la que al menos 3 peces de distintas clases naden en 
pantalla, formando parte de un mismo array. Recuerda usar "virtual" y 
"override" para que el comportamiento sea correcto.

Puedes mejorarlo para que los peces se muevan solos, una vez cada 100 
milisegundos, en vez de detenerse hasta que se pulse una tecla, si usas 
el fragmento de código:

Thread.Sleep(100);
if (Console.KeyAvailable)
{
    ConsoleKeyInfo tecla = Console.ReadKey();
    if (tecla.Key == ConsoleKey.Escape)
        salir = true;
}
 */

// Eric (...), retoques por Nacho

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
    public void SetX(int nuevaX) { x = (byte) nuevaX; }
    public void SetY(int nuevaY) { y = (byte) nuevaY; }

    public Pez()
    {
        nombre = "Pepe";
        especie = "salmon";
        haciaLaDerecha = true;
    }

    public Pez(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY)
    {
        nombre = nuevoNombre;
        especie = nuevaEspecie;
        x = (byte)nuevaX;
        y = (byte)nuevaY;
        haciaLaDerecha = true;
    }

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
    public PezMenor(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY)
    {
        nombre = nuevoNombre;
        especie = nuevaEspecie;
        x = (byte)nuevaX;
        y = (byte)nuevaY;
        haciaLaDerecha = true;
    }

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
    public PezMasGrande(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY)
    {
        nombre = nuevoNombre;
        especie = nuevaEspecie;
        x = (byte)nuevaX;
        y = (byte)nuevaY;
        haciaLaDerecha = true;
    }

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
