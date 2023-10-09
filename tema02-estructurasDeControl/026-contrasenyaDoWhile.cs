/*
 
26. Crea una variante del ejercicio anterior (contrase�a num�rica), 
empleando en esta ocasi�n "do-while" (no "while").

25. Escribe un programa en C# que pida al usuario una contrase�a num�rica.
Se le dir� "Acceso concedido" cuando acierte la contrase�a correcta, 1111.
Si no la acierta, se le volver� a pedir tantas veces como sea necesario.
Hazlo con "while" (no con "do-while").

Julio
 */

using System;

class Contrasenya2
{
    static void Main()
    {
        int contrasenya;
        do
        {
            Console.Write("Introduce una contrase�a num�rica: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());
            if (contrasenya != 1111)
                Console.WriteLine("Contrase�a incorrecta");
        }
        while (contrasenya != 1111);
        Console.WriteLine("Acceso concedido !");
    }
}
