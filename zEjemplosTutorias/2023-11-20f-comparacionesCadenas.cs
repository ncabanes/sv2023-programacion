// Ejemplo de compración de cadenas

using System;

class ComparacionCadenas
{
    static void Main()
    {
        // Comparación de números
        int[] datos = { 3, 5, 2};
        int i = 1;

        if (datos[i] > datos[i + 1])
            Console.WriteLine("Al revés");

        // Comparación de cadenas, 
        // puede fallar si hay mayúsculas y minúsculas mezcaldas
        string[] textos = { "hoy", "ayer", "mañana" };

        if (textos[i].CompareTo( textos[i+1]) > 0)
            Console.WriteLine("Al revés");
        // ...

        // Comparación insensible a mayúsculas, artesanal
        string[] textos2 = { "HOY", "ayer", "mañana" };

        if (textos2[i].ToUpper().CompareTo(textos2[i + 1].ToUpper()) > 0)
            Console.WriteLine("Al revés");

        // Comparación insensible a mayúsculas, string.Comparte
        if (String.Compare(textos2[i], textos2[i + 1], true ) > 0)
            Console.WriteLine("Al revés");
    }
}
