/*71. Crea un nueva versión del menú (ejercicio 66), que muestra una
serie de opciones y después dice cuál ha escogido. En esta versión, los
nombres de las opciones estarán en un array, por lo que no será
necesario ningún "switch". La apariencia será como ésta:

1. Ver datos existentes
2. Añadir un nuevo dato
3. Buscar
0. Salir
1
Ha escogido la opción "1": "Ver datos existentes" */

using System;

class Ejercicio071
{
    static void Main()
    {
        string[]menu={"Salir", "Ver datos existentes",
            "Añadir un nuevo dato", "Buscar",};

        for (int i = 0; i < menu.Length; i++)
        {
            Console.WriteLine(i + ". " +menu[i]);
        }
        Console.Write("Escoja una opción: ");

        byte opcion = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Ha escogido la opción "
            + opcion + ": \"" + menu[opcion] +"\"");
    }
}

