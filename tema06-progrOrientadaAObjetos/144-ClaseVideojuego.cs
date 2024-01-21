/* 144. De cara a irnos acercando a una versión orientada a objetos del 
proyecto de la colección de videojuegos (ejercicios 114), crea una clase 
Videojuego, con atributos: titulo (string), plataforma (string), categoria 
(string), espacioOcupado (int), fecha (string), valoración (float). Debes 
preparar setters y getters para todos ellos. Crea también un constructor 
adecuado, un método Mostrar (void) que muestre los datos de un Videojuego en 
pantalla (cada uno en una línea), y un método Contiene (booleano) que devuelva 
"true" si el título, la plataforma o la categoría contienen el texto que se 
indique como parámetro. Crea un Main de prueba que cree un objeto de esa clase, 
lo muestre y compruebe si contiene un cierto texto.

Julio, retoques menores por Nacho
*/

using System;

class Videojuego
{
    protected string titulo;
    protected string plataforma;
    protected string categoria;
    protected int espacioOcupado;
    protected string fecha;
    protected float valoracion;

    public string GetTitulo() { return titulo; }
    public string GetPlataforma() { return plataforma; }
    public string GetCategoria() { return categoria; }
    public int GetEspacioOcupado() { return espacioOcupado; }
    public string GetFecha() { return fecha; }
    public float GetValoracion() { return valoracion; }

    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }

    public void SetPlataforma(string nuevaPlataforma)
    {
        plataforma = nuevaPlataforma;
    }

    public void SetCategoria(string nuevaCategoria)
    {
        categoria = nuevaCategoria;
    }

    public void SetEspacioOcupado(int nuevoEspacioOcupado)
    {
        espacioOcupado = nuevoEspacioOcupado;
    }

    public void SetFecha(string nuevaFecha) { fecha = nuevaFecha; }

    public void SetValoracion(float nuevaValoracion)
    {
        valoracion = nuevaValoracion;
    }

    //public Videojuego() { }

    public Videojuego(string nuevoTitulo, string nuevaPlataforma,
        string nuevaCategoria, int nuevoEspacioOcupado, string nuevaFecha, float nuevaValoracion)
    {
        titulo = nuevoTitulo;
        plataforma = nuevaPlataforma;
        categoria = nuevaCategoria;
        espacioOcupado = nuevoEspacioOcupado;
        fecha = nuevaFecha;
        valoracion = nuevaValoracion;
    }

    public void Mostrar()
    {
        Console.WriteLine(titulo);
        Console.WriteLine(plataforma);
        Console.WriteLine(categoria);
        Console.WriteLine(espacioOcupado);
        Console.WriteLine(fecha);
        Console.WriteLine(valoracion);
    }

    public bool Contiene(string buscarTexto)
    {

        if (titulo.ToUpper().Contains(buscarTexto.ToUpper())
            || plataforma.ToUpper().Contains(buscarTexto.ToUpper())
            || categoria.ToUpper().Contains(buscarTexto.ToUpper()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//_____________________________________________

class MainPrueba
{
    static void Main()
    {
        Videojuego videojuego = 
            new Videojuego("Gran Turismo", "Play Station", "Motor", 800, "1997/5", 4.7f);

        if (videojuego.Contiene("gra"))
        {
            videojuego.Mostrar();
        }
    }
}
