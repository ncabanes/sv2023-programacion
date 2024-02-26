/*190. Crea una nueva versión del ejercicio 123 (struct TipoCiudad y funciones),
a partir de la "solución oficial", en la que no se utilice un array para los 
datos, sino una lista con tipo. Deberás aprovechar las ventajas que te supone 
esa estructura de datos, como por ejemplo el hecho de que tienes funciones 
incorporadas para insertar y borrar, o que podrás ordenar los datos empleando 
".Sort" y una "lambda" para indicar el criterio de ordenación.*/

// Miguel Ángel (...)

using System;
using System.Collections.Generic;

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
        List<TipoCiudad> ciudades = new List<TipoCiudad>();
        bool salir = false;
        string opcion;

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
                case "1": Anyadir(ciudades); break;
                case "2": Mostrar(ciudades); break;
                case "3": Buscar(ciudades); break;
                case "4": Modificar(ciudades); break;
                case "5": Insertar(ciudades); break;
                case "6": Eliminar(ciudades); break;
                case "7": Ordenar(ciudades); break;
                case "8": EncontrarErrores(ciudades); break;
                case "S": salir = true; break;
                default: Console.WriteLine("Opción no válida"); break;
            }
            Console.WriteLine();
        }
        while (salir == false);
    }

    static void Anyadir(List<TipoCiudad> ciudades)
    {
        TipoCiudad nuevaCiudad = new TipoCiudad();
        do
        {
            Console.Write("Nombre de la ciudad: ");
            nuevaCiudad.nombre = Console.ReadLine();
            if (nuevaCiudad.nombre == "")
            {
                Console.WriteLine("Debe introducir un nombre.");
            }
        }
        while (nuevaCiudad.nombre == "");

        do
        {
            Console.Write("País: ");
            nuevaCiudad.pais = Console.ReadLine();
            if (nuevaCiudad.pais == "")
            {
                Console.WriteLine("Debe introducir un país.");
            }
        }
        while (nuevaCiudad.pais == "");

        Console.Write("Población: ");
        string poblacionTemp = Console.ReadLine();
        if (poblacionTemp == "")
        {
            nuevaCiudad.poblacion = 0;
        }
        else
        {
            nuevaCiudad.poblacion = Convert.ToInt32(poblacionTemp);
        }
        ciudades.Add(nuevaCiudad);
    }

    static void Mostrar(List<TipoCiudad> ciudades)
    {
        if (ciudades.Count == 0)
        {
            Console.WriteLine("No hay datos");
        }
        else
        {
            bool visualizacionTerminada = false;
            int i = 0;
            while (i < ciudades.Count && !visualizacionTerminada)
            {
                string ciudadMostrar = ciudades[i].nombre;
                if (ciudadMostrar.Length > 20)
                    ciudadMostrar = ciudadMostrar.Substring(0, 20) + "...";
                string paisMostrar = ciudades[i].pais;
                if (ciudadMostrar.Length > 20)
                    ciudadMostrar = ciudadMostrar.Substring(0, 40).
                        Replace(" ", "");

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

    static void Buscar(List<TipoCiudad> ciudades)
    {
        if (ciudades.Count == 0)
        {
            Console.WriteLine("No hay datos");
        }
        else
        {
            int contadorPausaBuscar = 0;
            Console.Write("Texto a buscar: ");
            string textoBuscar = Console.ReadLine();
            for (int i = 0; i < ciudades.Count; i++)
            {
                if ((ciudades[i].nombre.ToUpper().Contains(textoBuscar.
                    ToUpper())) || (ciudades[i].pais.ToUpper().Contains(
                        textoBuscar.ToUpper())))
                {
                    Console.Write("{0}-{1}, {2}. ", i + 1,
                        ciudades[i].nombre, ciudades[i].pais);
                    if (ciudades[i].poblacion == 0)
                    {
                        Console.WriteLine("Población desconocida.");
                    }
                    else
                    {
                        Console.WriteLine("Población: ", ciudades[i].poblacion);
                    }
                    contadorPausaBuscar++;
                    if (contadorPausaBuscar % 24 == 0)
                    {
                        Console.WriteLine("Pulsa Intro para continuar");
                        Console.ReadLine();
                        contadorPausaBuscar = 0;
                    }
                }
            }
        }
    }

    static void Modificar(List<TipoCiudad> ciudades)
    {
        if (ciudades.Count == 0)
        {
            Console.WriteLine("No hay datos");
        }
        else
        {
            Console.Write(
                "Introduce el número de registro a modificar (0=salir) ");
            int numRegistroModif = Convert.ToUInt16(Console.ReadLine());
            while (numRegistroModif > ciudades.Count || numRegistroModif < 0)
            {
                Console.WriteLine("Número de registro no válido");
                numRegistroModif = Convert.ToInt32(Console.ReadLine());
            }
            if (numRegistroModif != 0)
            {
                TipoCiudad ciudadModificada = ciudades[numRegistroModif - 1];
                Console.WriteLine("Nombre anterior: " +
                    ciudadModificada.nombre);
                Console.Write("Nombre nuevo: ");
                string textoTemp = Console.ReadLine();
                if (textoTemp != "")
                {
                    while (textoTemp.Contains("  "))
                    {
                        textoTemp = textoTemp.Replace(" ", "  ");
                    }
                    ciudadModificada.nombre = textoTemp.Trim();
                }

                Console.WriteLine("País anterior: " + ciudadModificada.pais);
                Console.Write("País nuevo: ");
                textoTemp = Console.ReadLine();
                if (textoTemp != "")
                {
                    while (textoTemp.Contains("  "))
                    {
                        textoTemp = textoTemp.Replace(" ", "  ");
                    }
                    ciudadModificada.pais = textoTemp.Trim();
                }

                Console.WriteLine("Población anterior: " +
                    ciudadModificada.poblacion);
                Console.Write("Población nueva: ");
                textoTemp = Console.ReadLine();
                if (textoTemp != "")
                {
                    ciudadModificada.poblacion = Convert.ToInt32(textoTemp);
                }
                ciudades[numRegistroModif - 1] = ciudadModificada;
            }
        }
    }

    static void Insertar(List<TipoCiudad> ciudades)
    {
        Console.Write("Introduce la posición a insertar: ");
        int numRegistroInsertar = Convert.ToInt32(Console.ReadLine());
        if (numRegistroInsertar > ciudades.Count)
        {
            Console.WriteLine("Posición no válida.");
        }
        else
        {
            TipoCiudad ciudadInsertada = new TipoCiudad();
            do
            {
                Console.Write("Nombre de la ciudad: ");
                ciudadInsertada.nombre = Console.ReadLine();
                if (ciudadInsertada.nombre == "")
                {
                    Console.WriteLine("Debe introducir un nombre.");
                }
            }
            while (ciudadInsertada.nombre == "");

            do
            {
                Console.Write("País: ");
                ciudadInsertada.pais = Console.ReadLine();
                if (ciudadInsertada.pais == "")
                {
                    Console.WriteLine("Debe introducir un país.");
                }
            }
            while (ciudadInsertada.pais == "");

            Console.Write("Población: ");
            string poblacionTemp = Console.ReadLine();
            if (poblacionTemp == "")
            {
                ciudadInsertada.poblacion = 0;
            }
            else
            {
                ciudadInsertada.poblacion = Convert.ToInt32(poblacionTemp);
            }
            ciudades.Insert(numRegistroInsertar - 1, ciudadInsertada);
        }
    }

    static void Eliminar(List<TipoCiudad> ciudades)
    {
        if (ciudades.Count == 0)
        {
            Console.WriteLine("No hay datos");
        }
        else
        {
            Console.Write("Número de registro a borrar: ");
            int numRegistroBorrar = Convert.ToInt32(Console.ReadLine());
            if (numRegistroBorrar > ciudades.Count)
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
                    ciudades.RemoveAt(numRegistroBorrar - 1);

                    if (ciudades.Count == 0)
                        Console.WriteLine("Se ha borrado el último dato");
                }
            }
        }
    }

    static void Ordenar(List<TipoCiudad> ciudades)
    {
        Console.WriteLine("1. Ordenar por nombre de la ciudad.");
        Console.WriteLine("2. Ordenar por nombre del país.");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
        char opcionOrdenacion = Convert.ToChar(Console.ReadLine());
        if (opcionOrdenacion == '1')
        {
            ciudades.Sort((c1, c2) => c1.nombre.CompareTo(c2.nombre));
        }
        else if (opcionOrdenacion == '2')
        {
            ciudades.Sort((c1, c2) => c1.pais.CompareTo(c2.pais));
        }
        else
        {
            Console.WriteLine("Opción no válida");
        }
    }

    static void EncontrarErrores(List<TipoCiudad> ciudades)
    {
        for (int i = 0; i < ciudades.Count; i++)
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
