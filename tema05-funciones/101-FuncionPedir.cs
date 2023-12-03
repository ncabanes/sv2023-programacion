/*
101. Crea una función "Pedir", que mostrará en pantalla el mensaje de aviso que 
se indique como parámetro y leerá (y devolverá) lo que el usuario introduzca en 
consola. Úsala para crear una nueva versión simplificada del ejercicio 088 
(videojuegos V4), en la que las estructuras como:

Console.Write("Título: ");
juego[cantidad].titulo = Console.ReadLine();
se conviertan en:

juego[cantidad].titulo = Pedir("Título");
*/

// Mario (...)

using System;

class Ejercicio101
{
    struct juegos
    {
        public string titulo;
    }
    
    static string Pedir (string peticion)
    {
        Console.Write(peticion+": ");
        peticion = Console.ReadLine();
        
        return peticion;
    }
    
    static void Main()
    {
        const ushort CAPACIDAD = 1000;
        ushort cantidad = 0;
        juegos[] juego = new juegos[CAPACIDAD]; 
        
        juego[cantidad].titulo = Pedir("Título");
        Console.WriteLine(juego[cantidad].titulo);
    }
}
