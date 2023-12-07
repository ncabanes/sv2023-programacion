/* Crea una función recursiva "ExtraerMayusculas", que reciba como 
parámetro una cadena de texto y devuelva un nueva cadena formada por 
las letras en mayúsculas que aparecían en la cadena original.
*/

using System;

class Recursividad2ExtraerMayusculas
{
    static string ExtraerMayusculasIterativa(string texto)
    {
        string mays = "";
        foreach(char c in texto)
            if (c >= 'A' && c <= 'Z')
                mays += c;
        
        return mays;
    }
    
    static string ExtraerMayusculas(string texto)
    {
        // Caso base
        if (texto == "")
            return "";
        
        // Caso general
        
        //OLA -> HOLA
        //MOLA -> MOLAR
        
        if (texto[0] >= 'A' && texto[0] <= 'Z')
            return texto[0] + ExtraerMayusculas(texto.Substring(1));
        else
            return ExtraerMayusculas(texto.Substring(1));
    }
    
    static void Main() 
    {
        Console.WriteLine(ExtraerMayusculasIterativa("Hola Que TalM"));
        Console.WriteLine(ExtraerMayusculas("Hola Que TalM"));
    }
}

// HQTM
// HQTM

