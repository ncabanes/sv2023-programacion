/*
 
26. Crea una variante del ejercicio anterior (contraseña numérica), 
empleando en esta ocasión "do-while" (no "while").

25. Escribe un programa en C# que pida al usuario una contraseña numérica.
Se le dirá "Acceso concedido" cuando acierte la contraseña correcta, 1111.
Si no la acierta, se le volverá a pedir tantas veces como sea necesario.
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
            Console.Write("Introduce una contraseña numérica: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());
            if (contrasenya != 1111)
                Console.WriteLine("Contraseña incorrecta");
        }
        while (contrasenya != 1111);
        Console.WriteLine("Acceso concedido !");
    }
}
