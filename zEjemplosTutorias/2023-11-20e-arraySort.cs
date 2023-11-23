// Pide al usuario 5 números enteros largos.
// Ordénalos con Array.Sort.
// Luego comprueba si el 10 era uno de ellos, utilizando búsqueda binaria.

using System;

class BusquedaBinaria
{
    static void Main()
    {
        int[] datos = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Dame el dato {0}: ", i+1);
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(datos);

        Console.WriteLine("Resultado: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(datos[i] + " ");
        }

        int numeroBuscado = 5;
        bool encontrado = false;

        int izq = 0, dcha = datos.Length - 1;
        while (izq <= dcha && !encontrado)
        {
            int centro = izq + (dcha - izq) / 2;
            if (datos[centro] == numeroBuscado)
                encontrado = true;
            else if (datos[centro] < numeroBuscado)
                izq = centro + 1;
            else
                dcha = centro - 1;
        }

        if (encontrado) 
        {
            Console.WriteLine("El 5 estaba");
        }
        else
        {
            Console.WriteLine("El 5 NO estaba");
        }
    }
}

// Dame el dato 1:
// 10
// Dame el dato 2:
// 7
// Dame el dato 3:
// 5
// Dame el dato 4:
// 2
// Dame el dato 5:
// 4
// Resultado:
// 2 4 5 7 10 El 5 estaba


// Dame el dato 1:
// 10
// Dame el dato 2:
// 8
// Dame el dato 3:
// 6
// Dame el dato 4:
// 2
// Dame el dato 5:
// 4
// Resultado:
// 2 4 6 8 10 El 5 NO estaba
