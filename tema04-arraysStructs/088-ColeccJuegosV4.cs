/* 88. Gestor de colección de juegos, versión 4.
 *
 * Crea un array que permita almacenar hasta 1000 juegos de ordenador o consola.
 *
 * De cada juego se guardará: título (cadena de texto), plataforma (cadena de
 * texto), espacio ocupado (en MB, número entero) y fecha de lanzamiento (mes y
 * año, en forma de struct anidado).
 *
 * El programa debe permitir al usuario realizar las siguientes operaciones:
 *
 * 1- Añadir datos de un nuevo juego (Se debe comprobar si cabe, y avisar en
 * caso contrario).
 *
 * 2- Mostrar los nombres y plataformas de todos los juegos almacenados (ambos
 * datos en una misma línea, con el formato "The last of us (PS3)". Cada juego
 * debe aparecer en una línea distinta, precedido por el número de registro
 * (empezando a contar desde 1). Si hay más de 20 juegos, se deberá hacer una
 * pausa tras mostrar cada bloque de 20 juegos, y esperar a que el usuario
 * pulse Intro antes de seguir. Se deberá avisar si no hay datos.
 *
 * 3- Ver todos los datos de un cierto programa (a partir de su número de
 * registro, contando desde 1). Se deberá avisar (pero no volver a pedir) si
 * el número no es válido.
 *
 * 4- Modificar una ficha (se pedirá el número y se volverá a introducir el
 * valor de todos los campos. Se debe avisar (pero no volver a pedir) si
 * introduce un número de ficha incorrecto. No hará falta volver a teclear
 * todos los datos, sino que se debe permitir que el usuario pulse Intro
 * sin introducir nada cuando desee conservar el valor previo de un campo, y
 * sólo sea necesario que vuelva a teclear los campos que desee modificar.
 *
 * 5- Borrar un cierto dato, a partir del número de registro que indique el
 * usuario. Se debe avisar (pero no volver a pedir) si introduce un número
 * incorrecto.
 *
 * T- Terminar (como no sabemos almacenar la información, los datos se perderán).
 *
 * VICTOR (...) - 1º DAM SEMI */

using System;

class exercise_04_02_88
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
        public uint tamano;
        public fecha fechaLanzamiento;
    }

    static void Main()
    {
        const char ANADIR = '1', RESUMEN = '2', VER_UNO = '3',
            MODIFICAR = '4', BORRAR = '5', SALIR1 = 'S', SALIR2='s';
        const ushort CAPACIDAD = 1000;
        juegos[] juego = new juegos[CAPACIDAD];
        char opcion;
        ushort cantidad = 0, numero = 0;
        string nuevoDatoString = "";

        do
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANADIR+". Añadir nuevo juego");
            Console.WriteLine(RESUMEN+". Ver resumen de todos los juegos");
            Console.WriteLine(VER_UNO+". Ver todos los datos de un juego");
            Console.WriteLine(MODIFICAR+". Modificar un juego");
            Console.WriteLine(BORRAR+". Borrar un juego");
            Console.WriteLine(SALIR1+". Salir");
            Console.WriteLine();
            opcion = Convert.ToChar(Console.ReadLine());
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
                            Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Fecha de publicación: ");
                        Console.Write("Día: ");
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

                            if ((i+1) % 20 == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Presione INTRO para seguir");
                                Console.ReadLine();
                            }
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

                        if (numero > 0 && numero <= cantidad)
                        {
                            Console.WriteLine("Registro: {0}/{1}", numero,
                                CAPACIDAD);
                            Console.WriteLine("Título: "+
                                juego[numero-1].titulo);
                            Console.WriteLine("Plataforma: "+
                                juego[numero-1].plataforma);
                            Console.WriteLine("Tamaño: {0} MB",+
                                juego[numero-1].tamano);
                            Console.WriteLine("Fecha lanzamiento: {0}/{1}/{2}",+
                                juego[numero-1].fechaLanzamiento.mes,
                                juego[numero-1].fechaLanzamiento.anyo);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nº de registro incorrecto");
                            Console.WriteLine();
                        }
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

                        if (numero > 0 && numero <= cantidad)
                        {
                            Console.WriteLine("Registro: {0}/{1}", numero,
                                CAPACIDAD);
                            Console.WriteLine("Título: "+
                                juego[numero-1].titulo);
                            Console.WriteLine("Plataforma: "+
                                juego[numero-1].plataforma);
                            Console.WriteLine("Tamaño: {0}MB",+
                                juego[numero-1].tamano);
                            Console.WriteLine("Fecha lanzamiento: {0}/{1}/{2}",+
                                juego[numero-1].fechaLanzamiento.mes,
                                juego[numero-1].fechaLanzamiento.anyo);
                            Console.WriteLine();

                            Console.WriteLine("Modifique los datos o presione "+
                                "INTRO para continuar");

                            Console.Write("Título: ");
                            nuevoDatoString = Console.ReadLine();
                            if(nuevoDatoString != "")
                            {
                                juego[numero-1].titulo = nuevoDatoString;
                            }

                            Console.Write("Plataforma: ");
                            nuevoDatoString = Console.ReadLine();
                            if(nuevoDatoString != "")
                            {
                                juego[numero-1].plataforma = nuevoDatoString;
                            }

                            Console.Write("Tamaño(MB): ");
                            nuevoDatoString = Console.ReadLine();
                            if(nuevoDatoString != "")
                            {
                                juego[numero-1].tamano = 
                                    Convert.ToUInt32(nuevoDatoString);
                            }

                            Console.WriteLine("Fecha de lanzamiento: ");

                            Console.Write("Mes: ");
                            nuevoDatoString = Console.ReadLine();
                            if(nuevoDatoString != "")
                            {
                                juego[numero-1].fechaLanzamiento.mes = 
                                    Convert.ToByte(nuevoDatoString);
                            }
                            Console.Write("Año: ");
                            nuevoDatoString = Console.ReadLine();
                            if(nuevoDatoString != "")
                            {
                                juego[numero-1].fechaLanzamiento.anyo = 
                                    Convert.ToUInt16(nuevoDatoString);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Nº de registro incorrecto");
                            Console.WriteLine();
                        }
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
                        
                        if (numero > 0 && numero <= cantidad)
                        {
                            for (int i = numero-1 ; i < cantidad ; i++)
                            {
                                juego[i] = juego[i+1];
                            }
                            cantidad--;
                        }
                        else
                        {
                            Console.WriteLine("Nº de registro incorrecto");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case SALIR1:
                case SALIR2:
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
        while (opcion != 0);
    }
}
