/*
175. Crea una nueva versión del ejercicio anterior, que, en vez de 
Getters y Setters, use propiedades en formato corto. Añade una clase 
Mesita, que herede de Mesa. El constructor de la mesita recibirá el 
color y prefijará el largo a 60 y el ancho a 40. Haz un "Main" de 
prueba que cree un array de 3 mesas con datos prefijados y luego 
muestre esas 3 mesas.
*/

// Katherin (...)

using System;

class Mesa
{
    protected string color;
    protected int largo;
    protected int ancho;
    protected Pata[] patas = new Pata[4];
    protected int ocupados = 0;

    public Mesa(string color, int largo, int ancho)
    {
        this.color = color;
        this.largo = largo;
        this.ancho = ancho;
    }

    public Mesa(int largo, int ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
        color = "blanco";
    }

    public string Color { get; set; }
    public int Ancho { get; set; }
    public int Largo { get; set; }

    public void anyadirPata(Pata pata)
    {
        patas[ocupados] = pata;
        ocupados++;
    }

    public override string ToString()
    {
        string texto = "Mesa " + ancho + " " + largo + " " + color;
        for (int i = 0; i < ocupados; i++)
        {
            texto += "\n" + patas[i].ToString();
        }
        return texto;
    }

}

class Mesita : Mesa
{
    public Mesita(string color) :base(color,60,40)
    {
        this.color = color;
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

    public string Color { get; set; }
    public string Alto { get; set; }

    public override string ToString()
    {
        return "Pata" + " " + alto + " " + color;
    }
}

class Prueba
{
    public static void Main(string[] args)
    {
        Mesa[] mesas = new Mesa[3];
        Pata p = new Pata(12, "azul");
        Pata p2 = new Pata(12, "rojo");
        Pata p3 = new Pata(10, "verde");
        Pata p4 = new Pata(8, "azul");
        Mesa m = new Mesa(5, 3);
        m.anyadirPata(p);
        m.anyadirPata(p2);
        m.anyadirPata(p3);
        m.anyadirPata(p4);
        mesas[0] = m;
        Mesa m2 = new Mesa("rojo",4, 2);
        m2.anyadirPata(p2);
        m2.anyadirPata(p4);
        mesas[1] = m2;
        Mesita m3 = new Mesita("verde");
        m3.anyadirPata(p);
        mesas[2] = m3;

        for(int i=0; i<mesas.Length; i++)
        {
            Console.WriteLine(mesas[i].ToString());
            Console.WriteLine();
        }
    }
}

