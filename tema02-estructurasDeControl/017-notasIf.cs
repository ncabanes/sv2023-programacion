/*
17. Crea un programa en C# que muestre el "nombre de la nota" 
correspondiente a una determinada "nota numérica", 
según el sistema clásico español, usando la siguiente equivalencia:

9,10 = Sobresaliente

7,8 = Notable

6 = Bien

5 = Aprobado

0-4 = Suspenso

Tu programa debe solicitar al usuario una nota numérica (por ejemplo, "7")
y mostrar la nota de texto correspondiente (por ejemplo, "Notable"),
o el texto "Nota incorrecta", si procede. Hazlo empleando "if"+"else".

Julius
 */

using System;

class E17
{
    public static void Main()
    {
        Console.Write("Introduce la nota del alumno: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 0 && nota <= 4)
        {
            Console.Write("Suspenso");
        }
        else if (nota == 5)
        {
            Console.Write("Aprobado");
        }
        else if (nota == 6)
        {
            Console.Write("Bien");
        }
        else if (nota == 7 || nota == 8)
        {
            Console.Write("Notable");
        }
        else if (nota == 9 || nota == 10)
        {
            Console.Write("Sobresaliente");
        }
        else 
        { 
            Console.WriteLine("Nota incorrecta"); 
        }
    }
}
