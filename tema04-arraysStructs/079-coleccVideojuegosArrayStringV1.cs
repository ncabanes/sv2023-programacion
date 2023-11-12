/* 79. Como proyecto que irá creciendo a lo largo del curso, vamos a hacer un
 * programa que nos permitirá gestionar una colección de videojuegos. Como
 * primera aproximación, crea un array que permita almacenar hasta 100 nombres
 * de videojuegos. Deberás mostrar un menú que permita: Añadir un nuevo dato
 * (al final de los existentes), ver todos los datos, buscar un juego, salir.
 * La opción de Buscar preguntará el nombre a buscar y responderá si es parte
 * de nuestra colección.
 *
 * VÍCTOR (...) - 1º DAM SEMI, retoques menores por Nacho
 */

using System;

class Ejercicio_04_01_79
{
    static void Main()
    {
        const byte  SALIR = 0, ANYADIR = 1, VER = 2, BUSCAR = 3;
        const byte CAPACIDAD = 100;
        string[] videojuegos = new string[CAPACIDAD];
        byte cantidad = 0, opcion;
        string juegoBusqueda, juegoNuevo;

        // MENÚ DE OPCIONES
        do
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANYADIR+". Añadir un nuevo dato");
            Console.WriteLine(VER+". Ver todos los datos");
            Console.WriteLine(BUSCAR+". Buscar un juego");
            Console.WriteLine(SALIR+". Salir");
            opcion = Convert.ToByte(Console.ReadLine());

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
                    
                    break;

                case VER:
                    for (int i = 0; i < cantidad ; i++)
                    {
                        Console.WriteLine("{0}- {1}", i+1, videojuegos[i]);
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
            Console.WriteLine();
        }
        while (opcion != 0);
    }
}
