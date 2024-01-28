/* 152. Crea una clase llamada "PseudoRandom", que permita generar 
"falsos números aleatorios". En ella, crea un método estático "Get" que 
devolverá los milisegundos del reloj del sistema actual (deberás usar 
"DateTime.Now.Millisecond"). Crea un "Main",dentro de una clase 
"PruebaRandom", para probarla. */

// Eric (...), retoques menores por Nacho

using System;

class PseudoRandom
{
    public static int Get()
    {
        return DateTime.Now.Millisecond;
    }
}

class PruebaRandom
{
    static void Main(string[] args)
    {
        int n1 = 0;
        do
        {
            n1 = PseudoRandom.Get();
            Console.Write(n1 + " ");
        } while (n1 != 30);
    }
}
