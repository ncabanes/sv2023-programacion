/* 123. Crea una nueva versión del ejercicio 94 (Ciudades), partiendo de la
 * "versión oficial", en la que cada opción del menú principal se haya extraído
 * a una función. Por lo general, cada una de estas funciones deberá recibir
 * como parámetros el array con los datos y el contador de cuántos datos hay
 * almacenados (quizá como parámetro "ref"), de modo que no existan variables
 * locales, sino variables locales y datos pasados como parámetros.
 *
 * VICTOR (...) */

using System;

class ejercicio_123
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
                case "1": Anyadir(CAPACIDAD, ref numDatos, ref ciudades); break;
                case "2": Mostrar(numDatos, ciudades); break;
                case "3": Buscar(numDatos, ciudades); break;
                case "4": Modificar(ref numDatos, ref ciudades); break;
                case "5": Insertar(CAPACIDAD, ref numDatos, ref ciudades); break;
                case "6": Eliminar(ref numDatos, ref ciudades); break;
                case "7": Ordenar(ref ciudades, numDatos); break;
                case "8": EncontrarErrores(numDatos, ciudades); break;
                case "S": salir = true; break;
                default: Console.WriteLine("Opción no válida"); break;
            }
            Console.WriteLine();
        }
        while (salir == false);
    }

    static void Anyadir(ushort CAPACIDAD, ref ushort numDatos, ref TipoCiudad[] ciudades)
    {
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
    }

    static void Mostrar(ushort numDatos, TipoCiudad[] ciudades)
    {
        if (numDatos == 0)
        {
            Console.WriteLine("No hay datos");
        }
        else
        {
            bool visualizacionTerminada = false;
            int i = 0;
            while (i < numDatos && !visualizacionTerminada)
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
    }

    static void Buscar(ushort numDatos, TipoCiudad[] ciudades)
    {
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
    }

    static void Modificar(ref ushort numDatos, ref TipoCiudad[] ciudades)
    {
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
    }

    static void Insertar(ushort CAPACIDAD, ref ushort numDatos, ref TipoCiudad[] ciudades)
    {
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
    }

    static void Eliminar(ref ushort numDatos, ref TipoCiudad[] ciudades)
    {
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
    }

    static void Ordenar(ref TipoCiudad[] ciudades, ushort numDatos)
    {
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
    }

    static void EncontrarErrores(ushort numDatos, TipoCiudad[] ciudades)
    {
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
            for (int letra = 0; letra < ciudades[i].nombre.Length - 2; letra++)
            {
                if ((ciudades[i].nombre[letra]
                            == ciudades[i].nombre[letra + 1])
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
    }
}
