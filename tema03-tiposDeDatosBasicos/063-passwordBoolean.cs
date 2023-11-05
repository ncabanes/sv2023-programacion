/* 63. Realiza una nueva versión del programa de la contraseña de acceso 
 * con 3 intentos, pero esta vez pidiendo un login (que será una cadena 
 * de texto) y también una clave (otra cadena de texto). 
 * Usa una variable booleana llamada "acertado" y otra llamada 
 * "intentosAgotados".
 */
 
 // Juan Luis (...)

using System;

class Ejercicio63
{
    static void Main ()
    {
        byte i=3;
        string login, clave;
        bool acertado, intentosAgotados;
        
        do
        {    
            Console.WriteLine("Dime el login");
            login = Console.ReadLine();
            Console.WriteLine("Dime el password");
            clave = Console.ReadLine();
            
            acertado = (login == "admin" || clave == "1234");
            
            if (! acertado)
            {
                i--;
                Console.WriteLine ("Usuario o contraseña erroneos");
                Console.WriteLine ("Te quedan {0} intentos", (i));
            }
            
            intentosAgotados = i == 0;
        }
        while((! acertado) && (! intentosAgotados));
        
        if (acertado)
        {
            Console.WriteLine ("Acceso concedido");
        }  
        else
        {
            Console.WriteLine ("Acceso denegado");
        }
    }
}

