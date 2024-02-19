/*
Crea una clase Mesa y una clase Pata, ambas con un color (string). 
Además, la mesa debe contener una pata. Crea getters y setters para el 
color de cada una de ellas. La mesa tendrá también un largo y un ancho 
(con sus getters y setters) y la pata tendrá un alto (ídem). En tu 
"Main" de prueba, prefija el tamaño y colores de una mesa y su (única) 
pata.
*/

// Katherin (...), retoques menores por Nacho

using System;

class Mesa
{
    private string color;
    private int largo;
    private int ancho;
    private Pata pata;

    public string GetColor() { return color; }
    public void SetColor(string color) { this.color = color; }
    
    public int GetAncho() { return ancho; }
    public void SetAncho(int ancho) { this.ancho = ancho; }
    
    public int GetLargo() { return largo; }
    public void SetLargo(int largo) { this.largo = largo; }
    
    public Pata GetPata() { return pata; }
    public void SetPata(Pata pata) { this.pata = pata; }
}

class Pata
{
    private string color;
    private int alto;

    public string GetColor() { return color; }
    public void SetColor(string color) { this.color = color; }
    public int GetAlto() { return alto; }
    public void SetAlto(int alto) { this.alto = alto; }
}

class Prueba
{
    public static void Main(string[] args)
    {
        Mesa m = new Mesa();
        m.SetColor("azul");
        m.SetAncho(4);
        m.SetLargo(3);
        
        Pata p = new Pata();
        p.SetAlto(2);
        p.SetColor("blanco");
    }
}

