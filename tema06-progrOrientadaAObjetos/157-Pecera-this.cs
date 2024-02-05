/*
157. A partir del ejercicio anterior (156), crea un nuevo constructor en Pez, 
que reciba la imagen derecha y la imagen izquierda, así como la velocidad (que 
será un "int"). Se basará en el constructor más detallado, dando como nombre 
una cadena vacía, como especie una cadena vacía, como coordenadas (20,8). 
Pruébalo añadiendo un cuarto pez a tu Simulador de Pecera, que tenga como 
imágenes "><>" y "<><", y 2 como velocidad. Los parámetros de todos los 
constructores se deben llamar igual que los atributos, de modo que uses "this" 
dentro de cada constructor para asignar valor a los atributos. Revisa el fuente 
de principio a fin, para tratar de minimizar la cantidad de código repetitivo.
*/
// Mario (...), retoques por Nacho

using System;
using System.Threading;

// ---------------

class Pez
{
    protected string nombre, especie, imagenDerecha, imagenIzquierda;
    protected byte x, y, velocidad;
    protected bool haciaLaDerecha;

    public string GetNombre() { return nombre; }
    public string GetEspecie() { return especie; }
    public int GetX() { return Convert.ToInt32(x); }
    public int GetY() { return Convert.ToInt32(y); }

    public void SetNombre(string nombre) { this.nombre = nombre; }
    public void SetEspecie(string especie) { this.especie = especie; }
    public void SetX(int x) { this.x = (byte)x; }
    public void SetY(int y) { this.y = (byte)y; }


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

    public void Nadar()
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

    public void Dibujar()
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
        base (nombre, especie, x, y)
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

    public PezMasGrande(int x,int y) : this ("", "", x, y) { }
}

// ---------------

class SimuladorDePecera
{
    static void Main()
    {
        Pez[] peces = new Pez[4];
        peces[0] = new Pez(15, 15);
        peces[1] = new PezMenor(5, 5);
        peces[2] = new PezMasGrande(20, 10);
        peces[3] = new Pez("><>", "<><", 2);


        bool salir = false;
        do
        {
            // Dibujado de pantalla
            Console.Clear();
            foreach (Pez p in peces) p.Dibujar();

            // Comprobación de teclas
            Thread.Sleep(100);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape)
                    salir = true;
            }
            // Movimiento de elementos
            foreach (Pez p in peces) p.Nadar();
        }
        while (!salir);
    }
}
