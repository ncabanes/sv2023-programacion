/* 49. Haz un programa que dé al usuario la oportunidad de adivinar un 
número del 1 al 100 (que estará prefijado en el programa) en un máximo 
de 6 intentos. En cada pasada deberá avisarle de si se ha pasado o se 
ha quedado corto.

Julio
*/

using System;

class AdivinaNumero
{
    static void Main()
    {
        int numeroSecreto = 29;
        int intentos = 6;
        int numeroBuscar;

        do
        {
            Console.WriteLine("Intentos: {0}", intentos);
            Console.Write("Dime un número del 1 al 100: ");
            numeroBuscar = Convert.ToInt32(Console.ReadLine());

            if (numeroBuscar > numeroSecreto)
            {
                Console.WriteLine("Te has pasado");
            }
            else if (numeroBuscar < numeroSecreto)
            {
                Console.WriteLine("Te has quedado corto");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("¡¡¡ Acertaste !!!");
            }
            Console.WriteLine();
            intentos--;
        }
        while (numeroSecreto != numeroBuscar && intentos > 0);

        if (numeroSecreto != numeroBuscar)
            Console.WriteLine("Has agotado los 6 intentos. Era {0}",
                numeroSecreto);
    }
}
