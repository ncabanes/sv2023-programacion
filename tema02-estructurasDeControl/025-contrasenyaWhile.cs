/*
 25. Escribe un programa en C# que pida al usuario una contrase�a num�rica. 
Se le dir� "Acceso concedido" cuando acierte la contrase�a correcta, 1111. 
Si no la acierta, se le volver� a pedir tantas veces como sea necesario.
Hazlo con "while" (no con "do-while").
*/

// Julio (...)

using System;

class Contrasenya1
{
    static void Main()
    {
        int contrasenya;
        Console.Write("Introduce una contrase�a numerica: ");
        contrasenya = Convert.ToInt32(Console.ReadLine());

        while (contrasenya != 1111)
        {
            Console.WriteLine("Contrase�a incorrecta");
            Console.Write("Introduce una contrase�a numerica: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Acceso concedido !");
    }
}
