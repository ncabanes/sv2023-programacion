/* 80. Crea una versión mejorada del programa anterior: permitirá guardar hasta
 * 1.000 nombres de videojuegos y un menú que permita: Añadir un nuevo dato (al
 * final de los existentes), insertar un dato (en una cierta posición que se
 * preguntará al usuario), borrar un dato (a partir de su número de posición),
 * ver todos los datos, buscar un cierto dato, salir.
 */

/* Haz una versión alternativa del ejercicio 080 
 * (colección de videojuegos V2), usando una 
 * lista en vez de un array. */

using System;
using System.Collections.Generic;

class ListaVideoJuegos
{
    static void Main()
    {
        const byte SALIR = 0, ANYADIR = 1, INSERTAR = 2, BORRAR = 3, VER = 4,
                    BUSCAR = 5;
        List<string> videojuegos = new List<string>();
        byte opcion;
        ushort posicionInsertar, posicionBorrar;
        string juegoBusqueda, juegoNuevo;

        // MENÚ DE OPCIONES
        do
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANYADIR + ". Añadir dato nuevo");
            Console.WriteLine(INSERTAR + ". Insertar un dato (elegir posición)");
            Console.WriteLine(BORRAR + ". Borrar un dato (elegir posición)");
            Console.WriteLine(VER + ". Ver todos los juegos");
            Console.WriteLine(BUSCAR + ". Buscar un juego");
            Console.WriteLine(SALIR + ". Salir");
            Console.WriteLine();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case ANYADIR:
                    Console.Write("¿Qué videojuego desea añadir?: ");
                    juegoNuevo = Console.ReadLine();
                    videojuegos.Add(juegoNuevo);
                    Console.WriteLine();
                    break;

                case INSERTAR:
                    do
                    {
                        Console.Write("¿Qué videojuego desea añadir?: ");
                        juegoNuevo = Console.ReadLine();

                        Console.Write("¿En qué posición desea añadirlo?: ");
                        posicionInsertar = Convert.ToUInt16(Console.ReadLine());

                        Console.WriteLine();
                    }
                    while (posicionInsertar - 1 > videojuegos.Count);

                    videojuegos.Insert(posicionInsertar - 1, juegoNuevo);

                    break;

                case BORRAR:
                    do
                    {
                        Console.Write("¿Qué videojuego desea borrar?: ");
                        posicionBorrar = Convert.ToUInt16(Console.ReadLine());
                    }
                    while (posicionBorrar > videojuegos.Count);

                    videojuegos.RemoveAt(posicionBorrar - 1);
                    break;

                case VER:
                    if (videojuegos.Count > 0)
                    {
                        for (int i = 0; i < videojuegos.Count; i++)
                        {
                            Console.WriteLine("{0}- {1}", i + 1, videojuegos[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tu biblioteca está vacía");
                    }
                    Console.WriteLine();
                    break;

                case BUSCAR:
                    Console.Write("Introduzca el número que desea buscar: ");
                    juegoBusqueda = Console.ReadLine();

                    bool encontrado = false;
                    for (int i = 0; i < videojuegos.Count; i++)
                    {
                        if (juegoBusqueda == videojuegos[i])
                        {
                            encontrado = true;
                        }
                    }
                    if (encontrado)
                    {
                        Console.WriteLine("Encontrado");
                    }
                    else
                    {
                        Console.WriteLine("No encontrado");
                    }
                    Console.WriteLine();
                    break;

                case SALIR:
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
        while (opcion != 0);
    }
}
