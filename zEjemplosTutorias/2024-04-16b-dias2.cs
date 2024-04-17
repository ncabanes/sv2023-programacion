/*
Muestra la fecha actual, en formato "15-Abril-24 Lunes". 
Ayúdate de un array con los nombres de los meses 
y otro con los nombres de los días de la semana.
*/

using System;

class Prueba
{ 
    static void Main()
    {
        string[] nombresMeses = {"Enero", "Febrero",
            "Marzo", "Abril"};
        string[] nombresDias = {"Domingo", "Lunes", "Martes"};
        DateTime ahora = DateTime.Now;
        Console.WriteLine("{0}-{1}-{2} {3}",
            ahora.Day.ToString("00"),
            nombresMeses[ahora.Month - 1], 
            ahora.Year % 100,
            nombresDias[ (int) ahora.DayOfWeek]
        );

        Console.WriteLine("d= " + ahora.ToString("d"));
        Console.WriteLine("D= " + ahora.ToString("D"));
        Console.WriteLine("g= " + ahora.ToString("g"));
        Console.WriteLine("t= " + ahora.ToString("t"));

    }
}

// 16/04/2024 9:57:15
// 16-4-2024 Tuesday
// 16-Abril-24 Martes

// d = 16 / 04 / 2024
// D = martes, 16 de abril de 2024
// g = 16/04/2024 10:05
// t = 10:05
