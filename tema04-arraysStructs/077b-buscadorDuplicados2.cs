/*
 77. Crea un programa que pregunte al usuario cu�ntos datos (enteros largos) va a introducir,
reserve espacio para todos ellos, se los pida al usuario y finamente muestre los n�meros
que est�n duplicados. Por ejemplo, si los n�meros son 12 23 36 23 45, la respuesta ser�a "Duplicados: 23". 
Si no hubiera ning�n duplicado, la respuesta deber� ser "Duplicados: Ninguno". 
Si alg�n dato aparece m�s de dos veces (por ejemplo, 12 23 36 23 45 23) puede que la respuesta sea "fea": 
"Duplicados: 23 23", pero eso no debe preocuparte.

Julio, retoques menores por Nacho

*/

using System;

// Versi�n mejorada: 
// - filtra alguna repetici�n m�ltiple (no todas)
// - avisa si no hay repetidos

class BuscadorDuplicadosV2  
{
    public static void Main()
    {
        Console.Write("Cu�ntos datos vas a introducir: ");
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
