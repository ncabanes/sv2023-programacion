/*
Operación bikini
Se acerca el verano y comienzan los nervios y desesperación por mantener una 
ínea adecuada. Para ello muchas personas quieren ponerse en forma y se ponen en 
manos del experto nutricionista Dr Ácula.

El Dr Ácula es un doctor muy solicitado y debe ordenar la lista de pacientes en
función de quien tiene que atender antes. Este aconsejará a los pacientes según
mayor urgencia tengan.

Para ello los ordenará por mayor peso y en caso de empate lo hará según una
menor altura.

Entrada

En la primera línea un entero P indicando el número de pacientes.

1 <= C <= 10000

Las siguientes P líneas indicarán de cada paciente el peso w y la altura h.

1 <= h <= 100000

1 <= w <= 100000

Salida

Se nos mostrará los pacientes ordenados de mayor a menor, en base a su peso y 
altura según la urgencia de atención.


Ejemplo de entrada

5
90 150
100 120
100 110
77 170
110 161


Ejemplo de salida

110 161
100 110
100 120
90 150
77 170
Origen: ProgramaMe Regional Online 2015 - IES Serra Perenxisa (Torrent)
*/

// Mario (...)

using System;

class Reto08OperacionBikini
{
    static void Main()
    {
        short c = Convert.ToInt16(Console.ReadLine());

        int[,] pacientes = new int[c, 2];
        for (short i = 0; i < c; i++)
        {
            string[] paciente = Console.ReadLine().Split();
            pacientes[i, 0] = Convert.ToInt32(paciente[0]);
            pacientes[i, 1] = Convert.ToInt32(paciente[1]);
        }

        for (int i = 0; i < (c-1); i++)
        {
            for (int j = i+1; j < c; j++)
            {
                if ((pacientes[i, 0] < pacientes[j, 0]) || 
                        ((pacientes[i, 0] == pacientes[j, 0]) &&
                        (pacientes[i, 1] > pacientes[j, 1])))
                {
                    int temp0 = pacientes[i, 0];
                    pacientes[i, 0] = pacientes[j, 0];
                    pacientes[j, 0] = temp0;

                    int temp1 = pacientes[i, 1];
                    pacientes[i, 1] = pacientes[j, 1];
                    pacientes[j, 1] = temp1;
                }
            }
        }
        Console.WriteLine();

        for (int i = 0; i < c; i++)
        {                                    
            Console.WriteLine(pacientes[i,0] + " " + pacientes[i,1]);
        }
    }
}
