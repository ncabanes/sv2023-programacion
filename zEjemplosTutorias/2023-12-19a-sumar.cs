/*
Crea un programa llamado "sumar", que reciba dos números enteros en 
línea de comandos y muestre su suma, como en este ejemplo:

sumar 123 456
579
*/

using System;

class Sumar 
{
    static void Main(string[] args) 
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Esperaba dos números");
        }
        else
        {
            int n1 = Convert.ToInt32( args[0] );
            int n2 = Convert.ToInt32( args[1] );
            Console.WriteLine(n1+n2);
        }
        
    }
}

// "%e.exe" 12 34
// 46

