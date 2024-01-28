/* 147. Crea una variante del ejercicio anterior (146), empleando propiedades
 * (en formato largo) en vez de "getters" y "setters" convencionales. Haz que
 * los atributos sean privados, en vez de protegidos, de modo que la clase
 * VentanaDeAvisoRellena use las propiedades, en vez de los atributos. Además,
 * desde Main, cambia la X del primer rectángulo usando propiedades.
 * 
 * VÍCTOR (...), retoques menores por Nacho */

using System;

// ----------------------------------

class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso[] v = new VentanaDeAviso[2];

        v[0] = new VentanaDeAviso(40, 12, 30, 5,
            "Ventana sin rellenar");
        v[0].X = 10;

        v[1] = new VentanaDeAvisoRellena(50, 6, 15, 5,
            "Ventana rellena");

        v[0].Mostrar();
        v[1].Mostrar();
    }
}

// ----------------------------------

class VentanaDeAviso
{
    private int x, y, anchura, altura;
    private string texto;

    public VentanaDeAviso() { }
    
    public VentanaDeAviso(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
    {
        X = xInicial;
        Y = yInicial;
        Anchura = ancho;
        Altura = alto;
        Texto = textoMostrar;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public int Anchura
    {
        get { return anchura; }
        set { anchura = value; }
    }

    public int Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public string Texto
    {
        get { return texto; }
        set { texto = value; }
    }

    public virtual void Mostrar()
    {
        for (int fila = 0; fila < altura; fila++)
        {
            for (int columna = 0; columna < anchura; columna++)
            {
                if (fila == 0 || fila == altura - 1
                    || columna == 0 || columna == anchura - 1)
                {
                    Console.SetCursorPosition(x + columna, y + fila);
                    Console.Write("*");
                }
            }
        }
        Console.SetCursorPosition(
            x + anchura / 2 - texto.Length / 2,
            y + altura / 2);
        Console.WriteLine(texto);
    }
}

// ----------------------------------

class VentanaDeAvisoRellena : VentanaDeAviso
{
    public VentanaDeAvisoRellena(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
    {
        X = xInicial;
        Y = yInicial;
        Anchura = ancho;
        Altura = alto;
        Texto = textoMostrar;
    }
    
    public override void Mostrar()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        for (int fila = 0; fila < Altura; fila++)
        {
            for (int columna = 0; columna < Anchura; columna++)
            {
                Console.SetCursorPosition(X + columna, Y + fila);
                Console.Write(" ");
            }
        }
        Console.SetCursorPosition(
            X + Anchura / 2 - Texto.Length / 2,
            Y + Altura / 2);
        Console.WriteLine(Texto);
        Console.BackgroundColor = ConsoleColor.Black;
    }
}
