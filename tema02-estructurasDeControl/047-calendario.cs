/* 47. Muestra un calendario, pidiendo al usuario la cantidad de días 
del mes (por ejemplo, 31) y el número en la semana del primer día (por 
ejemplo, 2 para el martes). El resultado debería ser algo como:

  L   M   X   J   V   S   D
      1   2   3   4   5   6
  7   8   9  10  11  12  13
 14  15  16  17  18  19  20
 21  22  23  24  25  26  27
 28  29  30  31
*/

// Salvador (...)

using System;

public class T2_47
{
    public static void Main()
    {
        int dias, empieza, caracteres = 0;

        Console.Write("Cuantos días tiene el mes: ");
        dias = Convert.ToInt32(Console.ReadLine());
        Console.Write("Que día de la semana empieza: ");
        empieza = Convert.ToInt32(Console.ReadLine());

        //Primeros caracteres
        Console.WriteLine("  L  M  X  J  V  S  D");

        if (empieza > 7) empieza = empieza % 7;

        //Cada día ocupa 3 caracteres, corremos 3 hasta ir al día inicial
        for (int i = 3; i < empieza * 3; i++)
        {
            Console.Write(" ");
            caracteres++;
        }

        //Empezamos con el bucle de numeros
        for (int j = 1; j <= dias; j++)
        {
            //Si el numero es menor de 10 pondremos 2 espacios y el numero
            if (j < 10) 
            {
                Console.Write("  {0}", j);
                caracteres += 3;
            }
            //Si el numero es mayor de 10 colocamos un espacio y el numero
            else 
            {
                Console.Write(" {0}", j);
                caracteres += 3;
            }
            
            //Si el contador de caracteres pasa de 21 lo reiniciamos.
            if (caracteres >= 21) 
            {
                Console.WriteLine();
                caracteres = 0;
            }
        }
    }
}
