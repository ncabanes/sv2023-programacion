/*
89. Contabilidad doméstica (examen del tema 4, grupo presencial, 2013-2014, versión simplificada)

Crea un programa en C# que pueda almacenar hasta 10000 gastos e ingresos, 
para crear un pequeño sistema de contabilidad doméstica. 
Para cada gasto (o ingreso), debe permitir guardar los siguientes datos:

    Fecha (8 caracteres: formato AAAAMMDD)
    Descripción del gasto o ingreso (por ejemplo, "Ampliación de RAM para el ordenador")
    Categoría (por ejemplo, "estudios")
    Importe (positivo si es un ingreso, negativo si es un gasto)

El programa debe permitir al usuario realizar las siguientes operaciones:

1- Añadir un nuevo gasto (o ingreso). La fecha y la descripción no deben estar vacías.
No hace falta validar los demás datos.

2- Mostrar todos los gastos (o ingresos) de una cierta categoría (por ejemplo, "estudios"). 
Al final de todos los datos se mostrará el importe total de los datos mostrados.
Se mostrarán en una misma línea todos los datos de cada gasto.

3- Buscar gastos (o ingresos) cuya descripción sea la que introduzca el usuario.

4- Modificar una ficha (pedirá el número de ficha al usuario; 
se mostrará el valor anterior de cada campo y se podrá pulsar Intro
para no modificar alguno de los datos).Se debe avisar (pero no volver a pedir)
si el usuario introduce un número de ficha incorrecto. No hace falta validar ningún dato.

5- Borrar un cierto dato, a partir del número de registro que indique el usuario. 
Se debe avisar (pero no volver a pedir) si introduce un número incorrecto.
Se debe mostrar la ficha que se va a borrar y pedir confirmación antes de proceder al borrado.

S- Salir (como aún no sabemos almacenar la información, los datos se perderán) 

Julio, retoques menores por Nacho

*/

using System;

class structExamen
{
    struct tipoFicha
    {
        public string fecha;
        public string descripcion;
        public string categoria;
        public double importe;
    }

    public static void Main()
    {
        const uint CAPACIDAD = 10000;
        const string ANYADIR = "1", MOSTRAR = "2", BUSCAR = "3",
            MODIFICAR = "4", BORRAR = "5", SALIR_MAYS = "S", SALIR_MINS = "s";
        tipoFicha[] fichas = new tipoFicha[CAPACIDAD];
        string opcion;
        int contadorRegistros = 0;
        double importeTotal;
        bool categoriaEncontrada = false;
        bool terminado = false;

        do
        {
            Console.WriteLine( ANYADIR + ". Añadir nueva ficha");
            Console.WriteLine( MOSTRAR + ". Mostrar fichas por categoría");
            Console.WriteLine( BUSCAR + ". Buscar ficha por descripción");
            Console.WriteLine( MODIFICAR + ". Modificar una ficha");
            Console.WriteLine( BORRAR + ". Borrar una ficha");
            Console.WriteLine( SALIR_MAYS + ". Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case SALIR_MAYS:
                case SALIR_MINS:
                    Console.WriteLine("Adios");
                    terminado = true;
                    break;

                case ANYADIR:
                    if (contadorRegistros < CAPACIDAD)
                    {
                        Console.Write("Importe: ");
                        fichas[contadorRegistros].importe = 
                            Convert.ToDouble(Console.ReadLine());

                        do
                        {
                            Console.Write("Fecha (formato AAAAMMDD): ");
                            fichas[contadorRegistros].fecha = Console.ReadLine();
                        }
                        while (fichas[contadorRegistros].fecha == "");

                        do
                        {
                            Console.Write("Descripción: ");
                            fichas[contadorRegistros].descripcion = Console.ReadLine();
                        }
                        while (fichas[contadorRegistros].descripcion == "");

                        Console.Write("Categoría: ");
                        fichas[contadorRegistros].categoria = Console.ReadLine();
                        
                        contadorRegistros++;
                        Console.WriteLine();
                    }
                    break;

                case MOSTRAR:
                    Console.Write("De que categoría quieres consultar los datos: ");
                    string categoriaBuscar = Console.ReadLine();
                    importeTotal = 0;

                    Console.WriteLine();
                    for (int i = 0; i < contadorRegistros; i++)
                    {
                        if (fichas[i].categoria == categoriaBuscar)
                        {
                            Console.Write("Nº Ficha:\"" + (i + 1) + "\"| ");
                            Console.Write("Fecha: " + fichas[i].fecha + ", ");
                            Console.Write("Descripción: " +
                                fichas[i].descripcion + ", ");

                            Console.Write("importe " + fichas[i].importe);

                            importeTotal += fichas[i].importe;
                            categoriaEncontrada = true;
                            Console.WriteLine();
                        }
                    }

                    if (categoriaEncontrada)
                        Console.WriteLine("Importe total = " + importeTotal + " ");
                    else
                        Console.WriteLine("Error, categoría deconocida");

                    importeTotal = 0;
                    Console.WriteLine();
                    break;

                case BUSCAR:
                    Console.Write("Introduce una descripción para buscar: ");
                    string textoBuscar = Console.ReadLine();
                    Console.WriteLine();

                    categoriaEncontrada = false;
                    importeTotal = 0;
                    for (int i = 0; i < contadorRegistros; i++)
                    {
                        if (textoBuscar == fichas[i].descripcion)
                        {
                            Console.Write("Nº Ficha:\"" + (i + 1) + "\"| ");
                            Console.Write("Fecha: " + fichas[i].fecha + ", ");
                            Console.Write("Descripción: " +
                                fichas[i].descripcion + ", ");
                            Console.Write("importe " + fichas[i].importe);

                            importeTotal += fichas[i].importe;
                            categoriaEncontrada = true;
                            Console.WriteLine();
                        }
                    }
                    if (categoriaEncontrada)
                        Console.WriteLine("Importe total = " + importeTotal + " ");
                    else
                        Console.WriteLine("Error, no coincide la descripción");

                    Console.WriteLine();
                    break;

                case MODIFICAR:
                    Console.Write("Introduce un número de ficha de 1 a " +
                        contadorRegistros + ": ");
                    int registroConsultar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (registroConsultar < contadorRegistros &&
                        registroConsultar >= 0 && contadorRegistros > 0)
                    {
                        //IMPORTE
                        Console.WriteLine("Importe " +
                            fichas[registroConsultar].importe);
                        Console.Write("Nuevo importe? ");
                        string nuevoImporte = Console.ReadLine();
                        
                        if (nuevoImporte != "")
                        {
                            fichas[registroConsultar].importe =
                                Convert.ToDouble(nuevoImporte);
                        }

                        //FECHA
                        Console.WriteLine("Fecha: " +
                            fichas[registroConsultar].fecha + ", ");
                        Console.Write("Cambiar fecha? ");
                        string nuevaFecha = Console.ReadLine();
                        
                        if (nuevaFecha != "")
                            fichas[registroConsultar].fecha = nuevaFecha;

                        //DESCRIPCION
                        Console.WriteLine("Descripción: " +
                            fichas[registroConsultar].descripcion + ", ");
                        Console.Write("Nueva descripción? ");
                        string nuevaDescripcion = Console.ReadLine();

                        if (nuevaDescripcion != "")
                            fichas[registroConsultar].descripcion = nuevaDescripcion;

                        //CATEGORIA
                        Console.WriteLine("Categoría: " +
                            fichas[registroConsultar].categoria);
                        Console.Write("Cambiar categoría? ");
                        string nuevaCategoria = Console.ReadLine();

                        if (nuevaCategoria != "")
                            fichas[registroConsultar].categoria = nuevaCategoria;
                    }
                    else
                        Console.WriteLine("Error, número de registro incorrecto");

                    Console.WriteLine();
                    break;

                case BORRAR:
                    Console.Write("Número de ficha que quieres borrar de 1 a " +
                        contadorRegistros + ": ");
                    int registroBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (registroBorrar < contadorRegistros && registroBorrar >=
                        0 && contadorRegistros > 0)
                    {
                        Console.Write("Nº Ficha:\"" + (registroBorrar + 1) + "\"| ");
                        Console.Write("Fecha: " + fichas[registroBorrar].fecha + ", ");
                        Console.Write("Descripción: " +
                            fichas[registroBorrar].descripcion + ", ");
                        Console.Write("Categoría: " +
                            fichas[registroBorrar].categoria + ", ");
                        Console.Write("importe " + fichas[registroBorrar].importe);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Quieres eliminar la fIcha " + "\""
                            + (registroBorrar + 1) + "\"? si o no: ");
                        string confirmarBorrar = Console.ReadLine();

                        Console.WriteLine();
                        if (confirmarBorrar == "si")
                        {
                            Console.WriteLine("Ficha " + "\"" +
                                contadorRegistros + "\"" + " borrada");

                            for (int i = registroBorrar; i < contadorRegistros; i++)
                            {
                                fichas[i] = fichas[i + 1];
                            }
                            contadorRegistros--;
                        }
                    }
                    else
                        Console.WriteLine("Número de ficha erroneo");

                    Console.WriteLine();
                    break;
            }
        }
        while ( ! terminado ) ;
    }
}
