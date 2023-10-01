// Ejercicio_02_18.cs
// Condiciones con switch
// Por Jose Luis (...)

using System;
class condiciones_switch
{
     static void Main()
    {
        
        int num;
        Console.WriteLine("Introduce la nota");
        num = Convert.ToInt32(Console.ReadLine());
        
        switch (num)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine ("Suspenso.");
                break;
            case 5:
                Console.WriteLine ("Aprobado.");
                break;
            case 6:
                Console.WriteLine ("Bien.");
                break;
            case 7:
            case 8:
                Console.WriteLine ("Notable.");
                break;
            case 9:
            case 10:
                Console.WriteLine ("Sobresaliente.");
                break;
            default:
                Console.WriteLine ("Nota incorrecta.");
                break;
        }
    }
}
