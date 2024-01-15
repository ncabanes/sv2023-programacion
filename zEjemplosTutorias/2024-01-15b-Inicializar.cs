/* Crea una nueva versión de la clase Recuadro, que incluya un método 
"Inicializar (x, y, ancho, alto)", que permita dar a la vez los valores 
iniciales para todos los atributos. Pruébalo desde "Main".
*/

using System;

class Recuadro
{
    protected int x;
    protected int y;
    protected int anchura;
    protected int altura;
    protected char caracter;
    
    public void Inicializar(int nuevaX, int nuevaY,
        int nuevaAltura, int nuevaAnchura, char c)
    {
        x =  nuevaX;
        y =  nuevaY;
        altura = nuevaAltura;
        anchura = nuevaAnchura;
        caracter = c;
    }

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
        r1.Inicializar(10, 3, 5, 20, '*');
        r1.Dibujar();

        RecuadroHueco r2 = new RecuadroHueco();
        r2.Inicializar(12, 5, 7, 25, '#');
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
