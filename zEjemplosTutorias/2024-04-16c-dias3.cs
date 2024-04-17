/*
Calcula cuántos días quedan hasta que empiecen los 
exámenes (20 de mayo).
*/

using System;

class Prueba
{ 
    static void Main()
    {
        DateTime ahora = DateTime.Now;
        DateTime diaExamen = new DateTime(2024, 05, 22);

        TimeSpan tiempoRestante = diaExamen - ahora;

        Console.WriteLine(tiempoRestante.Days);
    }
}

// 35
