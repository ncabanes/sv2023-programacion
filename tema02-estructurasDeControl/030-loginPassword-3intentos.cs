// Gorka (...)
// Ejercicio 30
// Usuario y contraseña, 3 intentos (do-while)

/*
30. Crea una versión mejorada del ejercicio anterior, en la que el 
usuario sólo tenga 3 intentos. Si al cabo de 3 intentos no ha indicado 
el login y la contraseña correctos, se le responderá con "Acceso 
denegado" y terminará el programa. Si introduce ambos datos de forma 
correcta en 3 intentos o menos, se le dirá "Acceso concedido" y 
terminará el programa. Esta versión hazla sólo una vez, empleando 
"while" o "do-while", como consideres más razonable.
*/

using System;

class Ejercicio_30
{
    static void Main()
    {
        int login, contrasenya, intento = 3;
        
        do
        {
            Console.WriteLine("Introduce tu usuario: ");
            login = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce tu contraseña: ");
            contrasenya = Convert.ToInt32(Console.ReadLine());
            intento = intento - 1;
            
            if (login != 1000 && contrasenya != 1234)
            {
                Console.WriteLine("");
                Console.WriteLine("Usuario o contraseña incorrecto.");
                Console.WriteLine("Le quedan {0} intentos.", intento);
                Console.WriteLine("");
            }
        }
        while (login != 1000 && contrasenya != 1234 && intento > 0);
        
        if (login == 1000 && contrasenya == 1234)
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Acceso denegado.");
        }
    }
}
