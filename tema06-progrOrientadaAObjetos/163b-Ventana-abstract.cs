/* 163. A partir de la "solución oficial" del ejercicio 155 
(VentanaDeAviso y VentanaDeAvisoRellena), crea una variante en la que 
la clase "VentanaDeAviso" sea abstracta y de ella hereden tanto 
"VentanaDeAvisoRellena" como una nueva "VentanaDeAvisoConBorde" (que 
absorberá la lógica de dibujado que antes tenía "VentanaDeAviso"), 
ambas selladas. */

// Iván (...)

using System;

// -------------------

class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso[] v = new VentanaDeAvisoConBorde[2];

        v[0] = new VentanaDeAvisoConBorde(40, 12, 30, 5,
            "Ventana sin rellenar");
        v[0].X = 15;
        v[0].Y = 8;

        v[1] = new VentanaDeAvisoConBorde(50, 12, "Otra sin rellenar"); // ventana this

        v[0].Mostrar();
        v[1].Mostrar();

        VentanaDeAviso[] vr = new VentanaDeAvisoRellena[1];

        vr[0] = new VentanaDeAvisoRellena(50, 6, 15, 5, "Ventana rellena");
        vr[0].Mostrar();
        
        
    }
}

// -------------------

abstract class VentanaDeAviso
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
        : this(xInicial, yInicial, 40, 5, textoMostrar)
    {
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Anchura { get; set; }
    public int Altura { get; set; }
    public string Texto { get; set; }

    public abstract void Mostrar();
}
// -------------------

sealed class VentanaDeAvisoRellena : VentanaDeAviso
{
    public VentanaDeAvisoRellena(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
        : base(xInicial, yInicial, ancho, alto, textoMostrar)
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
    
// -------------------

sealed class VentanaDeAvisoConBorde : VentanaDeAviso
{
    public VentanaDeAvisoConBorde(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
        : base(xInicial, yInicial, ancho, alto, textoMostrar)
    {
    }

    public VentanaDeAvisoConBorde(int xInicial, int yInicial, string textoMostrar)
        : this(xInicial, yInicial, 40, 5, textoMostrar)
    {
    }

    public override void Mostrar()
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
    
