/* Crea una versión actualizada de "sumar", que reciba dos números 
enteros en línea de comandos y devuelva el código:

0 si todo ha ido bien
1 si faltan parámetros
2 si algún dato no es numérico

*/

using System;

class Sumar 
{
    static int Main(string[] args) 
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Esperaba dos números");
            return 1;
        }
        else
        {
            try
            {
                int n1 = Convert.ToInt32( args[0] );
                int n2 = Convert.ToInt32( args[1] );
                Console.WriteLine(n1+n2);
                return 0;
            }
            catch( Exception )
            {
                Console.WriteLine("Algún dato no es numérico");
                return 2;
            }
        }
        
    }
}

// "%e.exe" 12 34
// 46

