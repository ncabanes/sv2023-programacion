/*
Para guardar información sobre libros, vamos a comenzar por crear una 
clase "Libro", que contendrá atributos "autor", "titulo", "ubicacion" 
(todos ellos strings). En esta primera aproximación, los tres atributos 
serán públicos. Crea también un método "MostrarDetalles", que escriba 
los valores de los tres atributos. Finalmente, prepara también un Main 
(en la misma clase), que cree un objeto de la clase Libro, dé valores a 
sus tres atributos y luego los muestre.
*/

using System;

class Libro 
{
    public string autor;
    public string titulo;
    public string ubicacion;
    
    public void MostrarDetalles()
    {
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Ubic: " + ubicacion);
    }

    
    static void Main() 
    {
        Libro l1 = new Libro();
        l1.autor = "Stephen King";
        l1.titulo = "It";
        l1.ubicacion = "Est1 Bal2";
        
        l1.MostrarDetalles();
        
        Libro l2 = new Libro();
        l2.autor = "Stephen King";
        l2.titulo = "Carrie";
        l2.ubicacion = "Est1 Bal2";
        
        l2.MostrarDetalles();
    }
}

// Autor: Stephen King
// Título: It
// Ubic: Est1 Bal2
// Autor: Stephen King
// Título: Carrie
// Ubic: Est1 Bal2

