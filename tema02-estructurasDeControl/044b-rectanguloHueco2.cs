// Gorka (...), retoques por Nacho
// Ejercicio 44
// Rectágulo hueco

using System;

class RectanguloHuecoVersion2
{
    static void Main()
    {
        int ancho, alto, numero;
        
        Console.Write("Ancho? ");
        ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Alto? ");
        alto = Convert.ToInt32(Console.ReadLine());
        Console.Write("Número? ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        // Primera fila
        for (int fila = 1; fila <= ancho; fila++)
        {
            Console.Write("{0}", numero);
        }
        Console.WriteLine();
        
        // Zona central
        for (int fila = 1; fila <= alto - 2; fila++)
        {
            Console.Write(numero);
            for (int columna = 1; columna <= ancho-2; columna++)
            {
                    Console.Write(" ");
            }
            Console.WriteLine(numero);
        }
        
        // Última fila
        for (int fila = 1; fila <= ancho; fila++)
        {
            Console.Write("{0}", numero);
        }
    }
}
