/*
135. Crea una clase "Fichero", con atributos "nombre", "ubicacion", "tamanyoBytes". 
Crea Getters, Setters y un constructor que de valor a los tres atributos a la vez. 
Crea una clase "FicheroImagen" que añada los atributos "formato", "ancho" y "alto".
Añade un Main de prueba, que cree un objeto de cada tipo.
*/

// Julio

using System;

class Fichero
{
    protected string nombre;
    protected string ubicacion;
    protected int tamanyoBytes;

    public string GetNombre() { return nombre; }
    public string GetUbicacion() { return ubicacion; }
    public int GetTamanyoBytes() { return tamanyoBytes; }

    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetUbicacion(string nuevaUbicaion) { ubicacion = nuevaUbicaion; }
    public void SetNuevoTamanyo(int nuevoTamanyo) { tamanyoBytes = nuevoTamanyo; }

    public Fichero() { }
    public Fichero(string nuevoNombre, string nuevUubicacion, int nuevoTamanyoBytes)
    {
        nombre = nuevoNombre;
        ubicacion = nuevUubicacion;
        tamanyoBytes = nuevoTamanyoBytes;
    }

    public void Mostrar()
    {
        Console.WriteLine(nombre);
        Console.WriteLine(ubicacion);
        Console.WriteLine(tamanyoBytes);
        Console.WriteLine();
    }
}

//_____________________________________________

class FicheroImagen : Fichero
{
    protected string formato;
    protected int ancho;
    protected int alto;

    public string GetFormato() { return formato; }
    public int GetAncho() { return ancho; }
    public int GetAlto() { return alto; }

    public void SetFormato(string nuevoFormato) { formato = nuevoFormato; }
    public void SetAncho(int nuevoAncho) { ancho = nuevoAncho; }
    public void SetAlto(int nuevoAlto) { alto = nuevoAlto; }

    public FicheroImagen(
        string nuevoNombre, string nuevUubicacion, int nuevoTamanyoBytes, 
        string nuevoFormato, int nuevoAncho, int nuevoAlto)
    {
        nombre = nuevoNombre;
        ubicacion = nuevUubicacion;
        tamanyoBytes = nuevoTamanyoBytes;
        formato = nuevoFormato;
        ancho = nuevoAncho;
        alto = nuevoAlto;
    }

    public void Mostrar()
    {
        Console.WriteLine(nombre);
        Console.WriteLine(ubicacion);
        Console.WriteLine(tamanyoBytes);
        Console.WriteLine(formato);
        Console.WriteLine(ancho);
        Console.WriteLine(alto);
    }
}

//_____________________________________________

class MainDePrueba
{
    static void Main()
    {
        Fichero ficheros = new Fichero("futbol", "b1", 2000);
        ficheros.Mostrar();
        FicheroImagen ficheroImagenes = new FicheroImagen("baloncesto",
            "c3", 1600, "png", 20, 23);
        ficheroImagenes.Mostrar();
    }
}

