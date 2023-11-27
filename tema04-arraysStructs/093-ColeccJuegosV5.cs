/*

93. Gestor de colecci�n de juegos, versi�n 5 (basado en el examen de 2014-2015, 
tema 4, grupo presencial)

Crea un programa en C# que permita almacenar hasta 10000 juegos de ordenador o consola.
Para cada juego, debe permitir al usuario almacenar la siguiente informaci�n:

 � T�tulo (por ejemplo, GranTurismo 6)

 � Plataforma (por ejemplo, PS3)

 � Categor�a (por ejemplo, carreras)

 � Espacio ocupado (en MB, n�mero entero)

 � Fecha de lanzamiento (mes y a�o, en forma de struct anidado) (por ejemplo 2013, 12)

 � Valoraci�n (por ejemplo, 8.7)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - A�adir un nuevo juego (al final de los datos existentes). El t�tulo y la 
plataforma no deben estar vac�os. El a�o, si se introduce, debe ser de 1940 a 
2100. La valoraci�n, si se introduce, debe ser de 0 a 10. No se debe realizar 
ninguna otra validaci�n.

2 - Mostrar nombre, categor�a y plataforma de todos los juegos almacenados (los 
tres datos en una misma l�nea, con el formato "GranTurismo 6 - Carreras (PS3)". 
Cada juego debe aparecer en una l�nea distinta, precedido por el n�mero de 
registro (empezando a contar desde 1). Si hay m�s de 22 juegos, se deber� hacer 
una pausa tras mostrar cada bloque de 22 juegos, y esperar a que el usuario 
pulse Intro antes de seguir. Se deber� avisar si no hay datos.

3 - Ver todos los datos de un cierto juego (a partir de su n�mero de registro  
o bien de su t�tulo exacto -sin distinci�n de may�sculas y min�sculas-, seg�n 
elija el usuario), contando desde 1). Se deber� avisar (pero no volver a pedir) 
si el n�mero no es v�lido.

4 - Buscar juegos que contengan un determinado texto (b�squeda parcial, en 
cualquier campo de texto, sin distinci�n de may�sculas y min�sculas). Debe 
mostrar el n�mero de registro, el t�tulo, la plataforma, el a�o y la 
valoraci�n, haciendo una pausa despu�s de cada 22 filas.

5 - Modificar un registro: pedir� al usuario su n�mero, mostrar� el valor 
anterior de cada campo y permitir� pulsar Intro para no modificar alguno de los 
datos. Se debe avisar al usuario (pero no volver a pedir) si introduce un 
n�mero de registro incorrecto . El a�o y la calificaci�n, si se modifican, 
deben ser v�lidos.

6 - Borrar un registro, en la posici�n indicada por el usuario. Se le debe 
avisar (pero no volver a preguntar) si introduce un n�mero de registro 
incorrecto. Debe mostrar el registro que se va a eliminar y solicitar 
confirmaci�n antes de la eliminaci�n.

7 - Ordenar los datos alfab�ticamente, por t�tulo y (en caso de coincidir el 
t�tulo) por plataforma.

8 - Eliminar espacios redundantes: eliminar espacios finales, espacios 
iniciales y espacios duplicados en el t�tulo, la plataforma y la categor�a.

T - Terminar (como no sabemos almacenar la informaci�n en archivo ni base de 
datos, la informaci�n se perder�).

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
        TipoJuego[] colecion = new TipoJuego[capacidadMax];
        int contadorReg = 0;
        string opcionElegida;
        int verMaxPagina = 22;

        do
        {
            Console.WriteLine();
            Console.WriteLine("       - MEN� - ");
            Console.WriteLine(ANYADIR + "- A�adir un nuevo juego");
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
                            Console.Write("Introduce un t�tulo: ");
                            colecion[contadorReg].titulo = Console.ReadLine();
                        }
                        while (colecion[contadorReg].titulo == "");

                        do
                        {
                            Console.Write("Introduce plataforma: ");
                            colecion[contadorReg].plataforma = Console.ReadLine();
                        }
                        while (colecion[contadorReg].plataforma == "");

                        Console.Write("Introduce la categor�a: ");
                        colecion[contadorReg].categoria = Console.ReadLine();

                        Console.Write("Introduce espacio ocupado: ");
                        colecion[contadorReg].espacioOcupado =
                            Convert.ToInt32(Console.ReadLine());

                        string anyo = "";
                        do
                        {
                            Console.Write("Fecha, a�o lanzamiento (entre 1940 y 2100): ");
                            anyo = Console.ReadLine();
                            colecion[contadorReg].fecha.anyo = anyo;
                        }
                        while (Convert.ToSingle(anyo) < 1940 || Convert.ToSingle(anyo) > 2100);

                        Console.Write("mes: ");
                        colecion[contadorReg].fecha.mes = Console.ReadLine();

                        string valoracion = "";
                        do
                        {
                            Console.Write("Valoracion de 0 a 10: ");
                            valoracion = Console.ReadLine();
                            if (valoracion == "")
                            {
                                colecion[contadorReg].valoracion = -1;
                            }
                            else
                            {
                                colecion[contadorReg].valoracion = Convert.ToSingle(valoracion);
                            }
                        } while (!
                            ((colecion[contadorReg].valoracion == -1)
                            || (colecion[contadorReg].valoracion >= 0 
                                && colecion[contadorReg].valoracion <= 10))
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
                                colecion[i].titulo, colecion[i].categoria,
                                colecion[i].plataforma);
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
                    Console.WriteLine("-Opciones de b�squeda-");
                    Console.WriteLine("1.- Buscar por n� de registro");
                    Console.WriteLine("2.- Buscar por titulo exacto");
                    string opcionBuscar = Console.ReadLine();

                    if (opcionBuscar == "1")
                    {
                        Console.Write("Introduce un n� de registro de 1 a " + (contadorReg) + " ");
                        int numRegMostrar = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (numRegMostrar >= 0 && numRegMostrar < contadorReg)
                        {
                            Console.Write("Titulo: " + colecion[numRegMostrar].titulo + "| ");
                            Console.Write("Plataforma: " + colecion[numRegMostrar].plataforma + "| ");
                            Console.Write("Categor�a: " + colecion[numRegMostrar].categoria + "| ");
                            Console.Write("Espacio Ocupado: " + colecion[numRegMostrar].espacioOcupado + "| ");
                            Console.Write("Fecha: a�o: " + colecion[numRegMostrar].fecha.anyo + ", ");
                            Console.Write("mes: " + colecion[numRegMostrar].fecha.mes + "| ");
                            Console.Write("Valoracion: " + colecion[numRegMostrar].valoracion);
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Error, n� registro no v�lido");
                    }

                    else if (opcionBuscar == "2")
                    {
                        Console.Write("Introduce el t�tulo: ");
                        string tituloBuscar = Console.ReadLine();
                        bool encontrado = false;
                        Console.WriteLine();
                        for (int i = 0; i < contadorReg; i++)
                        {
                            if (colecion[i].titulo.ToUpper() == tituloBuscar.ToUpper())
                            {
                                Console.Write("T�tulo: " + colecion[i].titulo + "| ");
                                Console.Write("Plataforma: " + colecion[i].plataforma + "| ");
                                Console.Write("Categor�a: " + colecion[i].categoria + "| ");
                                Console.Write("Espacio Ocupado: " + colecion[i].espacioOcupado + "| ");
                                Console.Write("Fecha: a�o: " + colecion[i].fecha.anyo + ", ");
                                Console.Write("mes: " + colecion[i].fecha.mes + "| ");
                                Console.Write("Valoraci�n: " + colecion[i].valoracion);
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
                        Console.WriteLine("Opci�n de b�squeda no v�lida");
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
                            if (colecion[i].titulo.ToUpper().Contains(textoBuscar.ToUpper()) ||
                                colecion[i].plataforma.ToUpper().Contains(textoBuscar.ToUpper()) ||
                                colecion[i].categoria.ToUpper().Contains(textoBuscar.ToUpper()))
                            {
                                cantidadEncontrados++;
                                Console.WriteLine("{0}: {1} - {2} ({3})", i + 1,
                                    colecion[i].titulo, colecion[i].categoria,
                                    colecion[i].plataforma);

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
                            Console.WriteLine("No se ha encontrado ning�n texto por " + "\""
                                + textoBuscar + "\"");
                    }
                    else
                        Console.WriteLine("No hay registros");
                    break;

                case MODIFICAR:
                    Console.Write("Introduce un n� de resgistro de 1 a "
                        + contadorReg + " para modificar: ");
                    int numRegModificar = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    if (numRegModificar >= 0 && numRegModificar < contadorReg)
                    {
                        Console.WriteLine("T�tulo: " + colecion[numRegModificar].titulo);
                        Console.Write("Nuevo t�tulo? ");
                        string nuevoTitulo = Console.ReadLine();
                        if (nuevoTitulo != "")
                            colecion[numRegModificar].titulo = nuevoTitulo;

                        Console.WriteLine("Plataforma: " + colecion[numRegModificar].plataforma);
                        Console.Write("Nueva plataforma? ");
                        string nuevaPlataforma = Console.ReadLine();
                        if (nuevaPlataforma != "")
                            colecion[numRegModificar].plataforma = nuevaPlataforma;

                        Console.WriteLine("Categor�a: " +
                            colecion[numRegModificar].categoria);
                        Console.Write("Nueva categor�a? ");
                        string nuevaCategoria = Console.ReadLine();
                        if (nuevaPlataforma != "")
                            colecion[numRegModificar].categoria = nuevaCategoria;

                        Console.WriteLine("Espacio Ocupado: "
                            + colecion[numRegModificar].espacioOcupado);
                        Console.Write("Nuevo espacio ocupado? ");
                        string nuevoEspacioOcu = Console.ReadLine();
                        if (nuevoEspacioOcu != "")
                            colecion[numRegModificar].espacioOcupado
                                = Convert.ToInt32(nuevoEspacioOcu);

                        Console.WriteLine("Fecha, a�o lanzamiento(entre 1940 y 2100): " +
                            colecion[numRegModificar].fecha.anyo);
                        Console.Write("Nuevo a�o? ");
                        string nuevoAnyo = Console.ReadLine();

                        if (nuevoAnyo != "")
                        {
                            if (Convert.ToInt32(nuevoAnyo) < 1940
                                || Convert.ToInt32(nuevoAnyo) > 2100)
                            {
                                Console.WriteLine("A�o no v�lido. No se cambiar�.");
                            }
                            else
                            {
                                colecion[numRegModificar].fecha.anyo = nuevoAnyo;
                            }
                        }

                        Console.WriteLine("Mes " + colecion[numRegModificar].fecha.mes);
                        Console.Write("Nuevo mes? ");
                        string nuevoMes = Console.ReadLine();

                        if (nuevoMes != "")
                            colecion[numRegModificar].fecha.mes = nuevoMes;

                        Console.WriteLine("Valoracion: " + colecion[numRegModificar].valoracion);
                        Console.Write("Cambiar valoracion? ");
                        string nuevaValoracion = Console.ReadLine();

                        if (nuevaValoracion != "")
                        {
                            if (Convert.ToSingle(nuevaValoracion) < 0
                                || Convert.ToSingle(nuevaValoracion) > 10)
                            {
                                Console.WriteLine("Valoraci�n no v�lida. No se cambiar�.");
                            }
                            else
                            {
                                colecion[numRegModificar].valoracion = Convert.ToSingle(nuevaValoracion);
                            }
                        }
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Error, n� registro no v�lido");
                    break;

                case BORRAR:
                    Console.Write("Introduce un n� de resgistro de 1 a " +
                        (contadorReg) + " para modificar: ");
                    int numRegBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine();

                    if (numRegBorrar >= 0 && numRegBorrar < contadorReg)
                    {
                        Console.WriteLine("{0}: {1} - {2} ({3})", numRegBorrar + 1,
                                colecion[numRegBorrar].titulo,
                                colecion[numRegBorrar].categoria,
                                colecion[numRegBorrar].plataforma);
                        Console.WriteLine("Eliminar la ficha, si o no?");
                        string confirmarEliminar = Console.ReadLine().ToUpper();

                        if (confirmarEliminar == "SI" || confirmarEliminar == "S")
                        {
                            for (int i = numRegBorrar; i < contadorReg; i++)
                            {
                                colecion[i] = colecion[i + 1];
                            }
                            contadorReg--;
                            Console.WriteLine("n�Reg " + "\""
                                + (numRegBorrar + 1) + "\" Eliminado ");
                        }
                    }
                    else
                        Console.WriteLine("Error, n� registro no v�lido");
                    break;

                case ORDENAR:
                    for (int i = 0; i < contadorReg - 1; i++)
                    {
                        for (int j = i + 1; j < contadorReg; j++)
                        {
                            if ( // Por titulo, si son distintos
                                String.Compare(colecion[i].titulo,
                                    colecion[j].titulo, true) > 0 ||
                                 // Por plataforma, si coincide el t�tulo
                                 (
                                    (colecion[i].titulo.ToUpper() ==
                                        colecion[i].titulo.ToUpper()) &&
                                    String.Compare(colecion[i].plataforma,
                                        colecion[j].plataforma, true) > 0)
                                )
                            {
                                TipoJuego aux = colecion[i];
                                colecion[i] = colecion[j];
                                colecion[j] = aux;
                            }
                        }
                    }
                    Console.WriteLine("Ordenados alfab�ticamente t�tulo - plataforma");
                    break;

                case REDUNDANCIAS:
                    if (contadorReg > 0)
                    {
                        for (int i = 0; i < contadorReg; i++)
                        {
                            colecion[i].titulo = colecion[i].titulo.Trim();
                            while (colecion[i].titulo.Contains("  "))
                            {
                                colecion[i].titulo =
                                    colecion[i].titulo.Replace("  ", " ");
                            }

                            colecion[i].plataforma = colecion[i].plataforma.Trim();
                            while (colecion[i].plataforma.Contains("  "))
                            {
                                colecion[i].plataforma =
                                    colecion[i].plataforma.Replace("  ", " ");
                            }

                            colecion[i].categoria = colecion[i].categoria.Trim();
                            while (colecion[i].categoria.Contains("  "))
                            {
                                colecion[i].categoria =
                                    colecion[i].categoria.Replace("  ", " ");
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
