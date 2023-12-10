/*
110. Crea una función "Potencia(n1, n2)", que calcule y devuelva el resultado 
de elevar un primer número natural (que se indique como primer parámetro) a 
otro segundo número natural (que se indique como segundo parámetro), a base de 
multiplicaciones repetitivas, de forma "iterativa" (no recursiva), usando la 
orden "for" (por ejemplo, "Potencia(3,2)" calculará (y devolverá) 3*3, mientras 
que "Potencia(2,3)" calculará 2*2*2. Crea una función "PotenciaR", que calcule 
y devuelva una potencia como la anterior, pero de forma recursiva (por ejemplo, 
puede tomar como caso base que el segundo número sea 0). Prueba ambas desde 
Main.
*/
// Mario (...)

using System;

class Ejercicio110
{
    static int Potencia(int n1, int n2)
    {
        int potencia = 1;
        for (int i = 0; i<n2; i++)
        {
            potencia *= n1;
        }
        
        return potencia;
    }
    
    static int PotenciaR(int n1, int n2)
    {
        if (n2 == 0)
            return 1;
        else
            return n1 * PotenciaR(n1, n2-1);
    }
    
    static void Main()
    {
        int n0 = 0;
        int n1 = 2;
        int n2 = 3;
        Console.WriteLine("De forma iterativa:");
        Console.WriteLine("Usando los número "+n1+" y "+n0+
            " obtenemos: "+Potencia(n1, n0));
        Console.WriteLine("Usando los número "+n1+" y "+n2+
            " obtenemos: "+Potencia(n1, n2));
        Console.WriteLine("Usando los número "+n2+" y "+n1+
            " obtenemos: "+Potencia(n2, n1));
        
        Console.WriteLine("De forma recursiva:");
        Console.WriteLine("Usando los número "+n1+" y "+n0+
            " obtenemos: "+PotenciaR(n1, n0));
        Console.WriteLine("Usando los número "+n1+" y "+n2+
            " obtenemos: "+PotenciaR(n1, n2));
        Console.WriteLine("Usando los número "+n2+" y "+n1+
            " obtenemos: "+PotenciaR(n2, n1));
    }
}
