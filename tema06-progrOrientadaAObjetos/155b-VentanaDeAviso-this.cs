/*155. Mejora el ejercicio anterior (154), para que haya un segundo constructor
 * en VentanaDeAviso, que sólo sólo reciba los valores de X, de Y y del Texto),
 * y que se apoye en el constructor más detallado, empleando "this" para prefijar
 * la anchura a 40 y la altura a 5. */

// Noelia (...)

using System;

// -------------------

class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso[] v = new VentanaDeAviso[3];

        v[0] = new VentanaDeAviso(40, 12, 30, 5,
            "Ventana sin rellenar");
        v[0].X = 15;
        v[0].Y = 8;

        v[1] = new VentanaDeAvisoRellena(50, 6, 15, 5,
            "Ventana rellena");

        v[2] = new VentanaDeAviso(50, 12, "Otra sin rellenar"); // ventana this

        v[0].Mostrar();
        v[1].Mostrar();
        v[2].Mostrar();
    }
}

// -------------------

class VentanaDeAviso
{
    public VentanaDeAviso(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
    {
        X = xInicial;
        Y = yInicial;
        Anchura = ancho;
        Altura = alto;
        Texto = textoMostrar;
    }
    
    public VentanaDeAviso(int xInicial, int yInicial, string textoMostrar)
        : this (xInicial, yInicial, 40, 5, textoMostrar)    
    {
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Anchura { get; set; }
    public int Altura { get; set; }
    public string Texto { get; set; }

    public virtual void Mostrar()
    {
        for (int fila = 0; fila < Altura; fila++)
        {
            for (int columna = 0; columna < Anchura; columna++)
            {
                if (fila == 0 || fila == Altura - 1
                    || columna == 0 || columna == Anchura - 1)
                {
                    Console.SetCursorPosition(X + columna, Y + fila);
                    Console.Write("*");
                }
            }
        }
        Console.SetCursorPosition(
            X + Anchura / 2 - Texto.Length / 2,
            Y + Altura / 2);
        Console.WriteLine(Texto);
    }
}

// -------------------

class VentanaDeAvisoRellena : VentanaDeAviso
{
    public VentanaDeAvisoRellena(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
        :base (xInicial,  yInicial, ancho,  alto,  textoMostrar)
    {
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
