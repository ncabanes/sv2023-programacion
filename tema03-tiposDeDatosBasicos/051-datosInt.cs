/*
 51. Crea un programa en C# que pida al usuario su edad, su año de nacimiento,
 su estatura en centímetros, cuántos euros (sin céntimos) ahorró el último mes,
 la población de su ciudad y la población estimada del mundo.
 Debes optimizar los tipos de datos usados (todos ellos serán números enteros).
*/

// Jorge (...), retoques por Nacho

using System;

class Ejercicio01
{
    static void Main()
    {
        Console.Write("Introduzca su edad: ");
        byte edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Introduzca su año de nacimiento: ");
        ushort anyoNacimiento = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Introduzca su estatura en cm: ");
        ushort estatura = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Introduzca sus ahorros del mes pasado (sin decimales): ");
        short ahorros = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Introduzca la población de su ciudad: ");
        uint poblacionCiudad = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Introduzca la población, aproximada, del mundo: ");
        ulong poblacionMundo = Convert.ToUInt64(Console.ReadLine());
        Console.WriteLine();
    }
}
