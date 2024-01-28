/* 153. A partir del proyecto básico con la clase Programa (144), crea 
una versión mejorada, que incluya un array con hasta 1000 programas y 
que muestre un menú que permita añadir un programa o bien buscar (y 
mostrar) los que contengan un cierto texto.

Julio
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

//_____________________________________________

class PruebaArrayVideojuegos
{
    public static void Anyadir(Videojuego[] videoJuegos, ref int contadorReg)
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

        videoJuegos[contadorReg] = new Videojuego(titulo, plataforma, categoria, espacioOcupado, fecha, valoracion);
        contadorReg++;
    }

    public static void Buscar(Videojuego[] videoJuegos, int contadorReg)
    {
        Console.Write("Introduce un texto para buscar: ");
        string textoBuscar = Console.ReadLine();
        bool encontrado = false;

        for (int i = 0; i < contadorReg; i++)
        {
            if (videoJuegos[i].Contiene(textoBuscar))
            {
                videoJuegos[i].Mostrar();
                encontrado = true;
            }
        }

        if (!encontrado) { Console.WriteLine("No se encontro ningun juego con ese texto"); }
    }

    static void Main()
    {
        const int CAPACIDAD = 1000;
        const string SALIR = "S", ANYADIR = "1", BUSCAR = "2";
        Videojuego[] videoJuegos = new Videojuego[CAPACIDAD];
        int contadorReg = 0;
        string opcion = "";
        do
        {
            Console.WriteLine();
            Console.WriteLine("1.- Añadir Videojuego");
            Console.WriteLine("2.- Buscar por texto");
            Console.WriteLine("S.- Salir");
            Console.WriteLine();
            opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                case ANYADIR:
                    Anyadir(videoJuegos, ref contadorReg);
                    break;

                case BUSCAR:
                    Buscar(videoJuegos, contadorReg);
                    break;

                case SALIR:
                    Console.WriteLine("Cerrando...");
                    break;
            }
        }
        while (opcion != "S");
    }
}
