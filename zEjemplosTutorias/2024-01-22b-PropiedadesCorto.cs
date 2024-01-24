/* Crea una variante de la clase Recuadro, empleando propiedades (en 
formato corto) en vez de "getters" y "setters" convencionales.
*/

using System;

class Recuadro
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Anchura { get; set; }
    public int Altura { get; set; }
    public char Caracter{ get; set; }

    public void Dibujar()
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
