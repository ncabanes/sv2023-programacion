/* 92. Programas de ordenador (examen de 2008-2009, grupo presencial)
 *
 * Crea un programa en C# que permita almacenar fichas de hasta 1000 programas
 * de ordenador. Para cada programa, debe guardar los siguientes datos:
 *
 * - Nombre
 * - Categoría
 * - Descripción
 * - Versión (es un conjunto de 3 datos: el número de versión –texto-, el mes
 * de lanzamiento –byte- y el año de lanzamiento –entero corto sin signo-).
 *
 * El programa debe permitir al usuario las siguientes operaciones:
 *
 * 1- Añadir datos de un nuevo programa (el nombre no debe estar vacío; se debe
 * comprobar la categoría que teclee el usuario no ocupe más de 30 letras, y si
 * es así, se le deberá volver a pedir; para la descripción, se tomarán sólo
 * las primeras 100 letras, en caso de que el usuario teclee más de 100; no es
 * necesario validar la versión).
 *
 * 2- Mostrar los nombres de todos los programas almacenados. Cada nombre debe
 * aparecer en una línea, precedido por el número de registro. Si hay más de 20
 * programas, se deberá hacer una pausa tras mostrar cada bloque de 20
 * programas, y esperar a que el usuario pulse Intro antes de seguir. Se deberá
 * avisar si no hay datos.
 *
 * 3- Ver todos los datos de un cierto programa (a partir de un fragmento de su
 * nombre, categoría o descripción, sin distinguir mayúsculas ni minúsculas).
 * Si la categoría se ha dejado en blanco, aparecerá "Categoría: Sin datos", en
 * vez del espacio en blanco. Si hay varios programas que contengan ese texto,
 * se mostrarán todos ellos, separados por una línea en blanco. Se deberá
 * avisar si no se encuentra ningún programa.
 *
 * 4- Modificar una ficha (pedirá el número; se mostrará el valor anterior de
 * cada campo y se podrá pulsar Intro para no modificar alguno de los datos).
 * Se debe avisar (pero no volver a pedir) si introduce un número de ficha
 * incorrecto. No es necesario validar ninguno de los campos.
 *
 * 5- Borrar una cierta ficha, a partir del número que indique el usuario. Se
 * debe avisar (pero no volver a pedir) si introduce un número incorrecto.
 *
 * 6- Ordenar los datos alfabéticamente, según su nombre.
 *
 * 7- Corregir espacios Redundantes (cambiará todas las secuencias de dos o más
 * espacios por un único espacio, sólo en el nombre, para todas las fichas
 * existentes).
 *
 * T- Terminar el uso de la aplicación (como no sabemos almacenar la
 * información, los datos se perderán).
 */

// VICTOR (...), retoques menores por Nacho

using System;

class Exercise_04_03_92
{
    struct TipoVersion
    {
        public string numero;
        public byte mes;
        public ushort anyo;
    }
    struct TipoPrograma
    {
        public string nombre;
        public string categoria;
        public string descripcion;
        public TipoVersion numVersion;
    }

    static void Main()
    {
        const string ANYADIR = "1", VER_TODOS = "2", VER_UNO = "3",
            MODIFICAR = "4", BORRAR = "5", ORDENAR = "6", CORREGIR = "7",
            TERMINAR = "T";
        const ushort MAX_FICHAS = 1000, MAX_LETRAS = 100;
        TipoPrograma[] fichas = new TipoPrograma[MAX_FICHAS];
        ushort[] letras = new ushort[MAX_LETRAS];
        string opcion;
        ushort numFichas = 0;
        bool terminado = false;

        // Menú repetitivo hasta introducir 'T' o 't'
        do
        {
            // Mostrar y elegir opción
            Console.WriteLine("---MENÚ---");
            Console.WriteLine(ANYADIR +
                ". Añadir nuevo programa");
            Console.WriteLine(VER_TODOS +
                ". Mostrar todos los programas");
            Console.WriteLine(VER_UNO +
                ". Ver datos de un programa");
            Console.WriteLine(MODIFICAR +
                ". Modificar un programa");
            Console.WriteLine(BORRAR +
                ". Borrar un programa");
            Console.WriteLine(ORDENAR +
                ". Ordenar alfabéticamente todos los programas");
            Console.WriteLine(CORREGIR +
                ". Corregir espacios redundantes");
            Console.WriteLine(TERMINAR +
                ". Terminar");
            Console.WriteLine();
            Console.Write("Introduzca una opción (1-7 o T): ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcion)
            {
                case ANYADIR:
                    if (numFichas < MAX_FICHAS)
                    {
                        // Nombre obligatorio
                        do
                        {
                            Console.Write("Nombre: ");
                            fichas[numFichas].nombre = Console.ReadLine();
                        }
                        while (fichas[numFichas].nombre == "");

                        // Categoría inferior a 30 letras
                        do
                        {
                            Console.Write("Categoría: ");
                            fichas[numFichas].categoria = Console.ReadLine();
                        }
                        while (fichas[numFichas].categoria.Length > 30);

                        // Descripción (100 primeras letras)
                        Console.Write("Descripción: ");
                        fichas[numFichas].descripcion = Console.ReadLine();
                        if (fichas[numFichas].descripcion.Length > 100)
                            fichas[numFichas].descripcion =
                                fichas[numFichas].descripcion.Substring(0, 100);

                        // Versión
                        Console.Write("Número de versión: ");
                        fichas[numFichas].numVersion.numero =
                            Console.ReadLine();
                        Console.Write("Mes de lanzamiento: ");
                        fichas[numFichas].numVersion.mes =
                            Convert.ToByte(Console.ReadLine());
                        Console.Write("Año de lanzamiento: ");
                        fichas[numFichas].numVersion.anyo =
                            Convert.ToUInt16(Console.ReadLine());

                        Console.WriteLine();
                        numFichas++;
                    }
                    break;

                case VER_TODOS:
                    if (numFichas > 0)
                    {
                        for (int i = 0; i < numFichas; i++)
                        {
                            Console.WriteLine("[{0}/{1}] Nombre: {2}",
                                i + 1, MAX_FICHAS, fichas[i].nombre);
                            if (i % 20 == 19)
                            {
                                Console.WriteLine("Presione INTRO para continuar");
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
                    if (numFichas > 0)
                    {
                        Console.Write("Texto a buscar: ");
                        string buscar = Console.ReadLine().ToLower();
                        for (int i = 0; i < numFichas; i++)
                        {
                            if (fichas[i].nombre.ToLower().Contains(buscar) ||
                                fichas[i].descripcion.ToLower().Contains(buscar) ||
                                fichas[i].categoria.ToLower().Contains(buscar))
                            {
                                Console.WriteLine("Nombre: " + fichas[i].nombre);
                                Console.Write("Categoria: ");
                                if (fichas[i].categoria == "")
                                {
                                    Console.WriteLine("Sin datos");
                                }
                                else
                                {
                                    Console.WriteLine(fichas[i].categoria);
                                }
                                Console.WriteLine("Descripción: " +
                                    fichas[i].descripcion);
                                Console.WriteLine("Número versión: " +
                                    fichas[i].numVersion.numero);
                                Console.WriteLine("Mes lanzamiento: " +
                                    fichas[i].numVersion.mes);
                                Console.WriteLine("Año lanzamiento: " +
                                    fichas[i].numVersion.anyo);
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

                case MODIFICAR:
                    if (numFichas > 0)
                    {
                        Console.Write("Número de ficha a modificar: ");
                        int numeroModificar = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();
                        if (numeroModificar > 0 && numeroModificar <= numFichas)
                        {
                            Console.WriteLine("Modifique los campos o deje " +
                                "vacío y pulse INTRO para mantener los datos");
                            Console.WriteLine();

                            Console.WriteLine("Nombre (original): " +
                                fichas[numeroModificar - 1].nombre);
                            Console.Write("Nombre (nuevo): ");
                            string nuevoDatoString = Console.ReadLine();
                            if (nuevoDatoString != "")
                            {
                                fichas[numeroModificar - 1].nombre = nuevoDatoString;
                            }
                            else
                            {
                                fichas[numeroModificar - 1].nombre = 
                                    fichas[numeroModificar - 1].nombre;
                            }
                            Console.WriteLine();

                            Console.WriteLine("Categoria (original): " +
                                fichas[numeroModificar - 1].categoria);
                            Console.Write("Categoria (nueva): ");
                            nuevoDatoString = Console.ReadLine();
                            if (nuevoDatoString != "")
                            {
                                fichas[numeroModificar - 1].categoria = nuevoDatoString;
                            }
                            else
                            {
                                fichas[numeroModificar - 1].categoria = 
                                    fichas[numeroModificar - 1].categoria;
                            }
                            Console.WriteLine();

                            Console.WriteLine("Descripción (original): " +
                                fichas[numeroModificar - 1].descripcion);
                            Console.Write("Descripción (nueva): ");
                            nuevoDatoString = Console.ReadLine();
                            if (nuevoDatoString != "")
                            {
                                fichas[numeroModificar - 1].descripcion = nuevoDatoString;
                            }
                            else
                            {
                                fichas[numeroModificar - 1].descripcion =
                                    fichas[numeroModificar - 1].descripcion;
                            }
                            Console.WriteLine();

                            Console.WriteLine("Número versión (original): " +
                                fichas[numeroModificar - 1].numVersion.numero);
                            Console.Write("Número versión (nueva): ");
                            nuevoDatoString = Console.ReadLine();
                            if (nuevoDatoString != "")
                            {
                                fichas[numeroModificar - 1].numVersion.numero =
                                    nuevoDatoString;
                            }
                            else
                            {
                                fichas[numeroModificar - 1].numVersion.numero =
                                    fichas[numeroModificar - 1].numVersion.numero;
                            }
                            Console.WriteLine();

                            Console.WriteLine("Mes lanzamiento (original): " +
                                fichas[numeroModificar - 1].numVersion.mes);
                            Console.Write("Mes lanzamiento (nuevo): ");
                            nuevoDatoString = Console.ReadLine();
                            if (nuevoDatoString != "")
                            {
                                byte nuevoDatoByte = Convert.ToByte(nuevoDatoString);
                                fichas[numeroModificar - 1].numVersion.mes = nuevoDatoByte;
                            }
                            else
                            {
                                fichas[numeroModificar - 1].numVersion.mes =
                                    fichas[numeroModificar - 1].numVersion.mes;
                            }
                            Console.WriteLine();

                            Console.WriteLine("Año lanzamiento (original): " +
                                fichas[numeroModificar - 1].numVersion.anyo);
                            Console.Write("Año lanzamiento (nuevo): ");
                            nuevoDatoString = Console.ReadLine();
                            if (nuevoDatoString != "")
                            {
                                ushort nuevoDatoUShort =
                                    Convert.ToUInt16(nuevoDatoString);
                                fichas[numeroModificar - 1].numVersion.anyo =
                                    nuevoDatoUShort;
                            }
                            else
                            {
                                fichas[numeroModificar - 1].numVersion.anyo =
                                    fichas[numeroModificar - 1].numVersion.anyo;
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Número incorrecto");
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
                    if (numFichas > 0)
                    {
                        Console.Write("Número de ficha a borrar: ");
                        int numeroBorrar = Convert.ToUInt16(Console.ReadLine());
                        if (numeroBorrar > 0 && numeroBorrar <= numFichas)
                        {
                            for (int i = numeroBorrar - 1; i < numFichas; i++)
                            {
                                fichas[i] = fichas[i + 1];
                            }
                            numFichas--;
                            Console.WriteLine("Ficha eliminada");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Número incorrecto");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case ORDENAR:
                    if (numFichas > 1)
                    {
                        for (int a = 0; a < numFichas; a++)
                        {
                            for (int b = a + 1; b < numFichas; b++)
                            {
                                if (String.Compare(fichas[a].nombre, fichas[b].nombre,
                                    true) > 0)
                                {
                                    TipoPrograma datoTemporal = fichas[a];
                                    fichas[a] = fichas[b];
                                    fichas[b] = datoTemporal;
                                }
                            }
                        }
                        Console.WriteLine("Se han ordenado los nombres");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existen fichas suficientes");
                        Console.WriteLine();
                    }
                    break;

                case CORREGIR:
                    if (numFichas > 0)
                    {
                        for (int i = 0; i < numFichas; i++)
                        {
                            while (fichas[i].nombre.Contains("  "))
                            {
                                fichas[i].nombre =
                                    fichas[i].nombre.Replace("  ", " ");
                            }
                        }
                        Console.WriteLine("Se han eliminado los espacios");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No existen datos");
                        Console.WriteLine();
                    }
                    break;

                case TERMINAR:
                    terminado = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
        while (!terminado);
    }
}
