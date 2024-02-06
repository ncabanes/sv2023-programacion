/* Etiqueta la clase Cuadrado como "sellada". Comprueba que no se te 
permite de heredar de ella.
*/

using System;

abstract class FiguraGeometrica
{
    protected int x, y;
    
    public abstract void Dibujar();
}

sealed class Cuadrado : FiguraGeometrica
{
    protected int lado;
    
    public Cuadrado(int x, int y, int lado)
    {
        this.x = x;
        this.y = y;
        this.lado = lado;
    }
    
    public override void Dibujar()
    {
        Console.WriteLine("Cuadrado de lado {0} en ({1},{2})",
            lado, x, y);
    }
}

/*
class CuadradoRelleno : Cuadrado
{
}
*/

class Ejemplo 
{
    static void Main() 
    {
        Cuadrado c = new Cuadrado(10, 5, 20);
        c.Dibujar();
    }
}

// Cuadrado de lado 20 en (10,5)
