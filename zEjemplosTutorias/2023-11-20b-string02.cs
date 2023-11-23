// Pide al usuario un texto formado por varios números
// separados por espacios y muestra la suma de esos números.

using System;

class Strings02
{
    static void Main()
    {
        string frase = Console.ReadLine();
        int suma = 0;

        string[] fragmentos = frase.Split();
        foreach(string trozo in fragmentos) 
        {
            if (trozo != "")
                suma += Convert.ToInt32(trozo);
        }
        Console.WriteLine(suma);
    }
}

// 5 10 15 35 76543
// 76608
