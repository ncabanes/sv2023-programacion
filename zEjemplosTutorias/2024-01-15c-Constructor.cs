/* Crea una nueva versión de la clase Recuadro, que, en vez del método 
"Inicializar", incluya un constructor para dar valores iniciales. 
Necesitarás también un constructor en RecuadroHueco… y probablemente un 
constructor vacío (sin parámetros) en Recuadro, para evitar el error de 
compilación (lo mejoraremos más adelante). Pruébalo desde "Main".
*/

using System;

class Recuadro
{
    protected int x;
    protected int y;
    protected int anchura;
    protected int altura;
    protected char caracter;
    
    public Recuadro(int nuevaX, int nuevaY,
        int nuevaAltura, int nuevaAnchura, char c)
    {
        x =  nuevaX;
        y =  nuevaY;
        altura = nuevaAltura;
        anchura = nuevaAnchura;
        caracter = c;
    }
    
    public Recuadro()
    {
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
    public RecuadroHueco(int nuevaX, int nuevaY,
        int nuevaAltura, int nuevaAnchura, char c)
    {
        x =  nuevaX;
        y =  nuevaY;
        altura = nuevaAltura;
        anchura = nuevaAnchura;
        caracter = c;
    }
    
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
        Recuadro r1 = new Recuadro(10, 3, 5, 20, '*');
        r1.Dibujar();

        RecuadroHueco r2 = new RecuadroHueco(12, 5, 7, 25, '#');
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
