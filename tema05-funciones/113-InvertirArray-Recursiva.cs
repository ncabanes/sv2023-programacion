/*
113. Crea una función recursiva "InvertirArray(array, desde, hasta)", que 
invierta la posición de los valores almacenados en un array de enteros, entre 
dos posiciones límite, de forma recursiva. Por ejemplo, si el array contiene 
los datos {10, 20, 30, 40, 50}, una llamada a InvertirArray(datos, 0, 3) 
debería hacer que los datos de la posición 0 a 3 inviertan sus posiciones 
(intercambiando el 0 con el 3, luego el 1 con el 2, y así tantas veces como 
fuera necesario), obteniéndose {40, 30, 20, 10, 50}. Pruébala desde Main, con 
un array prefijado. No es necesario comprobar errores en los parámetros (por 
ejemplo, si se indica un límite superior que sea mayor que la longitud del 
array, el programa "explotará", y es un comportamiento aceptable).
*/
// Mario (...)

using System;

class Ejercicio113
{
    static int[] InvertirArray(int[] numeros, int desde, int hasta)
    {
        int temp;
        if (desde >= hasta)
            return numeros;
        else
        {
            temp = numeros[desde];
            numeros[desde] = numeros[hasta];
            numeros[hasta] = temp;
            
            return InvertirArray(numeros, desde+1, hasta-1);
        }
    }
    
    static void Main()
    {
        int[] datos = new int[] {10, 20, 30, 40, 50};
        int p1 = 0, p2 = 1, p3 = 2, p4 = 3, p5 = 4;
        
        Console.Write("El array original es:                  ");
        foreach(int i in datos)
        {
            Console.Write(i+"  ");
        }
        Console.WriteLine();

        Console.Write("Cambio desde la posición "+p1+" hasta la "+p4+": ");
        foreach(int i in InvertirArray(datos, p1, p4))
        {
            Console.Write(i+"  ");
        }
        Console.WriteLine();
        
        Console.Write("Cambio desde la posición "+p1+" hasta la "+p5+": ");
        foreach(int i in InvertirArray(datos, p1, p5))
        {
            Console.Write(i+"  ");
        }
        Console.WriteLine();

        Console.Write("Cambio desde la posición "+p2+" hasta la "+p3+": ");
        foreach(int i in InvertirArray(datos, p2, p3))
        {
            Console.Write(i+"  ");
        }
    }
}
