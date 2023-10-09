/* JAVIER (..)

Crea una versión mejorada del ejercicio de la contraseña numérica, en 
la que se pida al usuario tanto su login (que será el número 1000) como 
su contraseña (que será 1234). No se le permitirá seguir hasta que 
introduce ambos datos correctos. Esta versión hazla sólo una vez, 
empleando "while" o "do-while", como consideres más razonable.
*/

using System;

class Ejercicio2_29
{
    static void Main()
    {
        //Variables declaradas.
        int usuario , contrasenya;
        
        do {
            Console.WriteLine("Introduce el número de usuario:");
            usuario = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introduce la contraseña:");
            contrasenya = Convert.ToInt32(Console.ReadLine());
            
        }
        while((usuario != 1000) || (contrasenya != 1234));
        
        Console.WriteLine("Iniciando sesión.");
    }
}
