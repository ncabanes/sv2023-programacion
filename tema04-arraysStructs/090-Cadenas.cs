/*
 90. Crea un programa que solicite al usuario una cadena y:
 
- La convierta a minúsculas (almacenando el resultado en una nueva cadena, que 
  mostrará)

- La convierta a mayúsculas (almacenando el resultado en una nueva cadena, que 
  mostrará)

- Si tiene más de 5 letras, elimine la segunda letra y la tercera letra 
  (almacenando el resultado en una nueva cadena, que mostrará)

- Si tiene más de 4 letras, inserte "yo" después de la tercera letra 
  (almacenando el resultado en una nueva cadena, que mostrará)

- Reemplace todos los espacios (" ") por guiones bajos ("_", almacenando el 
  resultado en una nueva cadena, que mostrará)

- Elimine los espacios iniciales y finales (almacenando el resultado en otra 
  cadena, que mostrará)

- Divida el texto en un array de strings, usando los espacios como separadores, 
  y muestre las subcadenas resultantes, cada una en una línea.

- Reemplace todos los espacios (" ") por guiones ("-"), con la ayuda de un 
  StringBuilder (almacenando el resultado en una nueva cadena, que mostrará)

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

        // La convierta a minúsculas(almacenando el resultado en 
        // una nueva cadena, que mostrará)
        string nuevaCadena = cadena.ToLower();
        Console.WriteLine("Convertido en minusculas: " + nuevaCadena);
        Console.WriteLine();

        // Si tiene más de 5 letras, elimine la segunda letra y la tercera letra
        // (almacenando el resultado en una nueva cadena, que mostrará)
        if (cadena.Length > 5)
        {
            nuevaCadena = cadena.Remove(1, 2);
            Console.WriteLine("Eliminado segunda letra y tercera: " + nuevaCadena);
        }
        Console.WriteLine();

        // Si tiene más de 4 letras, inserte "yo" después de la 
        // tercera letra (almacenando el resultado en una nueva cadena, que mostrará)
        if (cadena.Length > 4)
        {
            nuevaCadena = cadena.Insert(3, "yo");
            Console.WriteLine("Inserte \"yo\" después de la tercera letra: " + 
                nuevaCadena);
        }
        Console.WriteLine();

        // Reemplace todos los espacios(" ") por guiones bajos ("_", 
        // almacenando el resultado en una nueva cadena, que mostrará)
        nuevaCadena = cadena.Replace(' ', '_');
        Console.WriteLine("Reemplaza los espacios(\" \") por guiones bajos(\"_\"): " + 
            nuevaCadena);
        Console.WriteLine();

        // Elimine los espacios iniciales y finales (almacenando el 
        // resultado en otra cadena, que mostrará)
        nuevaCadena = cadena.Trim();
        Console.WriteLine("Eliminando los espacios iniciales y finales: " + 
            nuevaCadena);
        Console.WriteLine();


        // Divida el texto en un array de strings, usando los espacios como 
        // separadores, y muestre las subcadenas resultantes, cada una en una línea.
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
        // que mostrará)

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
