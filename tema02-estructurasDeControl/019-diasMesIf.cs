/*

Iván (...)
Programa que dice el mes.

*/

using System;

class Meses
{
    
    static void Main()
    {
        int mes;
        
        Console.Write ("Dime el número de un mes: ");
        mes = Convert.ToInt32(Console.ReadLine());
        
        if ((mes == 1) || (mes == 3) 
                || (mes == 5) || (mes == 7) 
                || (mes == 8) || (mes == 10) 
                || (mes == 12))
            Console.WriteLine ("Tiene 31 días.");
        else if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
            Console.WriteLine ("Tiene 30 días.");
        else if (mes == 2)
            Console.WriteLine("Tiene 28 días");
        else
            Console.WriteLine ("Número de mes no válido");
    }
}
