/*

114. Crea una nueva versión del ejercicio 93 (colección de videojuegos, versión 5),
partiendo de la "versión oficial" que tienes compartida. En esta nueva versión,
cada opción del menú principal se debe extraer a una función. Por lo general,
cada una de estas funciones deberá recibir como parámetros el array con los
datos y el contador de cuántos datos hay almacenados, de modo que, en la medida
de lo posible, no existan variables globales, sino variables locales y datos
pasados como parámetros. Puedes ayudarte de otras funciones auxiliares que te
permitan simplificar las partes repetitivas, como las funciones "Pedir" y
"PedirConValorPorDefecto" que creaste en los ejercicios 101 y 102. Recuerda que,
en caso de necesitar alguna variable global, ésta deberá estar fuera de todas
las funciones y declararse como "static".

93. Gestor de colección de juegos, versión 5 (basado en el examen de 2014-2015,
*  tema 4, grupo presencial)

Crea un programa en C# que permita almacenar hasta 10000 juegos de ordenador o
* consola. Para cada juego, debe permitir al usuario almacenar la siguiente información:

 • Título (por ejemplo, GranTurismo 6)

 • Plataforma (por ejemplo, PS3)

 • Categoría (por ejemplo, carreras)

 • Espacio ocupado (en MB, número entero)

 • Fecha de lanzamiento (mes y año, en forma de struct anidado) (por ejemplo 2013, 12)

 • Valoración (por ejemplo, 8.7)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un nuevo juego (al final de los datos existentes). El título y la
plataforma no deben estar vacíos. El año, si se introduce, debe ser de 1940 a 2100.
La valoración, si se introduce, debe ser de 0 a 10. No se debe realizar
ninguna otra validación.

2 - Mostrar nombre, categoría y plataforma de todos los juegos almacenados
(los tres datos en una misma línea, con el formato "GranTurismo 6 - Carreras (PS3)".
Cada juego debe aparecer en una línea distinta, precedido por el número de registro
(empezando a contar desde 1). Si hay más de 22 juegos, se deberá hacer una pausa
tras mostrar cada bloque de 22 juegos, y esperar a que el usuario pulse Intro antes
de seguir. Se deberá avisar si no hay datos.

3 - Ver todos los datos de un cierto juego (a partir de su número de registro  o
bien de su título exacto -sin distinción de mayúsculas y minúsculas-,
según elija el usuario),
contando desde 1). Se deberá avisar (pero no volver a pedir) si el número no
es válido.

4 - Buscar juegos que contengan un determinado texto (búsqueda parcial, en cualquier
campo de texto, sin distinción de mayúsculas y minúsculas). Debe mostrar el número
de registro, el título, la plataforma, el año y la valoración, haciendo
una pausa después de cada 22 filas.

5 - Modificar un registro: pedirá al usuario su número, mostrará el valor anterior
de cada campo y permitirá pulsar Intro para no modificar alguno de los datos.
Se debe avisar al usuario (pero no volver a pedir) si introduce un número de
registro incorrecto. El año y la calificación, si se modifican, deben ser válidos.

6 - Borrar un registro, en la posición indicada por el usuario. Se le debe avisar
(pero no volver a preguntar) si introduce un número de registro incorrecto.
Debe mostrar el registro que se va a eliminar y solicitar confirmación antes
de la eliminación.

7 - Ordenar los datos alfabéticamente, por título y (en caso de coincidir el título)
por plataforma.

8 - Eliminar espacios redundantes: eliminar espacios finales, espacios iniciales
y espacios duplicados en el título, la plataforma y la categoría.

T- Terminar (como no sabemos almacenar la información en archivo ni base de datos,
la información se perderá).
 
Julio, retoques por Nacho

 */

using System;

class ColeccionJuegos
{
    // Tipos de datos creados

    struct TipoFecha
    {
        public byte mes;
        public int anyo;
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

    // Funciones auxiliares generales

    public static string Pedir(string aviso)
    {
        Console.Write(aviso);
        return Console.ReadLine();
    }

    private static string PedirNoVacio(string aviso)
    {
        string respuesta;
        do
        {
            respuesta = Pedir(aviso);
        }
        while (respuesta == "");
        return respuesta;
    }

    private static int PedirEnteroEnRango(string aviso, int minimo, int maximo)
    {
        int respuesta;
        do
        {
            respuesta = Convert.ToInt32(Pedir(aviso));
        }
        while (respuesta < minimo || respuesta > maximo);
        return respuesta;
    }

    public static string PedirConValorPorDefecto(string texto, string textoDefault)
    {
        Console.Write(texto);
        string nuevoTexto = Console.ReadLine();

        if (nuevoTexto != "")
            return nuevoTexto;
        else
            return textoDefault;
    }

    static float PedirValoracion()
    {
        string valoracion = "";
        float resultado;
        do
        {
            Console.Write("Valoracion de 0 a 10: ");
            valoracion = Console.ReadLine();
            if (valoracion == "")
                resultado = -1;
            else
                resultado = Convert.ToSingle(valoracion);
        }
        while (!((resultado == -1)
            || (resultado >= 0 && resultado <= 10)));

        return resultado;
    }

    static string QuitarEspaciosRedundantes(string texto)
    {
        texto = texto.Trim();
        while (texto.Contains("  "))
        {
            texto = texto.Replace("  ", " ");
        }
        return texto;
    }


    // Funciones auxiliares de visualización

    static void MostrarRegistroDetallado(TipoJuego[] coleccion, int numRegMostrar)
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

    static void MostrarRegistroBreve(TipoJuego[] coleccion, int numRegMostrar)
    {
        Console.WriteLine("{0}: {1} - {2} ({3})", numRegMostrar + 1,
                    coleccion[numRegMostrar].titulo, coleccion[numRegMostrar].categoria,
                    coleccion[numRegMostrar].plataforma);
    }


    // Funciones "de lógica del problema"

    static void Anyadir(TipoJuego[] coleccion, ref int contadorReg)
    {
        coleccion[contadorReg].titulo = PedirNoVacio("Introduce titulo: ");
        coleccion[contadorReg].plataforma = PedirNoVacio("Introduce plataforma: ");
        coleccion[contadorReg].categoria = Pedir("Introduce la categoría: ");
        coleccion[contadorReg].espacioOcupado = 
            Convert.ToInt32(Pedir("Introduce espacio ocupado: "));
        coleccion[contadorReg].fecha.anyo = 
            PedirEnteroEnRango("Fecha, año lanzamiento (entre 1940 y 2100): ",
            1940, 2100);
        coleccion[contadorReg].fecha.mes = Convert.ToByte(PedirNoVacio("Introduce mes: "));
        coleccion[contadorReg].valoracion = PedirValoracion();
        contadorReg++;
    }

    static void VerRegistro(TipoJuego[] coleccion, int contadorReg)
    {
        int verMaxPagina = 22;

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
    }

    private static void ProcesarOpcionesBusqueda(TipoJuego[] coleccion, int contadorReg)
    {
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
                MostrarRegistroDetallado(coleccion, numRegMostrar);
            }
            else
                Console.WriteLine("Error, nº registro no válido");
        }

        else if (opcionBuscar == "2")
        {
            Console.Write("Introduce el título: ");
            string tituloBuscar = Console.ReadLine();

            if (!BuscarPorTitulo(coleccion, contadorReg, tituloBuscar))
                Console.WriteLine("Error, Titulo " + "\"" +
                    (tituloBuscar) + "\"" + " desconocido");
        }
        else
            Console.WriteLine("Opción de búsqueda no válida");
    }

    static bool BuscarPorTitulo(TipoJuego[] coleccion, int contadorReg, string tituloBuscar)
    {
        bool encontrado = false;

        for (int i = 0; i < contadorReg; i++)
        {
            if ((coleccion[i].titulo.ToUpper() == tituloBuscar.ToUpper()))
            {
                MostrarRegistroDetallado(coleccion, i);
                encontrado = true;
            }
        }
        return encontrado;
    }

    static void Buscar(TipoJuego[] coleccion, string textoBuscar, int contadorReg)
    {
        int verMaxPagina = 22;
        int cantidadEncontrados = 0;

        for (int i = 0; i < contadorReg; i++)
        {
            if (coleccion[i].titulo.ToUpper().Contains(textoBuscar.ToUpper()) ||
                coleccion[i].plataforma.ToUpper().Contains(textoBuscar.ToUpper()) ||
                coleccion[i].categoria.ToUpper().Contains(textoBuscar.ToUpper()))
            {
                cantidadEncontrados++;
                MostrarRegistroBreve(coleccion, i);

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


    static void Borrar(TipoJuego[] coleccion, int numRegBorrar, ref int contadorReg)
    {
        Console.WriteLine();

        if (numRegBorrar >= 0 && numRegBorrar < contadorReg)
        {
            MostrarRegistroBreve(coleccion, numRegBorrar);
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
    }

    static void Ordenar(TipoJuego[] coleccion, int contadorReg)
    {
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

    }

    static void EliminarRedundancias(TipoJuego[] coleccion, int contadorReg)
    {
        for (int i = 0; i < contadorReg; i++)
        {
            coleccion[i].titulo = QuitarEspaciosRedundantes(coleccion[i].titulo);
            coleccion[i].plataforma = QuitarEspaciosRedundantes(coleccion[i].plataforma);
            coleccion[i].categoria = QuitarEspaciosRedundantes(coleccion[i].categoria);
        }
        Console.WriteLine("Eliminados espacios sobrantes");
    }

    static void Modificar(TipoJuego[] coleccion, int numRegModificar, int contadorReg)
    {
        MostrarRegistroDetallado(coleccion, numRegModificar);

        coleccion[numRegModificar].titulo =
            PedirConValorPorDefecto("Titulo: ", coleccion[numRegModificar].titulo);
        coleccion[numRegModificar].plataforma =
            PedirConValorPorDefecto("Plataforma: ", coleccion[numRegModificar].plataforma);
        coleccion[numRegModificar].fecha.anyo = 
            Convert.ToInt32(PedirConValorPorDefecto("Año: ", 
                coleccion[numRegModificar].fecha.anyo.ToString() ));
        coleccion[numRegModificar].fecha.mes =
            Convert.ToByte(PedirConValorPorDefecto("Mes: ",
                coleccion[numRegModificar].fecha.mes.ToString()));
        coleccion[numRegModificar].categoria =
            PedirConValorPorDefecto("Categoria: ", coleccion[numRegModificar].categoria);
        coleccion[numRegModificar].espacioOcupado =
            Convert.ToInt32(PedirConValorPorDefecto("Espacio Ocupado?: ",
                coleccion[numRegModificar].espacioOcupado.ToString()));
        coleccion[numRegModificar].valoracion =
            Convert.ToSingle(PedirConValorPorDefecto("Valoración (1 a 10 o -1)?: ",
                coleccion[numRegModificar].valoracion.ToString()));
    }
    
    // Cuerpo del programa

    static void Main()
    {
        const string TERMINAR = "T",
            ANYADIR = "1", VER_TODOS = "2", VER_UNO = "3",
            BUSCAR = "4", MODIFICAR = "5", BORRAR = "6",
            ORDENAR = "7", REDUNDANCIAS = "8";

        const uint CAPACIDAD_MAX = 10000;
        TipoJuego[] coleccion = new TipoJuego[CAPACIDAD_MAX];
        int contadorReg = 0;
        string opcionElegida;

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
                    if (contadorReg >= CAPACIDAD_MAX)
                        Console.WriteLine("Error, No caben mas registros");
                    else
                        Anyadir(coleccion, ref contadorReg);
                    break;

                case VER_TODOS:
                    if (contadorReg > 0)
                        VerRegistro(coleccion, contadorReg);
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case VER_UNO:
                    ProcesarOpcionesBusqueda(coleccion, contadorReg);
                    break;

                case BUSCAR:
                    if (contadorReg > 0)
                    {
                        string textoBuscar = Pedir("Introduce un texto para buscar: ");
                        Buscar(coleccion, textoBuscar, contadorReg);
                    }
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case MODIFICAR:
                    if (contadorReg > 0)
                    {
                        int numRegModificar = Convert.ToInt32(
                            Pedir("Introduce un nº de resgistro de 1 a "
                            + contadorReg + " para modificar: ")) - 1;

                        if (numRegModificar >= 0 && numRegModificar < contadorReg)
                        {
                            Modificar(coleccion, numRegModificar, contadorReg);
                        }
                        else
                            Console.WriteLine("Error, nº registro no válido");
                    }
                    else
                        Console.WriteLine("No hay registros");

                    break;

                case BORRAR:
                    if (contadorReg > 0)
                    {
                        Console.Write("Introduce un nº de resgistro de 1 a " +
                            contadorReg + " para modificar: ");

                        int numRegBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine();

                        if (numRegBorrar >= 0 && numRegBorrar < contadorReg)
                            Borrar(coleccion, numRegBorrar, ref contadorReg);
                        else
                            Console.WriteLine("Error, nº registro no válido");
                    }
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case ORDENAR:
                    if (contadorReg > 0)
                        Ordenar(coleccion, contadorReg);
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case REDUNDANCIAS:
                    if (contadorReg > 0)
                    {
                        EliminarRedundancias(coleccion, contadorReg);
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
