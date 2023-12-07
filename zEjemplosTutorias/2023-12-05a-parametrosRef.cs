/*
Crea una función "MaysYMins", que reciba una cadena y devuelva (como 
parámetros "ref") una cadena formada por las letras en mayúsculas que 
contenía y otra formada por las letras en minúsculas que contenía. 
Pruébala desde Main, con un texto prefijado.
*/

using System;

class EjemploRef 
{
    static void MaysYMins(string texto, 
        ref string mays, ref string mins)
    {
        mays = "";
        mins = "";
        foreach(char l in texto)
        {
            if (l >= 'A' && l <= 'Z')
                mays += l;
            if (l >= 'a' && l <= 'z')
                mins += l;
        }
    }
    
    static void Main() 
    {
        string saludo = "Hola Que Tal";
        string ma="", mi="";
        
        MaysYMins(saludo, ref ma, ref mi);
        Console.WriteLine("Mays: "+ma);
        Console.WriteLine("Mins: "+mi);
    }
}

// Mays: HQT
// Mins: olaueal
