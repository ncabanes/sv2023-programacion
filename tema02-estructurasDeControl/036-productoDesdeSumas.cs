// Ejercicio_02_36cs
// Condiciones for6
// Por Jose Luis (...)

/*
36. Crea un programa que pida al usuario dos números enteros y muestre 
su producto, empleando sumas repetitivas. Recuerda que 3 * 4 = 3 + 3 + 
3 + 3 (4 sumandos) = 12.
*/

using System;

class condiciones_for6
{
    static void Main()
    {
        int num1, num2, producto=0;
        
        Console.WriteLine ("Elige un número");
        num1 = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine ("Elige un otro");
        num2 = Convert.ToInt32( Console.ReadLine() );   
    
        for (int i=1; i <= num2; i++)
        {
            producto += num1;
        }
        Console.WriteLine("El producto de {0} x {1} es: {2} ",
            num1,num2, producto);
    }
}
                
    
