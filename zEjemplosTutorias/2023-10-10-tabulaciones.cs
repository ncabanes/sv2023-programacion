// Ejemplo de tabulaciones mezcladas con espacios
// Desde Geany se verá bien; desde Bloc de Notas se verá mal

using System;

class TabulacionesEspacios
{
    static void Main()
	{
        int n;

	    Console.WriteLine("¿Cuantas repeticiones: ");
        n = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
            Console.Write("*");
        }
	}
}
