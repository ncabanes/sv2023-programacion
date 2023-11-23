// Pide al usuario 5 números reales de doble precisión.
// Ordénalos utilizando intercambio directo.

// Versión ampliada, que muestra como ordenar cadenas de texto

using System;

class OrdenarNumerosYCadenas
{
    static void Main()
    {
        double[] datos = { 50, 20, 30, 10, 40 };

        for (int i = 0; i < datos.Length - 1; i++)
        {
            for (int j = i + 1; j < datos.Length; j++)
                if (datos[i] > datos[j])
                {
                    double aux = datos[i];
                    datos[i] = datos[j];
                    datos[j] = aux;
                }

            Console.WriteLine("Pasada: {0}",i+1);
            foreach (double d in datos)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
        }
        
        // Y ahora un ejemplo que ordena textos usando la misma lógica


        string[] palabras = { "hola", "adios", "c#" };
        for (int i = 0; i < palabras.Length - 1; i++)
            for (int j = i + 1; j < palabras.Length; j++)
                if (palabras[i].CompareTo(palabras[j]) > 0)
                {
                    string aux = palabras[i];
                    palabras[i] = palabras[j];
                    palabras[j] = aux;
                }
        
        foreach (string p in palabras)
        {
            Console.Write(p + " ");
        }
        
        // Y la alternativa insensible a mayúsculas / minúsculas

        string[] palabras2 = { "hola", "adios", "C#" };
        for (int i = 0; i < palabras2.Length - 1; i++)
            for (int j = i + 1; j < palabras2.Length; j++)
                if (string.Compare(palabras2[i], palabras2[j], true ) > 0)
                {
                    string aux = palabras2[i];
                    palabras2[i] = palabras2[j];
                    palabras2[j] = aux;
                }

        foreach (string p in palabras)
        {
            Console.Write(p + " ");
        }
    }
    
}

// Pasada: 1
// 10 50 30 20 40
// Pasada: 2
// 10 20 50 30 40
// Pasada: 3
// 10 20 30 50 40
// Pasada: 4
// 10 20 30 40 50
// adios c# hola
