/*
 43. Muestra un triángulo creciente, centrado, formado por asteriscos, 
 con la altura indicada por el usuario, y comprobando errores con 
 "try-catch":

Altura? 5
    *
   ***
  *****
 *******
*********

Julio, retoques por Nacho
 
 */

using System;

class MyClass
{
    public static void Main()
    {
        int altura = 0;
        
        try
        {
            Console.Write("Altura? ");
            altura = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Error, no es un numero entero");
        }
        
        int espacios = altura-1;
        int asteriscos = 1;

        for (int fila = 0; fila < altura; fila++)
        {
            for (int columna = 1; columna <= espacios; columna++)
            {
                Console.Write(' ');
            }
            for (int columna = 1; columna <= asteriscos; columna++)
            {
                Console.Write('*');
            }
            espacios --;
            asteriscos += 2;
            Console.WriteLine();
        }
    }
}
