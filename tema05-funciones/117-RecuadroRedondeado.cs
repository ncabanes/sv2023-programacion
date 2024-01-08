/*117.Crea una función "MostrarRecuadroRedondeado", que mostrará un (supuesto)
recuadro redondeado con una cierta anchura y altura, como en este ejemplo:

MostrarRecuadroRedondeado(8, 3);
/ ------\
|      |
\------/
*/

// Javier (...)

using System;

class Ejercicio_117
{

    static void Main()
    {
        Console.WriteLine("Introduzca la altura");
        int altura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduzca la anchura");
        int anchura = Convert.ToInt32(Console.ReadLine());
        MostrarRecuadroRedondeado(altura, anchura);
    }

    static void MostrarRecuadroRedondeado(int alto, int ancho)
    {
        for (int i = 0; i < alto; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                if ((i == 0 && j == 0) || (i == alto - 1 && j == ancho - 1))
                {
                    Console.Write("/");
                }
                else if ((i == 0 && j == ancho - 1) || (i == alto - 1 && j == 0))
                {
                    Console.Write("\\");
                }
                else if (i == 0 || i == alto - 1)
                {
                    Console.Write("-");
                }
                else if(j==0||j==ancho-1)
                {
                    Console.Write("|");
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}
