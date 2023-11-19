/*84. Crea una versión mejorada del ejercicio anterior, que pida al usuario los 
 * datos de 3 juegos, los guarde en un array y luego los muestre.
 */
 
 //Noelia (...)

using System;

class Ejercicio084
{
    struct tipoJuego
    {
        public string titulo;
        public string plataforma;
        public long espacioMB;
    }

    static void Main()
    {
        const int MAXIMO = 3;

        tipoJuego[] juegos = new tipoJuego[MAXIMO];

        Console.WriteLine("--BIBLIOTECA DE JUEGOS--");
        Console.WriteLine();

        for (int i = 0; i < MAXIMO; i++)
        {
            Console.WriteLine("Juego Nº" + (i+1) + ": ");
            Console.Write("Título del juego: ");
            juegos[i].titulo = Console.ReadLine();
            Console.Write("Plataforma del juego: ");
            juegos[i].plataforma = Console.ReadLine();
            Console.Write("Espacio ocupado (MB): ");
            juegos[i].espacioMB = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Listado de juegos");

        for (int i = 0; i < MAXIMO; i++)
        {
            Console.WriteLine("Juego Nº" + (i+1) + ": ");
            Console.WriteLine("Título del juego: " + juegos[i].titulo);
            Console.WriteLine("Plataforma del juego: " + juegos[i].plataforma);
            Console.WriteLine("Espacio ocupado (MB): " + juegos[i].espacioMB);
            Console.WriteLine();
        }
    }
}
