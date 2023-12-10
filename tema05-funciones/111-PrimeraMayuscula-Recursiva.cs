/*111. Crea una función "PrimeraMayuscula(txt)", que devuelva la primera letra 
en mayúsculas de una cadena que se le pase como parámetros. No devolverá un 
dato de tipo "char", sino un "string", de modo que se pueda devolver una cadena 
vacía en caso de que no exista ninguna letra en mayúsculas. Hazlo tanto de 
forma iterativa ("PrimeraMayuscula") como de forma recursiva 
("PrimeraMayusculaR"). Prueba ambas desde Main, con tres cadenas prefijadas.*/

// Miguel Ángel (...)

using System;

class funcPrimeraMayRec
{
    static string PrimeraMayuscula(string txt)
    {
        string primeraMay = "";
        ushort contadorLetras = 0;
        
        do
        {
            if (txt[contadorLetras] >= 'A' && txt[contadorLetras] <= 'Z')
            {
                primeraMay += txt[contadorLetras];
            }
            contadorLetras ++;
        }
        while (primeraMay == "" && contadorLetras < txt.Length);
        return primeraMay;
    }
    
    static string PrimeraMayusculaR(string txt)
    {
        if (txt.Length == 0)
        {
            return txt;
        }
        if (txt[0] >= 'A' && txt[0] <= 'Z')
        {
            return txt.Substring(0, 1);
        }
        else
        {
            return PrimeraMayusculaR(txt.Remove(0, 1));
        }
    }
    
    static void Main()
    {
        string texto1 = "JaValí", texto2 = "archiDUque", 
            texto3 = "programación";
            
        Console.WriteLine("Texto: {2}, Iterativo: {0}, Recursivo: {1}.", 
            PrimeraMayuscula(texto1), PrimeraMayusculaR(texto1), texto1);
            
        Console.WriteLine("Texto: {2}, Iterativo: {0}, Recursivo: {1}.", 
            PrimeraMayuscula(texto2), PrimeraMayusculaR(texto2), texto2);
        
        Console.WriteLine("Texto: {2}, Iterativo: {0}, Recursivo: {1}.", 
            PrimeraMayuscula(texto3), PrimeraMayusculaR(texto3), texto3);
    }
}
