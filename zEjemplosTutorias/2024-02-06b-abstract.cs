/*
Crea una clase abstracta FiguraGeometrica, con atributos (o 
propiedades) "x" e "y" y con un método abstracto "Dibujar". 

Comprueba que no te deja instanciar objetos de esa clase.

Crea una clase Cuadrado, que herede de ella, que añada un atributo 
"lado". Implementa en ella el método "Dibujar" (por ejemplo, puedes 
dibujar cuadrado de ese lado, en esas coordenadas de pantalla, con 
Console.SetCursorPosition, o simplemente escribir un texto).
*/

using System;

abstract class FiguraGeometrica
{
    protected int x, y;
    
    public abstract void Dibujar();
}

class Cuadrado : FiguraGeometrica
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

class Ejemplo 
{
    static void Main() 
    {
        Cuadrado c = new Cuadrado(10, 5, 20);
        c.Dibujar();
    }
}

// Cuadrado de lado 20 en (10,5)
