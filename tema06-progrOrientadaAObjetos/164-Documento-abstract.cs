/*
 * 164. A partir de la "solución oficial" del ejercicio 160 (Documento y Libro + Menu),
 * crea una variante en la que la clase "Documento" no incluya el número de páginas,
 * sea abstracta y de ella hereden tanto una clase "DocumentoImpreso", 
 * que sí tendrá número de páginas, como una "DocumentoDigital", que tendrá una URL en vez de un número de páginas.
 * El "Libro" será un subtipo de DocumentoImpreso. 
 * Retoca el resto de métodos y el programa gestor como creas conveniente, 
 * de modo que se pueda añadir tanto libros como documentos digitales.
 
  julio
 
 */



using System;

class PruebaDeDocumento
{
    public static string PedirDato(string DatoPedido)
    {
        Console.Write(DatoPedido);
        return Console.ReadLine();
    }

    public static void Anyadir(Documento[] documentos, ref int numDatos,
        int capacidad)
    {
        if (numDatos == capacidad)
        {
            Console.WriteLine("El array está lleno.");
        }
        else
        {
            Console.WriteLine("Tipo de documento a añadir:");
            Console.WriteLine("1.- Documento genérico");
            Console.WriteLine("2.- Docuemnto Impreso");
            Console.WriteLine("3.- Docuemnto Digital");
            Console.WriteLine();
            string opcion = PedirDato("Elige una opción: ");
            Console.WriteLine();

            if (opcion != "1" && opcion != "2" && opcion != "3")
            {
                Console.WriteLine("Opción incorrecta.");
            }
            else
            {
                string titulo = PedirDato("Título: ");
                string autor = PedirDato("Autor: ");
                string ubicacion = PedirDato("Ubicación: ");

                if (opcion == "1")
                {
                    documentos[numDatos] = new DocumentoGenerico(titulo, autor, ubicacion);
                    numDatos++;
                }

                if (opcion == "2")
                {
                    string esLibro = PedirDato("Este docuemnto es un libro?, si o no:  ").ToLower();

                    if (esLibro != "si" && esLibro != "no")
                    {
                        Console.WriteLine("Opción incorrecta.");
                    }
                    else
                    {
                        int paginas = Convert.ToInt32(PedirDato("Número de páginas: "));

                        if (esLibro == "si")
                        {
                            string tapa = PedirDato("Tapa dura (D) o blanda (B): ");
                            documentos[numDatos] = new Libro(titulo, autor, paginas,
                            ubicacion, tapa);
                            numDatos++;
                        }
                        if (esLibro == "no")
                        {
                            documentos[numDatos] = new DocumentoImpreso(titulo, autor, paginas,
                            ubicacion);
                            numDatos++;
                        }
                    }
                }

                if (opcion == "3")
                {
                    string url = PedirDato("Introduce la URL: ");
                    documentos[numDatos] = new DocumentoDigital(titulo, autor, ubicacion, url);
                    numDatos++;
                }
            }
        }
    }

    public static void Modificar(Documento[] documentos, int numDatos)
    {
        if (numDatos == 0)
        {
            Console.WriteLine("No hay datos.");
        }
        else
        {
            int numRegistro = Convert.ToInt32(PedirDato(
                "Introduce el número de registro a modificar: "));
            if (numRegistro > numDatos || numRegistro <= 0)
            {
                Console.WriteLine("Número de registro incorrecto.");
            }
            else
            {
                Console.WriteLine(numRegistro + ".- " +
                    documentos[numRegistro]);
                Console.WriteLine("Pulse Intro para no cambiar los datos.");

                string respuesta = PedirDato("Nuevo título: ");
                if (respuesta != "")
                    documentos[numRegistro - 1].SetTitulo(respuesta);

                respuesta = PedirDato("Nuevo autor: ");
                if (respuesta != "")
                    documentos[numRegistro - 1].SetAutor(respuesta);


                if (documentos[numRegistro - 1] is DocumentoImpreso)
                {
                    respuesta = PedirDato("Nuevas páginas: ");
                    if (respuesta != "")
                        ((DocumentoImpreso)documentos[numRegistro - 1]).Paginas = Convert.ToInt32(respuesta);
                }

                respuesta = PedirDato("Nueva ubicación: ");
                if (respuesta != "")
                    documentos[numRegistro - 1].SetUbicacion(respuesta);

                if (documentos[numRegistro - 1] is Libro)
                {
                    respuesta = PedirDato("Nueva tapa dura (D) o blanda (B): ");
                    if (respuesta != "")
                        ((Libro)documentos[numRegistro - 1]).SetTapa(
                            respuesta);
                }
            }
        }
    }

    public static void Buscar(Documento[] documentos, int numDatos)
    {
        bool encontrado = false;
        string texto = PedirDato("Texto a buscar: ");
        for (int i = 0; i < numDatos; i++)
        {
            if (documentos[i].Contiene(texto))
            {
                encontrado = true;
                Console.WriteLine(documentos[i]);
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No se han encontrado coincidencias.");
        }
    }

    public static void Ordenar(Documento[] documentos, int numDatos)
    {
        for (int i = 0; i < numDatos; i++)
        {
            for (int j = i + 1; j < numDatos; j++)
            {
                if ((documentos[i].GetTitulo()).ToUpper().CompareTo(
                    documentos[j].GetTitulo().ToUpper()) > 0 ||
                    ((documentos[i].GetTitulo().ToUpper() ==
                    documentos[j].GetTitulo().ToUpper())
                    && (documentos[i].GetAutor()).ToUpper().CompareTo(
                    documentos[j].GetAutor().ToUpper()) > 0))
                {
                    Documento docTemp = documentos[i];
                    documentos[i] = documentos[j];
                    documentos[j] = docTemp;
                }
            }
        }
    }

    static void Main()
    {
        const int CAPACIDAD = 100;
        const string SALIR = "S", ANYADIR = "1", BUSCAR = "2", MODIFICAR = "3",
            ORDENAR = "4";
        Documento[] documentos = new Documento[CAPACIDAD];
        int numDatos = 0;
        bool salir = false;
        string opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine(ANYADIR + ".- Añadir nuevo documento");
            Console.WriteLine(BUSCAR + ".- Buscar documento");
            Console.WriteLine(MODIFICAR + ".- Modificar un documento");
            Console.WriteLine(ORDENAR + ".- Ordenar los datos");
            Console.WriteLine(SALIR + ".- Salir");
            Console.WriteLine();
            opcion = PedirDato("Elige una opción: ").ToUpper();
            Console.WriteLine();

            switch (opcion)
            {
                case ANYADIR:
                    Anyadir(documentos, ref numDatos, CAPACIDAD); break;
                case BUSCAR: Buscar(documentos, numDatos); break;
                case MODIFICAR: Modificar(documentos, numDatos); break;
                case ORDENAR: Ordenar(documentos, numDatos); break;
                case SALIR: salir = true; break;
                default: Console.WriteLine("Opción no válida."); break;
            }
            Console.WriteLine();
        }
        while (!salir);
    }
}

// --------------------

abstract class Documento
{
    protected string titulo, autor, ubicacion;

    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }

    public string GetUbicacion() { return ubicacion; }

    public void SetTitulo(string titulo) { this.titulo = titulo; }
    public void SetAutor(string autor) { this.autor = autor; }

    public void SetUbicacion(string ubicacion) { this.ubicacion = ubicacion; }

    public Documento(string titulo, string autor, string ubicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
    }

    public Documento(string titulo) : this(titulo, "Anónimo", "")
    {
    }

    public override string ToString()
    {
        return "Autor = " + autor + ", Título = " + titulo + ", ubicación = " + ubicacion;
    }

    public bool Contiene(string texto)
    {
        bool contiene = false;
        if (ToString().ToUpper().Contains(texto.ToUpper()))
        {
            contiene = true;
        }
        return contiene;
    }
}


// --------------------

class Libro : DocumentoImpreso
{
    protected char tapa;

    public char GetTapa() { return tapa; }
    public void SetTapa(string tapa)
    {
        if (tapa != null) this.tapa = Convert.ToChar(tapa.ToUpper()[0]);
    }
    public Libro(string titulo, string autor, int paginas, string ubicacion,
        string tapa) : base(titulo, autor, paginas, ubicacion)
    {
        this.tapa = Convert.ToChar(tapa.ToUpper()[0]);
    }

    public override string ToString()
    {
        return base.ToString() + ", Portada = " + tapa;
    }
}

class DocumentoImpreso : Documento
{
    public int Paginas { get; set; }
    public DocumentoImpreso(string titulo, string autor, int paginas, string ubicacion)
        : base(titulo, autor, ubicacion)
    {
        this.Paginas = paginas;
    }

    public override string ToString()
    {
        return base.ToString() + ", paginas = " + Paginas;
    }

}

class DocumentoDigital : Documento
{
    public string url { get; set; }

    public DocumentoDigital(string titulo, string autor, string ubicacion, string url)
        : base(titulo, autor, ubicacion)
    {
        this.url = url;
    }

    public override string ToString()
    {
        return base.ToString() + ", URL = " + url;
    }
}

class DocumentoGenerico : Documento
{
    public DocumentoGenerico(string titulo, string autor, string ubicacion)
        : base(titulo, autor, ubicacion)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
