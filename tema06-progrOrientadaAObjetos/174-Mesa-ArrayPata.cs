/*
174. Crea una versión mejorada del ejercicio anterior, en la que las 
mesas podrán tener varias patas, y además haya un constructor en Pata, 
que permita indicar su alto y su color, y un ToString que escriba "Pata 
" seguido de ambos detalles. Crea un constructor en Mesa que permita 
indicar su ancho, su alto y su color. Crea otro constructor que sólo 
reciba el ancho y el alto, y prefije el color a "blanco". Incluye 
también un método "AnayadirPata", que reciba los datos de una de las 
patas sobre las que se apoya la mesa. Crea un ToString en la clase 
Mesa, que mostrará "Mesa " seguido de su ancho, su alto, su color, y 
los detalles de cada una de sus patas. En el "Main" de prueba, añade 
cuatro patas, crea una mesa que las contenga y muestra los datos de esa 
mesa.
*/

// Katherin (...)

using System;

class Mesa
{
    private string color;
    private int largo;
    private int ancho;
    private Pata[] patas = new Pata[6];
    private int cantidadPatas = 0;

    public Mesa(string color, int largo, int ancho)
    {
        this.color = color;
        this.largo = largo;
        this.ancho = ancho;
    }

    public Mesa(int largo, int ancho)
    {
        this.largo=largo;
        this.ancho=ancho;
        color = "blanco";
    }

    public string GetColor() { return color; }
    public void SetColor(string color) { this.color = color; }

    public int GetAncho() { return ancho; }
    public void SetAncho(int ancho) { this.ancho = ancho; }

    public int GetLargo() { return largo; }
    public void SetLargo(int largo) { this.largo = largo; }

    public void anyadirPata(Pata pata)
    {
        patas[cantidadPatas] = pata;
        cantidadPatas++;
    }

    public override string ToString()
    {
        string texto = "Mesa " + ancho + " " + largo + " " + color;
        for(int i=0; i<cantidadPatas; i++)
        {
            texto += "\n" + patas[i].ToString();
        }
        return texto;
    }

}

class Pata
{
    private string color;
    private int alto;

    public Pata(int alto, string color) 
    {
        this.color = color;
        this.alto = alto;
    }

    public string GetColor() { return color; }
    public void SetColor(string color) { this.color = color; }
    public int GetAlto() { return alto; }
    public void SetAlto(int alto) { this.alto = alto; }

    public override string ToString()
    {
        return "Pata" + " " + alto + " " + color;
    }
}

class Prueba
{
    public static void Main(string[] args)
    {
        Pata p = new Pata(12, "azul");
        Pata p2 = new Pata(12, "rojo");
        Pata p3 = new Pata(10, "verde");
        Pata p4 = new Pata(8, "azul");
        Mesa m = new Mesa(5, 3);
        m.anyadirPata(p);
        m.anyadirPata(p2);
        m.anyadirPata(p3);
        m.anyadirPata(p4);
        Console.WriteLine(m.ToString());
    }
}

