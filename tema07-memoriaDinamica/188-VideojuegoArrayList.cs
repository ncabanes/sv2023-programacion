/* 188. Crea una nueva versión del ejercicio 153 (clase Videojuego
 * simplificada), partiendo de la versión oficial, empleando una lista en vez
 * de un array para guardar los datos.
 * 
 * VICTOR (...) */

using System;
using System.Collections.Generic;

// -------------------

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
    public int GetEspacioOcupado() { return Convert.ToInt32(espacioOcupado); }
    public string GetFecha() { return fecha; }
    public float GetValoracion() { return Convert.ToSingle(valoracion); }

    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }

    public void SetPlataforma(string nuevaPlataforma)
    {
        plataforma = nuevaPlataforma;
    }

    public void SetCategoria(string nuevaCategoria)
    {
        categoria = nuevaCategoria;
    }

    public void SetEspacioOcupado(string nuevoEspacioOcupado)
    {
        espacioOcupado = Convert.ToInt32(nuevoEspacioOcupado);
    }

    public void SetFecha(string nuevaFecha) { fecha = nuevaFecha; }

    public void SetValoracion(string nuevaValoracion)
    {
        valoracion = Convert.ToSingle(nuevaValoracion);
    }

    //public Videojuego() { }

    public Videojuego(string nuevoTitulo, string nuevaPlataforma,
        string nuevaCategoria, string nuevoEspacioOcupado, string nuevaFecha, string nuevaValoracion)
    {
        titulo = nuevoTitulo;
        plataforma = nuevaPlataforma;
        categoria = nuevaCategoria;
        espacioOcupado = Convert.ToInt32(nuevoEspacioOcupado);
        fecha = nuevaFecha;
        valoracion = Convert.ToSingle(nuevaValoracion);
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

// -------------------

class PruebaArrayList
{
    public static void Anyadir(List<Videojuego> miListaDeVideoJuegos)
    {
        Console.Write("Titulo: ");
        string titulo = Console.ReadLine();

        Console.Write("Plataforma: ");
        string plataforma = Console.ReadLine();

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Espacio Ocupado: ");
        string espacioOcupado = Console.ReadLine();

        Console.Write("Fecha: ");
        string fecha = Console.ReadLine();

        Console.Write("Valoracion: ");
        string valoracion = Console.ReadLine();

        miListaDeVideoJuegos.Add(new Videojuego(titulo, plataforma, categoria,
            espacioOcupado, fecha, valoracion));
    }

    public static void Buscar(List<Videojuego> miListaDeVideoJuegos)
    {
        Console.Write("Introduce un texto para buscar: ");
        string textoBuscar = Console.ReadLine();
        bool encontrado = false;
    
        foreach (Videojuego juego in miListaDeVideoJuegos)
        {
            if (juego.Contiene(textoBuscar))
            {
                juego.Mostrar();
                encontrado = true;
            }
        }
    
        if (!encontrado)
        {
            Console.WriteLine("No se encontraron coincidencias");
        }
    }

    static void Main()
    {
        const string SALIR = "S", ANYADIR = "1", BUSCAR = "2";

        List<Videojuego> miListaDeVideoJuegos = new List<Videojuego>();
        
        string opcion = "";

        do
        {
            Console.WriteLine();
            Console.WriteLine("     --- MENÚ ---   ");
            Console.WriteLine();
            Console.WriteLine("1.- Añadir Videojuego");
            Console.WriteLine("2.- Buscar por texto");
            Console.WriteLine("S.- Salir");
            Console.WriteLine();
            opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                case ANYADIR:
                    Anyadir(miListaDeVideoJuegos);
                    break;

                case BUSCAR:
                    Buscar(miListaDeVideoJuegos);
                    break;

                case SALIR:
                    Console.WriteLine("¡Hasta luego!");
                    break;
            }
        }
        while (opcion != "S");
    }
}
