/*
68. Crea una tercera versión del programa anterior, 
que no emplee constantes convencionales sino una enumeración.

    -- Crea un menú como el siguiente.
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

class MenuENUM
{
    enum Opciones { SALIR = 0, VER = 1, ANYADIR = 2, BUSCAR = 3 };

    public static void Main()
    {
        byte opcion;
        
        do
        {
            Console.WriteLine("Escoge una opcion: ");
            Console.WriteLine((byte) Opciones.VER +". Ver datos existentes");
            Console.WriteLine((byte) Opciones.ANYADIR+". Añadir un nuevo dato");
            Console.WriteLine((byte) Opciones.BUSCAR+". Buscar");
            Console.WriteLine((byte) Opciones.SALIR+". Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Write("Ha escogido la opción \"" + opcion + "\": ");

            switch (opcion)
            {
                case (byte) Opciones.VER:
                    Console.Write("\"Ver datos existentes\"");
                    break;
                case (byte) Opciones.ANYADIR:
                    Console.Write("\"Añadir un nuevo dato\"");
                    break;
                case (byte) Opciones.BUSCAR:
                    Console.Write("\"Buscar\"");
                    break;
                case (byte) Opciones.SALIR:
                    Console.Write("\"Salir\"");
                    break;
                default:
                    Console.WriteLine("Error. Esta opción no existe");
                    break;
            }
            Console.WriteLine();
        }
        while (opcion != (byte) Opciones.SALIR);
    }
}
