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
 */

// Versión con listas con tipo

using System;
using System.Collections.Generic;

class ListasStructVideoJuego
{
    struct fecha
    {
        public byte mes;
        public ushort anyo;
    }

    struct TipoJuego
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
        List<TipoJuego> juegos = new List<TipoJuego>();
        byte opcion;
        ushort numero;

        do
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANADIR + ". Añadir nuevo juego");
            Console.WriteLine(RESUMEN + ". Ver resumen de todos los juegos");
            Console.WriteLine(VER_UNO + ". Ver todos los datos de un juego");
            Console.WriteLine(MODIFICAR + ". Modificar un juego");
            Console.WriteLine(BORRAR + ". Borrar un juego");
            Console.WriteLine(SALIR + ". Salir");
            Console.WriteLine();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case ANADIR:

                    TipoJuego j;

                    Console.WriteLine("Introduzca los datos del " +
                        "videojuego ({0}):", juegos.Count + 1);
                    Console.Write("Título: ");
                    j.titulo = Console.ReadLine();
                    Console.Write("Plataforma: ");
                    j.plataforma = Console.ReadLine();
                    Console.Write("Tamaño(MB): ");
                    j.tamano =
                        Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de publicación: ");
                    Console.Write("Mes: ");
                    j.fechaLanzamiento.mes =
                        Convert.ToByte(Console.ReadLine());
                    Console.Write("Año: ");
                    j.fechaLanzamiento.anyo =
                        Convert.ToUInt16(Console.ReadLine());
                    Console.WriteLine();

                    juegos.Add(j);
                    break;

                case RESUMEN:
                    if (juegos.Count > 0)
                    {
                        for (int i = 0; i < juegos.Count; i++)
                        {
                            Console.WriteLine("{0}. {1}({2})", i + 1,
                                juegos[i].titulo, juegos[i].plataforma);
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
                    if (juegos.Count > 0)
                    {
                        Console.Write("Nº de registro: ");
                        numero = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("{0}- {1} - {2} - {3}/{4}/{5}",
                            juegos[numero - 1].titulo, juegos[numero - 1].plataforma,
                            juegos[numero - 1].tamano,
                            juegos[numero - 1].fechaLanzamiento.mes,
                            juegos[numero - 1].fechaLanzamiento.anyo);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case MODIFICAR:
                    if (juegos.Count > 0)
                    {
                        Console.Write("Nº de registro: ");
                        numero = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();

                        TipoJuego juegoModificar = juegos[numero - 1];
                        Console.WriteLine("Introduzca los datos del " +
                        "videojuego ({0}/{1}):", numero, juegos.Count);
                        Console.Write("Título: ");
                        juegoModificar.titulo = Console.ReadLine();
                        Console.Write("Plataforma: ");
                        juegoModificar.plataforma = Console.ReadLine();
                        Console.Write("Tamaño(MB): ");
                        juegoModificar.tamano =
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fecha de publicación: ");
                        Console.Write("Mes: ");
                        juegoModificar.fechaLanzamiento.mes =
                            Convert.ToByte(Console.ReadLine());
                        Console.Write("Año: ");
                        juegoModificar.fechaLanzamiento.anyo =
                            Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();

                        juegos[numero - 1] = juegoModificar;
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case BORRAR:
                    if (juegos.Count > 0)
                    {
                        Console.Write("Nº de registro: ");
                        numero = Convert.ToUInt16(Console.ReadLine());
                        juegos.RemoveAt(numero - 1);
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

/*
Escoja una opcion:
1. Añadir nuevo juego
2. Ver resumen de todos los juegos
3. Ver todos los datos de un juego
4. Modificar un juego
5. Borrar un juego
0. Salir

1

Introduzca los datos del videojuego (1):
Título: 1
Plataforma: 1
Tamaño(MB): 1
Fecha de publicación:
Mes: 1
Año: 1

Escoja una opcion:
1. Añadir nuevo juego
2. Ver resumen de todos los juegos
3. Ver todos los datos de un juego
4. Modificar un juego
5. Borrar un juego
0. Salir

2

1. 1(1)

Escoja una opcion:
1. Añadir nuevo juego
2. Ver resumen de todos los juegos
3. Ver todos los datos de un juego
4. Modificar un juego
5. Borrar un juego
0. Salir
*/
