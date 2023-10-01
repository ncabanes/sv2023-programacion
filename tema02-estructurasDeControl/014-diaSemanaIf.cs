/*14. Crea un programa en C# que muestre el nombre de un día de la semana a 
partir de su número (del 1 al 7) introducido por el usuario, usando "if". 
Por ejemplo, si el usuario introduce el número "2", tu programa deberá responder "martes". 
Si introduce un número menor que 1 o mayor que 7, deberá decir "día no válido"*/

//Noelia (...)

using System;

class Ejercicio014
{
    static void Main()
    {
        int diaSemana;
        
        Console.Write("Introduce un número del 1 al 7: ");
        diaSemana=Convert.ToInt32(Console.ReadLine());
        
        if (diaSemana == 1)
            Console.WriteLine("lunes"); 
        else if (diaSemana == 2)
            Console.WriteLine("martes");
        else if (diaSemana == 3)
            Console.WriteLine("miercoles");
        else if (diaSemana == 4)
            Console.WriteLine("jueves");
        else if (diaSemana == 5)
            Console.WriteLine("viernes");
        else if (diaSemana == 6)
            Console.WriteLine("sabado");
        else if (diaSemana == 7)
            Console.WriteLine("domingo");
        else
            Console.WriteLine("Día no válido" );
    }
}
