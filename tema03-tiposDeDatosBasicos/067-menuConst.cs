/*
  
67. Crea una nueva versi�n del programa anterior, 
que no utilice "n�meros m�gicos" en la orden "switch", sino constantes.

    66. Crea un men� como el siguiente.
    El usuario deber� escoger la opci�n 0, 1 o 2, 
    y despu�s se le mostrar� la opci�n que ha escogido,
    usando "switch" y datos de tipo "byte":

    1. Ver datos existentes
    2. A�adir un nuevo dato
    3. Buscar
    0. Salir
    1
    Ha escogido la opci�n "1": "Ver datos existentes"

 Julio
 */

using System;

class MenuConst
{
    public static void Main()
    {
        const byte SALIR = 0, VER = 1, ANYADIR = 2, BUSCAR = 3;
        Console.WriteLine("Escoge una opcion: ");
        Console.WriteLine("1. Ver datos existentes");
        Console.WriteLine("2. A�adir un nuevo dato");
        Console.WriteLine("3. Buscar");
        Console.WriteLine("0. Salir");
        byte opcionElegida = Convert.ToByte(Console.ReadLine());
        Console.Write("Ha escogido la opci�n \"" + opcionElegida + "\": ");

        switch (opcionElegida)
        {
            case VER:
                Console.Write("\"Ver datos existentes\"");
                break;
            case ANYADIR:
                Console.Write("\"A�adir un nuevo dato\"");
                break;
            case BUSCAR:
                Console.Write("\"Buscar\"");
                break;
            case SALIR:
                Console.Write("\"Salir\"");
                break;
            default:
                Console.WriteLine("Error. Esta opci�n no existe");
                break;
        }
    }
}
