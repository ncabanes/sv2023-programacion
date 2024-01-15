/*
131.Crea, desde Visual Studio, una clase llamada "VentanaDeAviso",
cuyos atributos (privados) serán las coordenadas x e y de comienzo 
(números enteros), la anchura y la altura (también enteros) y el texto 
que va a mostrar esa ventana de aviso. Crea "getters" y "setters" que 
permitan cambiar el valor de los atributos. Tendrá también un método 
"Mostrar", que muestre la ventana en pantalla con el mensaje centrado 
en ella (puedes dejar este método vacío, o bien tratar de implementarlo 
usando Console.SetCursorPosition). Crea, en un segundo fichero fuente,
una clase "PruebaDeVentanaDeAviso", que tendrá un "Main" capaz de crear 
dos ventanas en distintas posiciones, con distintos tamaños y distintos 
mensajes, y los mostrará en pantalla (no es importante si el método 
"Mostrar" no lo has llegado a desarrollar y realmente no se ve nada en 
pantalla). Entrega todo el proyecto de Visual Studio, comprimido en un 
fichero ZIP.
*/

// Iván (...), retoques por Nacho

using System;

class VentanaDeAviso
{
    private int x, y, anchura, altura;
    private string texto;

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

// ---------------------


class PruebaDeVentanaDeAviso
{
    static void Main()
    {
        VentanaDeAviso v = new VentanaDeAviso();

        v.SetX(40);
        v.SetY(12);
        v.SetAltura(5);
        v.SetAnchura(30);
        v.SetTexto("Base de datos analizada");

        v.Mostrar();

        v.SetX(50);
        v.SetY(6);
        v.SetAltura(5);
        v.SetAnchura(15);
        v.SetTexto("Bienvenido");

        v.Mostrar();
    }
}
