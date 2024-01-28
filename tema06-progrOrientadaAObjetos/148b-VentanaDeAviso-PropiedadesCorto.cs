/* 148.Crea una nueva versión del ejercicio anterior (147), pero esta vez
 * usando propiedades en formato compacto.
 *
 * VÍCTOR (...), retoques por Nacho */

using System;

// ----------------------------------

class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso[] v = new VentanaDeAviso[2];

        v[0] = new VentanaDeAviso(40, 12, 30, 5,
            "Ventana sin rellenar");
        v[0].X = 15;
        v[0].Y = 8;

        v[1] = new VentanaDeAvisoRellena(50, 6, 15, 5,
            "Ventana rellena");

        v[0].Mostrar();
        v[1].Mostrar();
    }
}

// ----------------------------------

class VentanaDeAviso
{
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
