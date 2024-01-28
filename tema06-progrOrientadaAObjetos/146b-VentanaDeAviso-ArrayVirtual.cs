/* 146. Crea una variante del ejercicio anterior (145), en la que Dibujar sea
 * "virtual" en la clase base y "override" en la clase hija. Comprueba si ahora
 * se comporta correctamente.
 * 
 * VÍCTOR (...) */

using System;
 
 // -------------------------

class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso[] v = new VentanaDeAviso[2];

        v[0] = new VentanaDeAviso(40, 12, 30, 5,
            "Ventana sin rellenar");
        v[1] = new VentanaDeAvisoRellena(50, 6, 15, 5,
            "Ventana rellena");

        v[0].Mostrar();
        v[1].Mostrar();
    }
}

// -------------------------

class VentanaDeAviso
{
    protected int x, y, anchura, altura;
    protected string texto;

    public VentanaDeAviso() { }

    public VentanaDeAviso(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
    {
        x = xInicial;
        y = yInicial;
        anchura = ancho;
        altura = alto;
        texto = textoMostrar;
    }

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetAnchura() { return anchura; }
    public int GetAltura() { return altura; }
    public string GetTexto() { return texto; }

    public void SetX(int valor) { x = valor; }
    public void SetY(int valor) { y = valor; }
    public void SetAnchura(int valor) { anchura = valor; }
    public void SetAltura(int valor) { altura = valor; }
    public void SetTexto(string valor) { texto = valor; }

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

// -------------------------


class VentanaDeAvisoRellena : VentanaDeAviso
{
    public VentanaDeAvisoRellena(int xInicial, int yInicial,
        int ancho, int alto, string textoMostrar)
    {
        x = xInicial;
        y = yInicial;
        anchura = ancho;
        altura = alto;
        texto = textoMostrar;
    }

    public override void Mostrar()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        for (int fila = 0; fila < altura; fila++)
        {
            for (int columna = 0; columna < anchura; columna++)
            {
                Console.SetCursorPosition(x + columna, y + fila);
                Console.Write(" ");
            }
        }
        Console.SetCursorPosition(
            x + anchura / 2 - texto.Length / 2,
            y + altura / 2);
        Console.WriteLine(texto);
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

