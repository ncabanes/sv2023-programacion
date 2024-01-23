/* 141. Crea otra clase que herede de Pez (la que tú desees), y que 
cambie ligeramente el comportamiento y/o la apariencia. Haz que dos 
peces de clases distintas naden en la pantalla. Como mejora opcional, 
puedes hacer que su "imagen" cambie cuando "reboten" en un extremo de 
la pantalla. Por ejemplo, puede pasar de ser "><=>" a ser ""<=><". */

// Mario (...), retoques por Nacho

using System;

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
    
    public void Dibujar()
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
    
    public void Dibujar()
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
        Pez pescado = new Pez("Juan", "sardina", 15, 15);
        PezMenor pezquenyin = new PezMenor("Pepe", "boqueron", 5, 5);

        bool salir = false;
        do
        {
            // Dibujado de pantalla
            Console.Clear();
            pescado.Dibujar();
            pezquenyin.Dibujar();

            // Comprobación de teclas
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
            
            // Movimiento de elementos
            pescado.Nadar();
            pezquenyin.Nadar();
        }
        while (!salir);
    }
}
