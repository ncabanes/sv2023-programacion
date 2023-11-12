/*
 77. Crea un programa que pregunte al usuario cuántos datos (enteros largos) va a introducir,
reserve espacio para todos ellos, se los pida al usuario y finamente muestre los números
que estén duplicados. Por ejemplo, si los números son 12 23 36 23 45, la respuesta sería "Duplicados: 23". 
Si no hubiera ningún duplicado, la respuesta deberá ser "Duplicados: Ninguno". 
Si algún dato aparece más de dos veces (por ejemplo, 12 23 36 23 45 23) puede que la respuesta sea "fea": 
"Duplicados: 23 23", pero eso no debe preocuparte.

Julio, retoques menores por Nacho

*/

using System;

// Versión mejorada: 
// - filtra alguna repetición múltiple (no todas)
// - avisa si no hay repetidos

class BuscadorDuplicadosV2  
{
    public static void Main()
    {
        Console.Write("Cuántos datos vas a introducir: ");
        long cantidadDatos = Convert.ToInt64(Console.ReadLine());
        long[] datos = new long[cantidadDatos];
        byte contadorDuplicados = 0;
        bool duplicado = false;


        for (int i = 0; i < cantidadDatos; i++)
        {
            Console.Write("introduce los datos \"{0}\" : ", i + 1);
            datos[i] = Convert.ToInt64(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Duplicados: ");

        for (int i = 1; i < cantidadDatos; i++)
        {
            contadorDuplicados = 0;
            for (int j = 0; j < i; j++)
            {
                if (datos[j] == datos[i])
                {
                    contadorDuplicados++;

                    if (contadorDuplicados == 1)
                    {
                        Console.Write(datos[j] + " ");
                        duplicado = true;
                    }
                }
            }
        }

        if (!duplicado)
        {
            Console.Write("Ninguno");
        }
        Console.WriteLine();
    }
}
