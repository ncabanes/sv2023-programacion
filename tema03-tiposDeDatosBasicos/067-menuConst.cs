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

Julio, retoques por Nacho
 */

using System;

class MenuConst
{
    static void Main()
    {
        const byte SALIR = 0, VER = 1, ANYADIR = 2, BUSCAR = 3;
        byte opcion;
        
        do
        {
            Console.WriteLine("Escoge una opcion: ");
            Console.WriteLine(VER+". Ver datos existentes");
            Console.WriteLine(ANYADIR+". A�adir un nuevo dato");
            Console.WriteLine(BUSCAR+". Buscar");
            Console.WriteLine(SALIR+". Salir");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.Write("Ha escogido la opci�n \"" + opcion + "\": ");

            switch (opcion)
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
            Console.WriteLine();
        }
        while (opcion != SALIR);
    }
}
