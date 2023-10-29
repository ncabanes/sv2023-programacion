// Ej 56- Pide al usuario un número entero largo y respóndele cuántas cifras 
// tiene. Lo puedes conseguir dividiendo entre 10 tantas veces como sea
// necesaria hasta que el número se convierta en 0.

// Por Nuria (...)

using System;

class CifrasNumero
{
    static void Main()
    {
        long numero;
        byte cifras;
        
        Console.Write("Introduce un número entero largo: ");
        numero = Convert.ToInt64(Console.ReadLine());
        
        cifras=0;
        do
        {
            numero=numero/10;
            cifras++;
        }        
        while (numero!=0);
        
        Console.WriteLine("El número tiene {0} cifra(s)", cifras);
    }
}
