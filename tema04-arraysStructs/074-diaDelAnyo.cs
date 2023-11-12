/*74. Crea un programa en C# que pida al usuario el número de un mes
(por ejemplo, 3 para marzo) y el número de un día (por ejemplo, 10) y
muestre de qué número de día dentro del año se trata, en un año no
bisiesto. Por ejemplo: como enero tiene 31 días y febrero 28, el 10 de
marzo sería el día número 69 del año (31+28+10). Debes usar un array
para guardar la cantidad de días que tiene cada mes.*/

// Javier (...)

using System;

class Ejercicio_74
{
    static void Main()
    {
        int[]meses={31,28,31,30,31,30,31,31,30,31,30,31};
        int mesUsuario;
        int diaUsuario;
        int dias=0;

        Console.Write("Introduzca el numero de mes (1 a 12) ");
        mesUsuario=Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduzca el numero de dia (1 a 31)");
        diaUsuario=Convert.ToInt32(Console.ReadLine());

        for(int i=0;i<mesUsuario-1;i++) // Sumamos los meses anterores
        {
            dias=dias+meses[i];
        }
        dias=dias+diaUsuario; // Y los días del mes actual

        Console.Write("Se trata del dia "+dias+" del año");
    }
}
