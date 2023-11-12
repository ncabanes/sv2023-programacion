/* 80. Crea una versión mejorada del programa anterior: permitirá guardar hasta
 * 1.000 nombres de videojuegos y un menú que permita: Añadir un nuevo dato (al
 * final de los existentes), insertar un dato (en una cierta posición que se
 * preguntará al usuario), borrar un dato (a partir de su número de posición),
 * ver todos los datos, buscar un cierto dato, salir.
 *
 * VÍCTOR (...) - 1º DAM SEMI, retoques menores por Nacho
 */

using System;

class Ejercicio_04_01_80
{
    static void Main()
    {
        const byte  SALIR = 0, ANYADIR = 1, INSERTAR = 2, BORRAR = 3, VER = 4,
                    BUSCAR = 5;
        const ushort CAPACIDAD = 1000;
        string[] videojuegos = new string[CAPACIDAD];
        byte opcion;
        ushort cantidad = 0, posicionInsertar, posicionBorrar;
        string juegoBusqueda, juegoNuevo;

        // MENÚ DE OPCIONES
        do
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANYADIR+". Añadir dato nuevo");
            Console.WriteLine(INSERTAR+". Insertar un dato (elegir posición)");
            Console.WriteLine(BORRAR+". Borrar un dato (elegir posición)");
            Console.WriteLine(VER+". Ver todos los juegos");
            Console.WriteLine(BUSCAR+". Buscar un juego");
            Console.WriteLine(SALIR+". Salir");
            Console.WriteLine();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case ANYADIR:
                    if (cantidad < CAPACIDAD)
                    {
                        Console.Write("¿Qué videojuego desea añadir?: ");
                        juegoNuevo = Console.ReadLine();

                        videojuegos[cantidad] = juegoNuevo;
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("No caben más datos.");
                    }
                    Console.WriteLine();
                    break;

                case INSERTAR:
                    if (cantidad < CAPACIDAD)
                    {
                        do
                        {
                            Console.Write("¿Qué videojuego desea añadir?: ");
                            juegoNuevo = Console.ReadLine();

                            Console.Write("¿En qué posición desea añadirlo?: ");
                            posicionInsertar = Convert.ToUInt16(Console.ReadLine());

                            Console.WriteLine();
                        }
                        while (posicionInsertar-1 > cantidad);

                        for (int i = cantidad ; i > posicionInsertar-1 ; i--)
                        {
                            videojuegos[i] = videojuegos[i-1];
                        }
                        videojuegos[posicionInsertar-1] = juegoNuevo;
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("No caben más datos.");
                    }
                    break;

                case BORRAR:
                    do
                    {
                        Console.Write("¿Qué videojuego desea borrar?: ");
                        posicionBorrar = Convert.ToUInt16(Console.ReadLine());
                    }
                    while (posicionBorrar > cantidad);

                    for (int i = posicionBorrar-1 ; i < cantidad ; i++)
                    {
                        videojuegos[i] = videojuegos[i+1];
                    }
                    cantidad--;
                    break;

                case VER:
                    if (cantidad > 0)
                    {
                        for (int i = 0; i < cantidad ; i++)
                        {
                            Console.WriteLine("{0}- {1}", i+1, videojuegos[i]);
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
                    for (int i = 0 ; i < cantidad ; i++)
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
