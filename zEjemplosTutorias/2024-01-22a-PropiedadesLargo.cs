/* Crea una variante de la clase Recuadro, empleando propiedades (en 
formato largo) en vez de "getters" y "setters" convencionales. Haz que 
los atributos sean privados, en vez de protegidos, de modo que la clase 
RecuadroHueco use las propiedades, en vez de los atributos. Además, 
desde Main, cambia la X y el Caracter del primer rectángulo usando 
propiedades.

*/

using System;

class Recuadro
{
    private int x;
    private int y;
    private int anchura;
    private int altura;
    private char caracter;
    
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    
    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    
    public int Anchura
    {
        get { return anchura; }
        set { anchura = value; }
    }
    
    public int Altura
    {
        get { return altura; }
        set { altura = value; }
    }
    
    public char Caracter
    {
        get { return caracter; }
        set { caracter = value; }
    }


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
        for (int fila = 0; fila < Altura; fila++)
        {
            for (int columna = 0; columna < Anchura; columna++)
            {
                if ((fila == 0) || (fila == Altura-1)
                    || (columna == 0) || (columna == Anchura-1))
                {
                    Console.SetCursorPosition(X+columna, Y+fila);
                    Console.Write(Caracter);
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
        r1.X = 10;
        r1.Y = 3;
        r1.Altura = 5;
        r1.Anchura = 20;
        r1.Caracter = '*';
        r1.Dibujar();

        RecuadroHueco r2 = new RecuadroHueco();
        r2.X = 12;
        r2.Y = 5;
        r2.Altura = 7;
        r2.Anchura = 25;
        r2.Caracter = '#';
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
