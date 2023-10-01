/* 15. Crea una variante del programa anterior, empleando "switch": mostrará el 
nombre de un día de la semana a partir de su número (del 1 al 7) introducido 
por el usuario. Por ejemplo, si el usuario introduce el número "2", tu programa 
deberá responder "martes". Si introduce un número menor que 1 o mayor que 7, 
deberá decir "día no válido". */

/* Mónica (...) */

using System;

class Ejercicio15
{
    static void Main ()
    {
        int dia;
        
        Console.Write ("Qué día de la semana quieres ver, introduce un número:");
        dia = Convert.ToInt32(Console.ReadLine());
        
        switch(dia) 
        {
            case 1: 
                Console.WriteLine(" Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default: 
                Console.WriteLine("Este día no es válido");
                break;
        }
    }
}
