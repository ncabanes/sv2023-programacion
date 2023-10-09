/*
 25. Escribe un programa en C# que pida al usuario una contraseña numérica. 
Se le dirá "Acceso concedido" cuando acierte la contraseña correcta, 1111. 
Si no la acierta, se le volverá a pedir tantas veces como sea necesario.
Hazlo con "while" (no con "do-while").
*/

// Julio (...)

using System;

class Contrasenya1
{
    static void Main()
    {
        int contrasenya;
        Console.Write("Introduce una contraseña numerica: ");
        contrasenya = Convert.ToInt32(Console.ReadLine());

        while (contrasenya != 1111)
        {
            Console.WriteLine("Contraseña incorrecta");
            Console.Write("Introduce una contraseña numerica: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Acceso concedido !");
    }
}
