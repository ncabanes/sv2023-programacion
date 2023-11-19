/* 87. Gestor de colección de juegos, versión 3.
 *
 * Crea un array que permita almacenar hasta 1000 juegos de ordenador o consola.
 *
 * De cada juego se guardará: título (cadena de texto), plataforma (cadena de
 * texto), espacio ocupado (en MB, número entero) y fecha de lanzamiento (mes y
 * año, en forma de struct anidado).
 *
 * El programa debe permitir al usuario realizar las siguientes operaciones:
 *
 * 1- Añadir datos de un nuevo juego.
 *
 * 2- Mostrar los nombres y plataformas de todos los juegos almacenados (ambos
 * datos en una misma línea, con el formato "The last of us (PS3)". Cada juego
 * debe aparecer en una línea distinta, precedido por el número de registro
 * (empezando a contar desde 1).
 *
 * 3- Ver todos los datos de un cierto programa (a partir de su número de
 * registro, contando desde 1).
 *
 * 4- Modificar una ficha (se pedirá el número y se volverá a introducir el
 * valor de todos los campos.
 *
 * 5- Borrar un cierto dato, a partir del número de registro que indique el
 * usuario.
 *
 * 0 - Terminar (como no sabemos almacenar la información, los datos se
 * perderán).
 *
 * VICTOR (...) - 1º DAM SEMI */

using System;

class Exercise_04_02_87
{
    struct fecha
    {
        public byte mes;
        public ushort anyo;
    }

    struct juegos
    {
        public string titulo;
        public string plataforma;
        public int tamano;
        public fecha fechaLanzamiento;
    }

    static void Main()
    {
        const byte SALIR = 0, ANADIR = 1, RESUMEN = 2, VER_UNO = 3,
        MODIFICAR = 4, BORRAR = 5;
        const ushort CAPACIDAD = 1000;
        juegos[] juego = new juegos[CAPACIDAD];
        byte opcion;
        ushort cantidad = 0, numero;

        do
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANADIR+". Añadir nuevo juego");
            Console.WriteLine(RESUMEN+". Ver resumen de todos los juegos");
            Console.WriteLine(VER_UNO+". Ver todos los datos de un juego");
            Console.WriteLine(MODIFICAR+". Modificar un juego");
            Console.WriteLine(BORRAR+". Borrar un juego");
            Console.WriteLine(SALIR+". Salir");
            Console.WriteLine();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case ANADIR:
                    if (cantidad < CAPACIDAD)
                    {
                        Console.WriteLine("Introduzca los datos del "+
                            "videojuego ({0}/{1}):", cantidad+1, CAPACIDAD);
                        Console.Write("Título: ");
                        juego[cantidad].titulo = Console.ReadLine();
                        Console.Write("Plataforma: ");
                        juego[cantidad].plataforma = Console.ReadLine();
                        Console.Write("Tamaño(MB): ");
                        juego[cantidad].tamano =
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fecha de publicación: ");
                        Console.Write("Mes: ");
                        juego[cantidad].fechaLanzamiento.mes =
                            Convert.ToByte(Console.ReadLine());
                        Console.Write("Año: ");
                        juego[cantidad].fechaLanzamiento.anyo =
                            Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("No caben más datos");
                        Console.WriteLine();
                    }
                    break;

                case RESUMEN:
                    if (cantidad > 0)
                    {
                        for (int i = 0 ; i < cantidad ; i++)
                        {
                            Console.WriteLine("{0}. {1}({2})", i+1,
                                juego[i].titulo, juego[i].plataforma);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case VER_UNO:
                    if (cantidad > 0)
                    {
                        Console.Write("Nº de registro: ");
                        numero = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("{0}- {1} - {2} - {3}/{4}/{5}",
                            juego[numero-1].titulo, juego[numero-1].plataforma,
                            juego[numero-1].tamano,
                            juego[numero-1].fechaLanzamiento.mes,
                            juego[numero-1].fechaLanzamiento.anyo);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case MODIFICAR:
                    if (cantidad > 0)
                    {
                        Console.Write("Nº de registro: ");
                        numero = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Introduzca los datos del "+
                        "videojuego ({0}/{1}):", numero, CAPACIDAD);
                        Console.Write("Título: ");
                        juego[numero-1].titulo = Console.ReadLine();
                        Console.Write("Plataforma: ");
                        juego[numero-1].plataforma = Console.ReadLine();
                        Console.Write("Tamaño(MB): ");
                        juego[numero-1].tamano =
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fecha de publicación: ");
                        Console.Write("Mes: ");
                        juego[numero-1].fechaLanzamiento.mes =
                            Convert.ToByte(Console.ReadLine());
                        Console.Write("Año: ");
                        juego[numero-1].fechaLanzamiento.anyo =
                            Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case BORRAR:
                    if (cantidad > 0)
                    {
                        Console.Write("Nº de registro: ");
                        numero = Convert.ToUInt16(Console.ReadLine());

                        for (int i = numero-1 ; i < cantidad ; i++)
                        {
                            juego[i] = juego[i+1];
                        }
                        cantidad--;
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
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
