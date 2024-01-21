/*
143. Crea una clase "VentanaDeAvisoRellena", que herede de "VentanaDeAviso", 
pero no dibuje un rectángulo hueco, sino uno que tenga un cierto carácter (por 
ejemplo "·") en cada una de sus casillas. Si te atreves a intentarlo, como 
alternativa, puedes hacer que todas las casillas que forman la ventana tengan 
un color de fondo distinto, por ejemplo con "Console.BackgroundColor = 
ConsoleColor.DarkBlue;" y luego volviendo a dejar el color por defecto con 
"Console.BackgroundColor = ConsoleColor.Black;"
*/

// Iván (...), retoques menores por Nacho

using System;

class VentanaDeAviso
{
    protected int x, y, anchura, altura;
    protected string texto;
    
    public VentanaDeAviso() {}
    
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

    public void SetX(int valor) {  x = valor; }
    public void SetY(int valor) {  y = valor; }
    public void SetAnchura(int valor) {  anchura = valor; }
    public void SetAltura(int valor) {  altura = valor; }
    public void SetTexto(string valor) { texto = valor; }

    public void Mostrar()
    {
        for (int fila = 0; fila < altura; fila++)
        {
            for (int columna = 0; columna < anchura; columna++)
            {
                if (fila == 0 || fila == altura - 1 
                    || columna == 0 || columna == anchura -1)
                {
                    Console.SetCursorPosition(x + columna, y + fila);
                    Console.Write("*");
                }
            }
        }
        Console.SetCursorPosition(
            x + anchura/2 - texto.Length/2, 
            y + altura/2);
        Console.WriteLine(texto);
    }
}

// ................

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
    
    public void Mostrar()
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
            x + anchura/2 - texto.Length/2, 
            y + altura/2);
        Console.WriteLine(texto);
        Console.BackgroundColor = ConsoleColor.Black;
    }
}

// ................

class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso v = new VentanaDeAviso(40, 12, 30, 5, 
            "Base de datos analizada");
        v.Mostrar();
        
        VentanaDeAviso v2 = new VentanaDeAviso(50, 6, 15, 5, "Bienvenido");
        v2.Mostrar();

        VentanaDeAvisoRellena vr = new VentanaDeAvisoRellena(
            10, 10, 20, 10, "Hasta luego");
        vr.Mostrar();
    }
}
