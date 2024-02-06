/* Crea una clase Cadena, que internamente contenga un "string". 
Sobrecarga el operador "*", para poder "multiplicar una cadena por un 
número". Por ejemplo, el texto "Hola", si se multiplica por 3, 
generaría "HolaHolaHola". */


using System;

class Cadena
{
    private string texto;
    
    public Cadena(string texto)
    {
        this.texto = texto;
    }
    
    public override string ToString()
    {
        return texto;
    }
    
    public static Cadena operator * (Cadena c, int n)
    {
        string textoTemporal = "";
        for (int i = 0; i < n; i++)
        {
            textoTemporal += c;
        }
        return new Cadena(textoTemporal);
    }
}

class PruebaCadena
{
    static void Main() 
    {
        Cadena c = new Cadena("hola");
        Console.WriteLine( c*3 );
    }
}

// holaholahola
