/*108. Un número Harshad (http://en.wikipedia.org/wiki/Harshad_number) es un 
número que es divisible por la suma de sus dígitos. Crea una función booleana 
"EsNumeroHarshad", que devuelva true verdadero si el número entero largo 
indicado como parámetro es un número Harshad: if (EsNumeroHarshad(152) ....). 
Crea también un programa de prueba, que pida al usuario un número entero largo 
y responda si es Harshad o no lo es. Para gestionar los errores de introducción 
de datos, no debes usar "try-catch" sino "TryParse" (apartado 5.7.4 de los 
apuntes).*/

// Miguel Ángel (...)

using System;

class FuncionNumHarshad
{
    static bool EsNumeroHarshad(long numero)
    {
        long numero2 = numero;
        int suma = 0;
        
        while(numero2 > 0)
        {
            suma += (int) numero2%10;
            numero2 = numero2/10;
        }
        
        if(numero % suma == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    static void Main()
    {
        long num;
        
        Console.Write("Dame un número: ");
        if (Int64.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Su valor es {0}.", num);
            if(EsNumeroHarshad(num))
            {
                Console.WriteLine("Es número Harshad.");
            }
            else
            {
                Console.WriteLine("No es número Harshad.");
            }
            
        }
        else
        {
            Console.WriteLine("No es un número válido.");
        }
    }
}
