/* 167. Crea una interfaz "Dibujable", con un método Dibujar, y una interfaz
 * "Animable", con un método CambiarFotograma. Crea una clase SpriteAnimable,
 * con atributos x e y, que implemente ambas interfaces (aunque de momento esos
 * métodos "no hagan nada interesante").
 * 
 * VICTOR (...), retoques por Nacho */

using System;

class Program
{
    static void Main()
    {
        SpriteAnimable spriteAnimable = new SpriteAnimable();
        spriteAnimable.Dibujar();
        spriteAnimable.CambiarFotograma();
    }
}

// -----------------

interface IDibujable
{
    void Dibujar();
}

// -----------------

interface IAnimable
{
    void CambiarFotograma();
}

// -----------------

class SpriteAnimable : IDibujable, IAnimable
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujando");
    }

    public void CambiarFotograma()
    {
        Console.WriteLine("Siguiente fotogramaa...");
    }
}
