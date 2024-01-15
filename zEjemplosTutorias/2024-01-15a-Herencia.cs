/* Crea una clase RecuadroHueco, que herede de Recuadro, y cuyo método 
"Dibujar" muestre un rectángulo hueco, formado sólo por bordes. Los 
atributos deberán pasar a ser "protected".
*/

using System;

class Recuadro
{
    protected int x;
    protected int y;
    protected int anchura;
    protected int altura;
    protected char caracter;

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

class RecuadroHueco : Recuadro
{
    public void Dibujar()
    {
        for (int fila = 0; fila < altura; fila++)
        {
            for (int columna = 0; columna < anchura; columna++)
            {
                if ((fila == 0) || (fila == altura-1)
                    || (columna == 0) || (columna == anchura-1))
                {
                    Console.SetCursorPosition(x+columna, y+fila);
                    Console.Write(caracter);
                }
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

        RecuadroHueco r2 = new RecuadroHueco();
        r2.SetX(12);
        r2.SetY(5);
        r2.SetAltura(7);
        r2.SetAnchura(25);
        r2.SetCaracter('#');
        r2.Dibujar();
    }
}



// 
// 
//           ********************
//           ********************
//           **#########################
//           **#*****************      #
//           **#*****************      #
//             #                       #
//             #                       #
//             #                       #
//             #########################
