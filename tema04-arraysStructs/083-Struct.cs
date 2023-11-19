/*
83. Crea un "struct" para almacenar algunos datos de juegos de ordenador o 
consola, de momento sólo: título (cadena de texto), plataforma (cadena de 
texto), espacio ocupado (en MB, número entero). Pide al usuario datos de 2 
juegos (sin usar todavía ningún array) y luego muéstralos.
*/

// Francisco (...)

using System;

class Ejercicio83
{
    struct Juegos
    {
        public string titulo;
        public string plataforma;
        public int espacioOcupado;
    }

    static void Main()
    {
        Juegos juego1, juego2;

        Console.WriteLine("Introduce los valores para 2 juegos: ");

        Console.Write("Título primer juego: ");
        juego1.titulo = Console.ReadLine();
        Console.Write("Plataforma primer título: ");
        juego1.plataforma = Console.ReadLine();
        Console.Write("Tamaño del juego (en MB): ");
        juego1.espacioOcupado = Convert.ToInt32(Console.ReadLine());

        Console.Write("Título segundo juego: ");
        juego2.titulo = Console.ReadLine();
        Console.Write("Plataforma segundo título: ");
        juego2.plataforma = Console.ReadLine();
        Console.Write("Tamaño del juego (en MB): ");
        juego2.espacioOcupado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Has introducido estos valores:");
        Console.WriteLine("Juego 1: ");
        Console.WriteLine("Titulo: {0}", juego1.titulo);
        Console.WriteLine("Plataforma: {0}", juego1.plataforma);
        Console.WriteLine("Espacio Ocupado: {0}", juego1.espacioOcupado);
        Console.WriteLine("Juego 2: ");
        Console.WriteLine("Titulo: {0}", juego2.titulo);
        Console.WriteLine("Plataforma: {0}", juego2.plataforma);
        Console.WriteLine("Espacio Ocupado: {0}", juego2.espacioOcupado);
    }
}
