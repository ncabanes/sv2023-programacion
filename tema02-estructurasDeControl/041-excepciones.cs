/*41. Pide al usuario dos números enteros y muestra su división. Usa 
excepciones para comprobar los posibles errores.*/

// Salvador (...)

using System;

class T2_41
{
    static void Main()
    {
        int n1, n2;

        try
        {
            Console.Write("Introduce un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su división es {0}", n1 / n2);
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "Uno o los dos números no tiene el formato adecuado");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir un número entre cero");
        }
    }
}
