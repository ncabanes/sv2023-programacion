/*
 66. Crea un menú como el siguiente.
El usuario deberá escoger la opción 0, 1 o 2, 
y después se le mostrará la opción que ha escogido,
usando "switch" y datos de tipo "byte":

1. Ver datos existentes
2. Añadir un nuevo dato
3. Buscar
0. Salir
1
Ha escogido la opción "1": "Ver datos existentes"

Julio, retoques por Nacho
*/

using System;

class MenuNumerosMagicos
{
    static void Main()
    {
        byte opcion;
        
        do
        {
            Console.WriteLine("Escoge una opcion: ");
            Console.WriteLine("1. Ver datos existentes");
            Console.WriteLine("2. Añadir un nuevo dato");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Write("Ha escogido la opción \"" + opcion + "\": ");

            switch (opcion)
            {
                case 1:
                    Console.Write("\"Ver datos existentes\"");
                    break;
                case 2:
                    Console.Write("\"Añadir un nuevo dato\"");
                    break;
                case 3:
                    Console.Write("\"Buscar\"");
                    break;
                case 0:
                    Console.Write("\"Salir\"");
                    break;
                default:
                    Console.WriteLine("Error. Esta opción no existe");
                    break;
            }
            Console.WriteLine();
        }
        while (opcion != 0);
    }
}
