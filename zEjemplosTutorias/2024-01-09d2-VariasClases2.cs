/*
Crea, desde Visual Studio, una clase llamada "Recuadro", cuyos 
atributos (privados) serán las coordenadas x e y de comienzo (números 
enteros), la anchura y la altura (también enteros) y el carácter con el 
que se dibuje ese recuadro (hueco). Crea "getters" y "setters" que 
permitan cambiar el valor de los atributos. Tendrá también un método 
"Dibujar", que muestre el recuadro en pantalla (usando 
Console.SetCursorPosition). Crea, en un segundo fichero fuente, una 
clase "PruebaDeRecuadro", que tendrá un "Main" capaz de crear dos 
recuadros en distintas posiciones, con distintos tamaños y distintos 
caracteres de borde, y los dibujará en pantalla. Entrega todo el 
proyecto de Visual Studio, comprimido en un fichero ZIP.
*/

using System;

class Recuadro
{
    private int x;
    private int y;
    private int anchura;
    private int altura;
    private char caracter;

    public void SetX(int nuevaX) { x =  nuevaX; }
    public void SetY(int nuevaY) { y =  nuevaY; }
    public void SetAltura(int nuevaAltura) 
    { 
        altura = nuevaAltura; 
    }
    public void SetAnchura(int nuevaAnchura) 
    { 
        anchura = nuevaAnchura; 
    }
    public void SetCaracter(char c) { caracter = c; }

    public int GetX() { return x; }
    public int GetY() { return y; }
    public int GetAnchura() {  return anchura; }
    public int GetAltura() { return altura; }
    public char GetCaracter() {  return caracter; }

    public void Dibujar()
    {
        for (int fila = 0; fila < altura; fila++)
        {
            for (int columna = 0; columna < anchura; columna++)
            {
                Console.SetCursorPosition(x+columna, y+fila);
                Console.Write(caracter);
            }
        }
    }
}

// -------------------

class PruebaDeRecuadro
{
    static void Main(string[] args)
    {
        Recuadro r1 = new Recuadro();
        r1.SetX(10);
        r1.SetY(3);
        r1.SetAltura(5);
        r1.SetAnchura(20);
        r1.SetCaracter('*');
        r1.Dibujar();

        Recuadro r2 = new Recuadro();
        r2.SetX(12);
        r2.SetY(5);
        r2.SetAltura(7);
        r2.SetAnchura(25);
        r2.SetCaracter('#');
        r2.Dibujar();
    }
}


//           ********************
//           ********************
//           **#########################
//           **#########################
//           **#########################
//             #########################
//             #########################
//             #########################
//             #########################


