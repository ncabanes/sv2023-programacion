// Gorka (...)
// Ejercicio 20
// Días del mes (switch)

using System;

class Ejercicio20
{
    static void Main()
    {
        int n;
        
        Console.WriteLine("Introduce el número del mes: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        switch (n)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12: 
                Console.WriteLine("31 días."); 
                break;
            
            case 4:
            case 6:
            case 9:
            case 11: 
                Console.WriteLine("30 días."); 
                break;
            
            case 2: 
                Console.WriteLine("28 días o 29 si es bisiesto.");
                break;
            
            default: 
                Console.WriteLine("Mes no válido."); 
                break;
        }
    }
}

