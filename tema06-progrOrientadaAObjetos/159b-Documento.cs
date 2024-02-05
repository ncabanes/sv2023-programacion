/*159. Crea una Clase Documento, con atributos para el título, autor y número de 
páginas. Debe tener un constructor que recibirá los tres atributos (los 
parámetros deben tener el mismo nombre que los atributos, por lo que deberás 
usar "this"). Crea también los setters y getters convencionales para esos 
atributos. Crea también un constructor que solo reciba el título y que prefije 
el autor a "Anónimo" y el número de páginas a 0. Existirá un método "ToString", 
que devolverá algo como "Autor = a, Título = t, páginas = p" (con el autor y 
título reales, claro).

Crea una clase Libro, que herede de Documento. Esta nueva clase contendrá un 
atributo, "tapa", que será un "char" ("D" para tapa dura, "B" para tapa blanda). 
La clase Libro tendrá un único constructor que reciba todos los datos. Su método 
ToString terminará en ", Portada = p".

Crea un Main, con un array de objetos "Documento" en el que alguno sea un 
"Libro". Rellena datos de ejemplo (pueden estar prefijados) y muestra los datos 
de todos ellos.*/

// Miguel Ángel (...)

using System;

class PruebaDeDocumento
{
    static void Main()
    {
        Documento[] documentos = new Documento[3];
        documentos[0] = new Libro("El origen de las especies", 
            "Charles Darwin", 696, 'D');
        documentos[1] = new Documento("FOL");
        documentos[2] = new Documento("Álgebra 2ºESO", "Pedro Pérez", 24);

        foreach (Documento d in documentos)
        {
            Console.WriteLine(d);
        }
    }
}

// ----------------

class Documento
{
    private string titulo, autor;
    private int paginas;

    public string GetTitulo() {  return titulo; }  
    public string GetAutor() {  return autor; }
    public int GetPaginas() {  return paginas; }
    
    public void SetTitulo(string titulo) { this.titulo = titulo; }
    public void SetAutor(string autor) { this.autor = autor; }
    public void SetPaginas(int paginas) {  this.paginas = paginas;}
    
    public Documento(string titulo, string autor, int paginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.paginas = paginas;
    }
    public Documento(string titulo) : this (titulo, "Anónimo", 0) { }

    public override string ToString()
    {
        return "Autor = " + autor + ", Título = " + titulo + 
            ", páginas = " + paginas;
    }



}

// ----------------

class Libro : Documento
{
    private char tapa;

    public char GetTapa() { return tapa; }
    public void SetTapa(char tapa) { this.tapa = tapa; }
    public Libro(string titulo, string autor, int paginas, char tapa) 
        : base(titulo, autor, paginas) 
    {
        this.tapa = tapa;
    }

    public override string ToString()
    {
        return base.ToString() + ", Portada = " + tapa; 
    }
}
