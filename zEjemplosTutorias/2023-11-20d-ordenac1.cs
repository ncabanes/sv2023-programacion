// Pide al usuario 5 números reales de doble precisión.
// Ordénalos utilizando intercambio directo.

using System;
using System.Text;

class Ordenacion
{
    static void Main()
    {
        double[] datos = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Dame el dato {0}: ", i+1);
            datos[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < datos.Length - 1; i++)
        {
            for (int j = i + 1; j < datos.Length; j++)
                if (datos[i] > datos[j])
                {
                    double aux = datos[i];
                    datos[i] = datos[j];
                    datos[j] = aux;
                }

            // Muestro datos parciales
            Console.WriteLine("Pasada {0}", i+1);
            for (int k = 0; k < 5; k++)
            {
                Console.Write(datos[k] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Resultado: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(datos[i] + " ");
        }
    }
}

// Pasada 1
// 10 50 40 30 20
// Pasada 2
// 10 20 50 40 30
// Pasada 3
// 10 20 30 50 40
// Pasada 4
// 10 20 30 40 50
// Resultado:
// 10 20 30 40 50
