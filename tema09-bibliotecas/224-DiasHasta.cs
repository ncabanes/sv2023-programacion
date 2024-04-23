/*224. Crea un programa que pregunte al usuario la fecha 
de fin de curso (día, mes y año) y le diga cuántos 
faltan para llegar.*/

// Javier (...)

using System;

class Ejercicio_224
{
    static void Main(string[] args)
    {
        DateTime ahora = DateTime.Today;

        Console.WriteLine("Introduza la fecha de fin de curso");

        int dia=Convert.ToInt32(Console.ReadLine());
        int mes=Convert.ToInt32(Console.ReadLine());
        int anyo=Convert.ToInt32(Console.ReadLine());

        DateTime finDeCurso = new DateTime(anyo, mes, dia);

        TimeSpan diferencias = finDeCurso - ahora;
        Console.WriteLine("Quedan "+diferencias.Days+" dias");
    }
}
