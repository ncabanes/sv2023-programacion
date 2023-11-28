/*

93. Gestor de colección de juegos, versión 5 (basado en el examen de 2014-2015, 
tema 4, grupo presencial)

Crea un programa en C# que permita almacenar hasta 10000 juegos de ordenador o consola.
Para cada juego, debe permitir al usuario almacenar la siguiente información:

 • Título (por ejemplo, GranTurismo 6)

 • Plataforma (por ejemplo, PS3)

 • Categoría (por ejemplo, carreras)

 • Espacio ocupado (en MB, número entero)

 • Fecha de lanzamiento (mes y año, en forma de struct anidado) (por ejemplo 2013, 12)

 • Valoración (por ejemplo, 8.7)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un nuevo juego (al final de los datos existentes). El título y la 
plataforma no deben estar vacíos. El año, si se introduce, debe ser de 1940 a 
2100. La valoración, si se introduce, debe ser de 0 a 10. No se debe realizar 
ninguna otra validación.

2 - Mostrar nombre, categoría y plataforma de todos los juegos almacenados (los 
tres datos en una misma línea, con el formato "GranTurismo 6 - Carreras (PS3)". 
Cada juego debe aparecer en una línea distinta, precedido por el número de 
registro (empezando a contar desde 1). Si hay más de 22 juegos, se deberá hacer 
una pausa tras mostrar cada bloque de 22 juegos, y esperar a que el usuario 
pulse Intro antes de seguir. Se deberá avisar si no hay datos.

3 - Ver todos los datos de un cierto juego (a partir de su número de registro  
o bien de su título exacto -sin distinción de mayúsculas y minúsculas-, según 
elija el usuario), contando desde 1). Se deberá avisar (pero no volver a pedir) 
si el número no es válido.

4 - Buscar juegos que contengan un determinado texto (búsqueda parcial, en 
cualquier campo de texto, sin distinción de mayúsculas y minúsculas). Debe 
mostrar el número de registro, el título, la plataforma, el año y la 
valoración, haciendo una pausa después de cada 22 filas.

5 - Modificar un registro: pedirá al usuario su número, mostrará el valor 
anterior de cada campo y permitirá pulsar Intro para no modificar alguno de los 
datos. Se debe avisar al usuario (pero no volver a pedir) si introduce un 
número de registro incorrecto . El año y la calificación, si se modifican, 
deben ser válidos.

6 - Borrar un registro, en la posición indicada por el usuario. Se le debe 
avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto. Debe mostrar el registro que se va a eliminar y solicitar 
confirmación antes de la eliminación.

7 - Ordenar los datos alfabéticamente, por título y (en caso de coincidir el 
título) por plataforma.

8 - Eliminar espacios redundantes: eliminar espacios finales, espacios 
iniciales y espacios duplicados en el título, la plataforma y la categoría.

T - Terminar (como no sabemos almacenar la información en archivo ni base de 
datos, la información se perderá).

*/

//  Julio, retoques menores por Nacho

using System;

class ColeccionJuegos
{
    struct TipoFecha
    {
        public string mes;
        public string anyo;
    }
    struct TipoJuego
    {
        public string titulo;
        public string plataforma;
        public string categoria;
        public int espacioOcupado;
        public TipoFecha fecha;
        public float valoracion;
    }

    public static void Main()
    {
        const string TERMINAR = "T", ANYADIR = "1", VER_TODOS = "2", VER_UNO = "3",
            BUSCAR = "4", MODIFICAR = "5", BORRAR = "6", ORDENAR = "7", REDUNDANCIAS = "8";
        const uint capacidadMax = 10000;
        TipoJuego[] coleccion = new TipoJuego[capacidadMax];
        int contadorReg = 0;
        string opcionElegida;
        int verMaxPagina = 22;

        do
        {
            Console.WriteLine();
            Console.WriteLine("       - MENÚ - ");
            Console.WriteLine(ANYADIR + "- Añadir un nuevo juego");
            Console.WriteLine(VER_TODOS + "- Mostrar datos de los juegos almacenados");
            Console.WriteLine(VER_UNO + "- Ver todos los datos de un cierto juego");
            Console.WriteLine(BUSCAR + "- Buscar juego");
            Console.WriteLine(MODIFICAR + "- Modificar un registro");
            Console.WriteLine(BORRAR + "- Borrar un registro");
            Console.WriteLine(ORDENAR + "- Ordenar datos alfabeticamente");
            Console.WriteLine(REDUNDANCIAS + "- Eliminar espacios");
            Console.WriteLine(TERMINAR + "- Terminar");
            Console.WriteLine();

            opcionElegida = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcionElegida)
            {
                case ANYADIR:
                    if (contadorReg >= capacidadMax)
                    {
                        Console.WriteLine("Error, No caben mas registros");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Introduce un título: ");
                            coleccion[contadorReg].titulo = Console.ReadLine();
                        }
                        while (coleccion[contadorReg].titulo == "");

                        do
                        {
                            Console.Write("Introduce plataforma: ");
                            coleccion[contadorReg].plataforma = Console.ReadLine();
                        }
                        while (coleccion[contadorReg].plataforma == "");

                        Console.Write("Introduce la categoría: ");
                        coleccion[contadorReg].categoria = Console.ReadLine();

                        Console.Write("Introduce espacio ocupado: ");
                        coleccion[contadorReg].espacioOcupado =
                            Convert.ToInt32(Console.ReadLine());

                        string anyo = "";
                        do
                        {
                            Console.Write("Fecha, año lanzamiento (entre 1940 y 2100): ");
                            anyo = Console.ReadLine();
                            coleccion[contadorReg].fecha.anyo = anyo;
                        }
                        while (Convert.ToSingle(anyo) < 1940 || Convert.ToSingle(anyo) > 2100);

                        Console.Write("mes: ");
                        coleccion[contadorReg].fecha.mes = Console.ReadLine();

                        string valoracion = "";
                        do
                        {
                            Console.Write("Valoracion de 0 a 10: ");
                            valoracion = Console.ReadLine();
                            if (valoracion == "")
                            {
                                coleccion[contadorReg].valoracion = -1;
                            }
                            else
                            {
                                coleccion[contadorReg].valoracion = Convert.ToSingle(valoracion);
                            }
                        } while (!
                            ((coleccion[contadorReg].valoracion == -1)
                            || (coleccion[contadorReg].valoracion >= 0 
                                && coleccion[contadorReg].valoracion <= 10))
                        );
                        contadorReg++;
                    }
                    break;

                case VER_TODOS:
                    if (contadorReg > 0)
                    {
                        for (int i = 0; i < contadorReg; i++)
                        {
                            Console.WriteLine("{0}: {1} - {2} ({3})", i + 1,
                                coleccion[i].titulo, coleccion[i].categoria,
                                coleccion[i].plataforma);
                            if ((i + 1) % verMaxPagina == 0)
                            {
                                Console.ReadLine();
                                Console.WriteLine();
                            }
                        }
                    }
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case VER_UNO:
                    Console.WriteLine("-Opciones de búsqueda-");
                    Console.WriteLine("1.- Buscar por nº de registro");
                    Console.WriteLine("2.- Buscar por titulo exacto");
                    string opcionBuscar = Console.ReadLine();

                    if (opcionBuscar == "1")
                    {
                        Console.Write("Introduce un nº de registro de 1 a " + (contadorReg) + " ");
                        int numRegMostrar = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (numRegMostrar >= 0 && numRegMostrar < contadorReg)
                        {
                            Console.Write("Titulo: " + coleccion[numRegMostrar].titulo + "| ");
                            Console.Write("Plataforma: " + coleccion[numRegMostrar].plataforma + "| ");
                            Console.Write("Categoría: " + coleccion[numRegMostrar].categoria + "| ");
                            Console.Write("Espacio Ocupado: " + coleccion[numRegMostrar].espacioOcupado + "| ");
                            Console.Write("Fecha: año: " + coleccion[numRegMostrar].fecha.anyo + ", ");
                            Console.Write("mes: " + coleccion[numRegMostrar].fecha.mes + "| ");
                            Console.Write("Valoracion: " + coleccion[numRegMostrar].valoracion);
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Error, nº registro no válido");
                    }

                    else if (opcionBuscar == "2")
                    {
                        Console.Write("Introduce el título: ");
                        string tituloBuscar = Console.ReadLine();
                        bool encontrado = false;
                        Console.WriteLine();
                        for (int i = 0; i < contadorReg; i++)
                        {
                            if (coleccion[i].titulo.ToUpper() == tituloBuscar.ToUpper())
                            {
                                Console.Write("Título: " + coleccion[i].titulo + "| ");
                                Console.Write("Plataforma: " + coleccion[i].plataforma + "| ");
                                Console.Write("Categoría: " + coleccion[i].categoria + "| ");
                                Console.Write("Espacio Ocupado: " + coleccion[i].espacioOcupado + "| ");
                                Console.Write("Fecha: año: " + coleccion[i].fecha.anyo + ", ");
                                Console.Write("mes: " + coleccion[i].fecha.mes + "| ");
                                Console.Write("Valoración: " + coleccion[i].valoracion);
                                encontrado = true;
                                Console.WriteLine();
                            }
                        }
                        if (!encontrado)
                            Console.WriteLine("Error, Titulo " + "\"" +
                                (tituloBuscar) + "\"" + " desconocido");
                    }
                    else
                    {
                        Console.WriteLine("Opción de búsqueda no válida");
                    }
                    break;

                case BUSCAR:
                    if (contadorReg > 0)
                    {
                        Console.Write("Introduce un texto para buscar: ");
                        string textoBuscar = Console.ReadLine();
                        int cantidadEncontrados = 0;

                        for (int i = 0; i < contadorReg; i++)
                        {
                            if (coleccion[i].titulo.ToUpper().Contains(textoBuscar.ToUpper()) ||
                                coleccion[i].plataforma.ToUpper().Contains(textoBuscar.ToUpper()) ||
                                coleccion[i].categoria.ToUpper().Contains(textoBuscar.ToUpper()))
                            {
                                cantidadEncontrados++;
                                Console.WriteLine("{0}: {1} - {2} ({3})", i + 1,
                                    coleccion[i].titulo, coleccion[i].categoria,
                                    coleccion[i].plataforma);

                                if (cantidadEncontrados == verMaxPagina)
                                {
                                    Console.WriteLine();
                                    Console.ReadLine();
                                    Console.WriteLine();
                                    cantidadEncontrados = 0;
                                }
                            }
                        }
                        if (cantidadEncontrados == 0)
                            Console.WriteLine("No se ha encontrado ningún texto por " + "\""
                                + textoBuscar + "\"");
                    }
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case MODIFICAR:
                    Console.Write("Introduce un nº de resgistro de 1 a "
                        + contadorReg + " para modificar: ");
                    int numRegModificar = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    if (numRegModificar >= 0 && numRegModificar < contadorReg)
                    {
                        Console.WriteLine("Título: " + coleccion[numRegModificar].titulo);
                        Console.Write("Nuevo título? ");
                        string nuevoTitulo = Console.ReadLine();
                        if (nuevoTitulo != "")
                            coleccion[numRegModificar].titulo = nuevoTitulo;

                        Console.WriteLine("Plataforma: " + coleccion[numRegModificar].plataforma);
                        Console.Write("Nueva plataforma? ");
                        string nuevaPlataforma = Console.ReadLine();
                        if (nuevaPlataforma != "")
                            coleccion[numRegModificar].plataforma = nuevaPlataforma;

                        Console.WriteLine("Categoría: " +
                            coleccion[numRegModificar].categoria);
                        Console.Write("Nueva categoría? ");
                        string nuevaCategoria = Console.ReadLine();
                        if (nuevaPlataforma != "")
                            coleccion[numRegModificar].categoria = nuevaCategoria;

                        Console.WriteLine("Espacio Ocupado: "
                            + coleccion[numRegModificar].espacioOcupado);
                        Console.Write("Nuevo espacio ocupado? ");
                        string nuevoEspacioOcu = Console.ReadLine();
                        if (nuevoEspacioOcu != "")
                            coleccion[numRegModificar].espacioOcupado
                                = Convert.ToInt32(nuevoEspacioOcu);

                        Console.WriteLine("Fecha, año lanzamiento(entre 1940 y 2100): " +
                            coleccion[numRegModificar].fecha.anyo);
                        Console.Write("Nuevo año? ");
                        string nuevoAnyo = Console.ReadLine();

                        if (nuevoAnyo != "")
                        {
                            if (Convert.ToInt32(nuevoAnyo) < 1940
                                || Convert.ToInt32(nuevoAnyo) > 2100)
                            {
                                Console.WriteLine("Año no válido. No se cambiará.");
                            }
                            else
                            {
                                coleccion[numRegModificar].fecha.anyo = nuevoAnyo;
                            }
                        }

                        Console.WriteLine("Mes " + coleccion[numRegModificar].fecha.mes);
                        Console.Write("Nuevo mes? ");
                        string nuevoMes = Console.ReadLine();

                        if (nuevoMes != "")
                            coleccion[numRegModificar].fecha.mes = nuevoMes;

                        Console.WriteLine("Valoracion: " + coleccion[numRegModificar].valoracion);
                        Console.Write("Cambiar valoracion? ");
                        string nuevaValoracion = Console.ReadLine();

                        if (nuevaValoracion != "")
                        {
                            if (Convert.ToSingle(nuevaValoracion) < 0
                                || Convert.ToSingle(nuevaValoracion) > 10)
                            {
                                Console.WriteLine("Valoración no válida. No se cambiará.");
                            }
                            else
                            {
                                coleccion[numRegModificar].valoracion = Convert.ToSingle(nuevaValoracion);
                            }
                        }
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Error, nº registro no válido");
                    break;

                case BORRAR:
                    Console.Write("Introduce un nº de resgistro de 1 a " +
                        (contadorReg) + " para modificar: ");
                    int numRegBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    if (numRegBorrar >= 0 && numRegBorrar < contadorReg)
                    {
                        Console.WriteLine("{0}: {1} - {2} ({3})", numRegBorrar + 1,
                                coleccion[numRegBorrar].titulo,
                                coleccion[numRegBorrar].categoria,
                                coleccion[numRegBorrar].plataforma);
                        Console.WriteLine("Eliminar la ficha, si o no?");
                        string confirmarEliminar = Console.ReadLine().ToUpper();

                        if (confirmarEliminar == "SI" || confirmarEliminar == "S")
                        {
                            for (int i = numRegBorrar; i < contadorReg; i++)
                            {
                                coleccion[i] = coleccion[i + 1];
                            }
                            contadorReg--;
                            Console.WriteLine("nºReg " + "\""
                                + (numRegBorrar + 1) + "\" Eliminado ");
                        }
                    }
                    else
                        Console.WriteLine("Error, nº registro no válido");
                    break;

                case ORDENAR:
                    for (int i = 0; i < contadorReg - 1; i++)
                    {
                        for (int j = i + 1; j < contadorReg; j++)
                        {
                            if ( // Por titulo, si son distintos
                                String.Compare(coleccion[i].titulo,
                                    coleccion[j].titulo, true) > 0 ||
                                 // Por plataforma, si coincide el título
                                 (
                                    (coleccion[i].titulo.ToUpper() ==
                                        coleccion[i].titulo.ToUpper()) &&
                                    String.Compare(coleccion[i].plataforma,
                                        coleccion[j].plataforma, true) > 0)
                                )
                            {
                                TipoJuego aux = coleccion[i];
                                coleccion[i] = coleccion[j];
                                coleccion[j] = aux;
                            }
                        }
                    }
                    Console.WriteLine("Ordenados alfabéticamente título - plataforma");
                    break;

                case REDUNDANCIAS:
                    if (contadorReg > 0)
                    {
                        for (int i = 0; i < contadorReg; i++)
                        {
                            coleccion[i].titulo = coleccion[i].titulo.Trim();
                            while (coleccion[i].titulo.Contains("  "))
                            {
                                coleccion[i].titulo =
                                    coleccion[i].titulo.Replace("  ", " ");
                            }

                            coleccion[i].plataforma = coleccion[i].plataforma.Trim();
                            while (coleccion[i].plataforma.Contains("  "))
                            {
                                coleccion[i].plataforma =
                                    coleccion[i].plataforma.Replace("  ", " ");
                            }

                            coleccion[i].categoria = coleccion[i].categoria.Trim();
                            while (coleccion[i].categoria.Contains("  "))
                            {
                                coleccion[i].categoria =
                                    coleccion[i].categoria.Replace("  ", " ");
                            }
                        }
                        Console.WriteLine("Eliminados espacios sobrantes");
                    }
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case TERMINAR:
                    Console.WriteLine("Hasta pronto...");
                    break;
            }
        } while (TERMINAR != opcionElegida);
    }
}
