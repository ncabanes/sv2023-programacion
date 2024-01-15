/*Operación bikini

Se acerca el verano y comienzan los nervios y desesperación por mantener una 
línea adecuada. Para ello muchas personas quieren ponerse en forma y se ponen 
en manos del experto nutricionista Dr Ácula.

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

Origen: ProgramaMe Regional Online 2015 - IES Serra Perenxisa (Torrent)*/

// Miguel Ángel (...)

using System;

class operacionBikini
{
    static void Main()
    {
        short numPacientes;
        
        numPacientes = Convert.ToInt16(Console.ReadLine());
        
        string[] paciente = new string[numPacientes];
        
        for (int i = 0; i < numPacientes; i ++)
        {
            paciente[i] = Console.ReadLine();
        }
        Console.WriteLine();
        
        for (int i = 0; i < numPacientes - 1; i ++)
        {
            for (int j = i + 1; j < numPacientes; j ++)
            {
                string[] datosPaciente = paciente[i].Split();
                string[] datosPacienteSig = paciente[j].Split();
                
                if (Convert.ToInt16(datosPaciente[0]) < 
                    Convert.ToInt16(datosPacienteSig[0]) || 
                    (Convert.ToInt16(datosPaciente[0]) == 
                    Convert.ToInt16(datosPacienteSig[0]) && 
                    Convert.ToInt16(datosPaciente[1]) > 
                    Convert.ToInt16(datosPacienteSig[1])))
                {
                    string datosTemp = paciente[i];
                    paciente[i] = paciente[j];
                    paciente[j] = datosTemp;
                }
            }
        }
        foreach (string dato in paciente)
        {
            Console.WriteLine(dato);
        }
    }
}
