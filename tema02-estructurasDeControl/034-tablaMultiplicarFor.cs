// 34. Muestra la tabla de multiplicar del número que escoja 
// el usuario, usando "for".

// Francisco Javier (...)

using System;

class Ejercicio34
{
    public static void Main(string[] args)
    {
        int tablaUsuario;

        Console.WriteLine("Que tabla de multiplicar quieres?: ");
        tablaUsuario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int 0 = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}",
                tablaUsuario, i, tablaUsuario*i);
        }
    }
}
