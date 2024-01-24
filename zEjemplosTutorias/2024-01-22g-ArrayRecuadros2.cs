/* Crea una nueva versión del array formado por varios recuadros. 
Emplea "virtual" y "override".
 */

using System;

class Recuadro
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Anchura { get; set; }
    public int Altura { get; set; }
    public char Caracter{ get; set; }

    public virtual void Dibujar()
    {
        for (int fila = 0; fila < Altura; fila++)
        {
            for (int columna = 0; columna < Anchura; columna++)
            {
                Console.SetCursorPosition(X+columna, Y+fila);
                Console.Write(Caracter);
            }
        }
    }
}

// -------------------

class RecuadroHueco : Recuadro
{
    public override void Dibujar()
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
        Recuadro[] r = new Recuadro[2];
        
        r[0] = new Recuadro();
        r[0].X = 10;
        r[0].Y = 3;
        r[0].Altura = 5;
        r[0].Anchura = 20;
        r[0].Caracter = '*';
        r[0].Dibujar();

        r[1] = new RecuadroHueco();
        r[1].X = 12;
        r[1].Y = 5;
        r[1].Altura = 7;
        r[1].Anchura = 25;
        r[1].Caracter = '#';
        r[1].Dibujar();
    }
}


//
//
//
//         ********************
//         ********************
//         **#########################
//         **#*****************      #
//         **#*****************      #
//           #                       #
//           #                       #
//           #                       #
//           #########################
//
