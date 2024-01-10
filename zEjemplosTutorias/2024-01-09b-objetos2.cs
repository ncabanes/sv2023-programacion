/* Mejora la clase "Libro": los atributos no serán públicos, sino que 
habrá métodos Get y Set adecuados para leer su valor y cambiarlo.
*/

using System;

class Libro 
{
    private string autor;
    private string titulo;
    private string ubicacion;
    
    public string GetAutor()
    {
        if (autor != "")
            return autor;
        else
            return "Anónimo";
    }
    
    public string GetTitulo() { return titulo; }
    public string GetUbicacion() { return ubicacion; }
    
    public void SetAutor(string nuevoAutor)
    {
        if (nuevoAutor == "")
            autor = "Desconocido";
        else
            autor = nuevoAutor;
    }
    
    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }
    public void SetUbicacion(string nuevaUbic) { ubicacion = nuevaUbic; }
    
    public void MostrarDetalles()
    {
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Ubic: " + ubicacion);
    }
}

// ----------------

class PruebaDeLibro
{    
    static void Main() 
    {
        Libro l1 = new Libro();
        l1.SetAutor("Stephen King");
        l1.SetAutor("It");
        l1.SetUbicacion("Est1 Bal2");
        
        l1.MostrarDetalles();
        
        Libro l2 = new Libro();
        l2.SetAutor("Stephen King");
        l2.SetAutor("Carrie");
        l2.SetUbicacion("Est1 Bal2");
        
        l2.MostrarDetalles();
    }
}

// Autor: It
// Título:
// Ubic: Est1 Bal2
// Autor: Carrie
// Título:
// Ubic: Est1 Bal2

