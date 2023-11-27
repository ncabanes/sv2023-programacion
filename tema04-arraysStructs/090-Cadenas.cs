/*
 90. Crea un programa que solicite al usuario una cadena y:
 
- La convierta a min�sculas (almacenando el resultado en una nueva cadena, que 
  mostrar�)

- La convierta a may�sculas (almacenando el resultado en una nueva cadena, que 
  mostrar�)

- Si tiene m�s de 5 letras, elimine la segunda letra y la tercera letra 
  (almacenando el resultado en una nueva cadena, que mostrar�)

- Si tiene m�s de 4 letras, inserte "yo" despu�s de la tercera letra 
  (almacenando el resultado en una nueva cadena, que mostrar�)

- Reemplace todos los espacios (" ") por guiones bajos ("_", almacenando el 
  resultado en una nueva cadena, que mostrar�)

- Elimine los espacios iniciales y finales (almacenando el resultado en otra 
  cadena, que mostrar�)

- Divida el texto en un array de strings, usando los espacios como separadores, 
  y muestre las subcadenas resultantes, cada una en una l�nea.

- Reemplace todos los espacios (" ") por guiones ("-"), con la ayuda de un 
  StringBuilder (almacenando el resultado en una nueva cadena, que mostrar�)

Julio
 */
using System;
using System.Text;

class JuegoCadenas
{
    public static void Main()
    {
        Console.Write("Dime una cadena: ");
        string cadena = Console.ReadLine();
        Console.WriteLine();

        // La convierta a min�sculas(almacenando el resultado en 
        // una nueva cadena, que mostrar�)
        string nuevaCadena = cadena.ToLower();
        Console.WriteLine("Convertido en minusculas: " + nuevaCadena);
        Console.WriteLine();

        // Si tiene m�s de 5 letras, elimine la segunda letra y la tercera letra
        // (almacenando el resultado en una nueva cadena, que mostrar�)
        if (cadena.Length > 5)
        {
            nuevaCadena = cadena.Remove(1, 2);
            Console.WriteLine("Eliminado segunda letra y tercera: " + nuevaCadena);
        }
        Console.WriteLine();

        // Si tiene m�s de 4 letras, inserte "yo" despu�s de la 
        // tercera letra (almacenando el resultado en una nueva cadena, que mostrar�)
        if (cadena.Length > 4)
        {
            nuevaCadena = cadena.Insert(3, "yo");
            Console.WriteLine("Inserte \"yo\" despu�s de la tercera letra: " + 
                nuevaCadena);
        }
        Console.WriteLine();

        // Reemplace todos los espacios(" ") por guiones bajos ("_", 
        // almacenando el resultado en una nueva cadena, que mostrar�)
        nuevaCadena = cadena.Replace(' ', '_');
        Console.WriteLine("Reemplaza los espacios(\" \") por guiones bajos(\"_\"): " + 
            nuevaCadena);
        Console.WriteLine();

        // Elimine los espacios iniciales y finales (almacenando el 
        // resultado en otra cadena, que mostrar�)
        nuevaCadena = cadena.Trim();
        Console.WriteLine("Eliminando los espacios iniciales y finales: " + 
            nuevaCadena);
        Console.WriteLine();


        // Divida el texto en un array de strings, usando los espacios como 
        // separadores, y muestre las subcadenas resultantes, cada una en una l�nea.
        Console.WriteLine("array de strings, usando los espacios como separadores:" + 
            cadena);
        string[] cadenas = nuevaCadena.Split();

        for (int i = 0; i < cadenas.Length; i++)
        {
            Console.WriteLine(cadenas[i]);
        }
        Console.WriteLine();

        // Reemplace todos los espacios(" ") por guiones("-"), con la ayuda 
        // de un StringBuilder(almacenando el resultado en una nueva cadena, 
        // que mostrar�)

        Console.WriteLine("Reemplaza espacios(\" \") por guiones(\"-\") (2): ");
        StringBuilder nuevaCadena2 = new StringBuilder(cadena);
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == ' ')
            {
                nuevaCadena2[i] = '-';
            }
        }
        Console.WriteLine(nuevaCadena2);
    }
}
