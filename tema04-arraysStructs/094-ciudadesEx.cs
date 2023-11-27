/*94. Ciudades (examen de 2017-2018, tema 4, grupo presencial)
Crea un programa en C# que permita almacenar hasta 20000 ciudades. Para cada 
ciudad, debe permitir al usuario almacenar la siguiente información:

- Nombre (por ejemplo, Alicante)
- País (por ejemplo, España)
- Población (por ejemplo, 300.000)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir una nueva ciudad. El nombre y el país no pueden estar vacíos. Una 
población desconocida (introducida en blanco, pulsando Intro sin teclear nada) 
debe almacenarse como un 0.

2 - Mostrar todas las ciudades, cada ciudad en una línea (número de registro, 
nombre y país, como en "1- Alicante, España"). Si el nombre de la ciudad tiene 
más de 20 caracteres, deberás mostrar los primeros 20 caracteres seguidos de 
"...". Si el nombre del país tiene más de 40 caracteres, deberás mostrar el 
resultado de truncarlo a 40 caracteres y luego eliminar los espacios 
intermedios. Debes hacer una pausa después de cada 24 filas. Si el usuario 
presiona Intro y no escribe ningún texto, se mostrarán los siguientes 24 datos, 
pero si teclea "fin" y luego presiona Intro, no se mostrarán más datos.

3 - Buscar ciudades que contengan un determinado texto en su nombre o el nombre 
del país (búsqueda parcial, sin distinción de mayúsculas y minúsculas). Debe 
mostrar el número de registro, el nombre, el país y la población, en la misma 
línea, haciendo una pausa después de cada 24 filas. Si no se había introducido 
la población, debe mostrar "Población desconocida" en lugar de 0.

4 - Modificar un registro: pedirá al usuario el número de registro, mostrará el 
valor anterior de cada campo y permitirá que el usuario presione Intro si 
decide no modificar ninguno de los datos. Se le debe pedir nuevamente si 
introduce un número de registro incorrecto, tantas veces como sea necesario 
(pero podrá escribir 0 para salir sin actualizar ningún registro). Antes de 
almacenar los datos, se deben eliminar los espacios iniciales, los espacios 
finales y los espacios duplicados de cada campo.

5 - Insertar un registro, en la posición indicada por el usuario. Se le debe 
avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto o si el array está lleno. Valida los datos como en la opción 1.

6 - Eliminar un registro, en la posición indicada por el usuario. Se le debe 
avisar (pero no se le debe preguntar nuevamente) si introduce un número de 
registro incorrecto. El programa debe mostrar el registro que se eliminará y 
solicitará confirmación antes de la eliminación. Además, debe avisar al usuario 
si se ha borrado el último dato que quedaba.

7 - Ordenar los datos. Se le preguntará al usuario si desea ordenar usando como 
criterio el nombre de la ciudad o del nombre del país, y el programa actuará en 
consecuencia.

8 - Encontrar posibles errores ortográficos: mostrará los registros que 
contienen dos símbolos de puntuación consecutivos (.. o ,,) o una letra 
repetida tres veces (como Misssissippi).

S - Salir (como no almacenamos la información, se perderá).*/

// Miguel Ángel (...), retoques por Nacho

using System;

class Ciudades
{
    struct TipoCiudad
    {
        public string nombre;
        public string pais;
        public int poblacion;
    }

    static void Main()
    {
        const string ANYADIR = "1", MOSTRAR = "2", BUSCAR = "3", MODIFICAR = "4",
            INSERTAR = "5", ELIMINAR = "6", ORDENAR = "7", ENCONTRAR_ERRORES = "8",
            SALIR = "S";
        const ushort CAPACIDAD = 20000;
        TipoCiudad[] ciudades = new TipoCiudad[CAPACIDAD];
        bool salir = false;
        string opcion;
        ushort numDatos = 0;

        do
        {
            Console.WriteLine(ANYADIR + ". Añadir una ciudad nueva");
            Console.WriteLine(MOSTRAR + ". Mostrar todas las ciudades");
            Console.WriteLine(BUSCAR + ". Buscar ciudades");
            Console.WriteLine(MODIFICAR + ". Modificar un registro");
            Console.WriteLine(INSERTAR + ". Insertar un registro");
            Console.WriteLine(ELIMINAR + ". Eliminar un registro");
            Console.WriteLine(ORDENAR + ". Ordenar los datos");
            Console.WriteLine(ENCONTRAR_ERRORES + ". Encontrar errores ortográficos");
            Console.WriteLine(SALIR + ". Salir");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcion)
            {
                case ANYADIR:
                    if (CAPACIDAD == numDatos)
                    {
                        Console.WriteLine("El array está lleno.");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Nombre de la ciudad: ");
                            ciudades[numDatos].nombre = Console.ReadLine();
                            if (ciudades[numDatos].nombre == "")
                            {
                                Console.WriteLine("Debe introducir un nombre.");
                            }
                        }
                        while (ciudades[numDatos].nombre == "");

                        do
                        {
                            Console.Write("País: ");
                            ciudades[numDatos].pais = Console.ReadLine();
                            if (ciudades[numDatos].pais == "")
                            {
                                Console.WriteLine("Debe introducir un país.");
                            }
                        }
                        while (ciudades[numDatos].pais == "");

                        Console.Write("Población: ");
                        string poblacionTemp = Console.ReadLine();
                        if (poblacionTemp == "")
                        {
                            ciudades[numDatos].poblacion = 0;
                        }
                        else
                        {
                            ciudades[numDatos].poblacion =
                                Convert.ToInt32(poblacionTemp);
                        }

                        numDatos++;
                    }
                    break;

                case MOSTRAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos");
                    }
                    else
                    {
                        bool visualizacionTerminada = false;
                        int i = 0;
                        while (i < numDatos && ! visualizacionTerminada)
                        {
                            string ciudadMostrar = ciudades[i].nombre;
                            if (ciudadMostrar.Length > 20)
                                ciudadMostrar = ciudadMostrar.Substring(0, 20) + "...";
                            string paisMostrar = ciudades[i].pais;
                            if (ciudadMostrar.Length > 20)
                                ciudadMostrar = ciudadMostrar.Substring(0, 40).Replace(" ", "");

                            Console.WriteLine("{0}-{1}, {2}", i + 1,
                                ciudadMostrar, paisMostrar);
                            if ((i + 1) % 24 == 0)
                            {
                                Console.Write("Pulse Intro para continuar" +
                                " o fin para finalizar: ");
                                string respuestaPausa = Console.ReadLine().ToLower();
                                if (respuestaPausa == "fin")
                                {
                                    visualizacionTerminada = true;
                                }
                            }
                            i++;
                        }
                    }
                    break;

                case BUSCAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos");
                    }
                    else
                    {
                        int contadorPausaBuscar = 0;
                        Console.Write("Texto a buscar: ");
                        string textoBuscar = Console.ReadLine();
                        for (int i = 0; i < numDatos; i++)
                        {
                            if ((ciudades[i].nombre.ToUpper()
                                .Contains(textoBuscar.ToUpper())) ||
                                (ciudades[i].pais.ToUpper()
                                .Contains(textoBuscar.ToUpper())))
                            {
                                Console.Write("{0}-{1}, {2}. ", i + 1,
                                    ciudades[i].nombre, ciudades[i].pais);
                                if (ciudades[i].poblacion == 0)
                                {
                                    Console.WriteLine("Población desconocida.");
                                }
                                else
                                {
                                    Console.WriteLine("Población: ",
                                        ciudades[i].poblacion);
                                }
                                contadorPausaBuscar++;
                                if (contadorPausaBuscar % 24 == 0)
                                {
                                    Console.WriteLine(
                                        "Pulsa Intro para continuar");
                                    Console.ReadLine();
                                    contadorPausaBuscar = 0;
                                }
                            }
                        }
                    }
                    break;

                case MODIFICAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos");
                    }
                    else
                    {
                        Console.Write(
                            "Introduce el número de registro a modificar (0=salir) ");
                        int numRegistroModif = Convert.ToUInt16(Console.ReadLine());
                        while (numRegistroModif > numDatos || numRegistroModif < 0)
                        {
                            Console.WriteLine(
                                "Número de registro no válido");
                            numRegistroModif = Convert.ToUInt16(Console.ReadLine());
                        }
                        if (numRegistroModif != 0)
                        { 
                            Console.WriteLine("Nombre anterior: " +
                                ciudades[numRegistroModif - 1].nombre);
                            Console.Write("Nombre nuevo: ");
                            string textoTemp = Console.ReadLine();
                            if (textoTemp != "")
                            {
                                while (textoTemp.Contains("  "))
                                {
                                    textoTemp =
                                        textoTemp.Replace(" ", "  ");
                                }
                                ciudades[numRegistroModif - 1].nombre =
                                    textoTemp.Trim();
                            }

                            Console.WriteLine("País anterior: " +
                                ciudades[numRegistroModif - 1].pais);
                            Console.Write("País nuevo: ");
                            textoTemp = Console.ReadLine();
                            if (textoTemp != "")
                            {
                                while (textoTemp.Contains("  "))
                                {
                                    textoTemp =
                                        textoTemp.Replace(" ", "  ");
                                }
                                ciudades[numRegistroModif - 1].pais =
                                    textoTemp.Trim();
                            }

                            Console.WriteLine("Población anterior: " +
                                ciudades[numRegistroModif - 1].poblacion);
                            Console.Write("Población nueva: ");
                            textoTemp = Console.ReadLine();
                            if (textoTemp != "")
                            {
                                ciudades[numRegistroModif - 1].poblacion =
                                    Convert.ToInt32(textoTemp);
                            }
                        }
                    }
                    break;

                case INSERTAR:
                    if (CAPACIDAD == numDatos)
                    {
                        Console.WriteLine("El array está lleno.");
                    }
                    else
                    {
                        Console.Write("Introduce la posición a insertar: ");
                        int numRegistroInsertar = Convert.ToUInt16(Console.ReadLine());
                        if (numRegistroInsertar > numDatos)
                        {
                            Console.WriteLine("Posición no válida.");
                        }
                        else
                        {
                            for (int i = numDatos; i > numRegistroInsertar - 1; i--)
                            {
                                ciudades[i] = ciudades[i - 1];
                            }
                            do
                            {
                                Console.Write("Nombre de la ciudad: ");
                                ciudades[numRegistroInsertar - 1].nombre =
                                    Console.ReadLine();
                                if (ciudades[numRegistroInsertar - 1].nombre == "")
                                {
                                    Console.WriteLine(
                                        "Debe introducir un nombre.");
                                }
                            }
                            while (ciudades[numRegistroInsertar - 1].nombre == "");

                            do
                            {
                                Console.Write("País: ");
                                ciudades[numRegistroInsertar - 1].pais =
                                    Console.ReadLine();
                                if (ciudades[numRegistroInsertar - 1].pais == "")
                                {
                                    Console.WriteLine(
                                        "Debe introducir un país.");
                                }
                            }
                            while (ciudades[numRegistroInsertar - 1].pais == "");

                            Console.Write("Población: ");
                            string poblacionTemp = Console.ReadLine();
                            if (poblacionTemp == "")
                            {
                                ciudades[numRegistroInsertar - 1].poblacion = 0;
                            }
                            else
                            {
                                ciudades[numRegistroInsertar - 1].poblacion =
                                    Convert.ToInt32(poblacionTemp);
                            }
                            numDatos++;
                        }
                    }
                    break;

                case ELIMINAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos");
                    }
                    else
                    {
                        Console.Write("Número de registro a borrar: ");
                        int numRegistroBorrar = Convert.ToUInt16(Console.ReadLine());
                        if (numRegistroBorrar > numDatos)
                        {
                            Console.WriteLine("Número de registro no válido");
                        }
                        else
                        {
                            Console.WriteLine("{0}-{1}, {2}. ", numRegistroBorrar,
                                    ciudades[numRegistroBorrar - 1].nombre, 
                                    ciudades[numRegistroBorrar - 1].pais);
                            Console.WriteLine("Confirme que desea borrar (s/n)");
                            string opcionBorrado = Console.ReadLine();
                            if (opcionBorrado.ToUpper() == "S")
                            {
                                for (int i = numRegistroBorrar - 1; i < numDatos - 1; i++)
                                {
                                    ciudades[i] = ciudades[i + 1];
                                }
                                numDatos--;

                                if (numDatos == 0)
                                    Console.WriteLine("Se ha borrado el último dato");
                            }
                        }
                    }
                    break;

                case ORDENAR:
                    Console.WriteLine("1. Ordenar por nombre de la ciudad.");
                    Console.WriteLine("2. Ordenar por nombre del país.");
                    Console.WriteLine();
                    Console.Write("Elige una opción: ");
                    char opcionOrdenacion = Convert.ToChar(Console.ReadLine());
                    if (opcionOrdenacion == '1')
                    {
                        for (int i = 0; i < numDatos - 1; i++)
                        {
                            for (int j = i + 1; j < numDatos; j++)
                            {
                                if (ciudades[i].nombre.ToUpper().CompareTo(
                                    ciudades[j].nombre.ToUpper()) > 0)
                                {
                                    TipoCiudad datosTemp = ciudades[i];
                                    ciudades[i] = ciudades[j];
                                    ciudades[j] = datosTemp;
                                }
                            }
                        }
                    }
                    else if (opcionOrdenacion == '2')
                    {
                        for (int i = 0; i < numDatos - 1; i++)
                        {
                            for (int j = i + 1; j < numDatos; j++)
                            {
                                if (ciudades[i].pais.ToUpper().CompareTo(
                                    ciudades[j].pais.ToUpper()) > 0)
                                {
                                    TipoCiudad datosTemp = ciudades[i];
                                    ciudades[i] = ciudades[j];
                                    ciudades[j] = datosTemp;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;

                case ENCONTRAR_ERRORES:
                    for (int i = 0; i < numDatos; i++)
                    {
                        bool problemasEncontrados = false;
                        // Dos símbolos de puntuación seguidos
                        if (ciudades[i].nombre.Contains("..")
                            || ciudades[i].nombre.Contains(",,")
                            || ciudades[i].nombre.Contains("..")
                            || ciudades[i].nombre.Contains(",,"))
                        problemasEncontrados = true;

                        // Tres letras consecutivas
                        for (int letra = 0; letra < ciudades[i].nombre.Length-2; letra++)
                        {
                            if ((ciudades[i].nombre[letra] 
                                        == ciudades[i].nombre[letra+1])
                                    && (ciudades[i].nombre[letra] 
                                        == ciudades[i].nombre[letra + 2]))
                                problemasEncontrados = true;
                        }

                        // En  cualquiera de ambos casos, muestro
                        if (problemasEncontrados)
                        {
                            Console.WriteLine("{0}-{1}, {2}. ", i + 1,
                                ciudades[i].nombre, ciudades[i].pais);
                        }
                    }
                    break;

                case SALIR:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            Console.WriteLine();
        }
        while (salir == false);
    }
}
