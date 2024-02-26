/*191. Crea una variante del anterior (190), en la que conviertas los "struct" 
en clases, con propiedades en formato corto.*/

// Miguel Ángel (...)

using System;
using System.Collections.Generic;

// --------------------

class Ciudad
{
    public string Nombre {  get; set; }
    public string Pais {  get; set; }
    public int Poblacion {  get; set; }

    public Ciudad(string nombre, string pais, int poblacion)
    {
        Nombre = nombre;
        Pais = pais;
        Poblacion = poblacion;
    }
}

// --------------------

class PruebaCiudad
{
    static void Main()
    {
        const string ANYADIR = "1", MOSTRAR = "2", BUSCAR = "3", MODIFICAR = "4",
            INSERTAR = "5", ELIMINAR = "6", ORDENAR = "7", ENCONTRAR_ERRORES = "8",
            SALIR = "S";
        List<Ciudad> ciudades = new List<Ciudad>();
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

    static void Anyadir(List<Ciudad> ciudades)
    {
        string nombre;
        do
        {
            Console.Write("Nombre de la ciudad: ");
            nombre = Console.ReadLine();
            if (nombre == "")
            {
                Console.WriteLine("Debe introducir un nombre.");
            }
        }
        while (nombre == "");

        string pais;
        do
        {
            Console.Write("País: ");
            pais = Console.ReadLine();
            if (pais == "")
            {
                Console.WriteLine("Debe introducir un país.");
            }
        }
        while (pais == "");

        Console.Write("Población: ");
        string poblacionTemp = Console.ReadLine();
        int poblacion;
        if (poblacionTemp == "")
        {
            poblacion = 0;
        }
        else
        {
            poblacion = Convert.ToInt32(poblacionTemp);
        }
        ciudades.Add(new Ciudad(nombre,pais, poblacion));
    }

    static void Mostrar(List<Ciudad> ciudades)
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
                string ciudadMostrar = ciudades[i].Nombre;
                if (ciudadMostrar.Length > 20)
                    ciudadMostrar = ciudadMostrar.Substring(0, 20) + "...";
                string paisMostrar = ciudades[i].Pais;
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

    static void Buscar(List<Ciudad> ciudades)
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
                if ((ciudades[i].Nombre.ToUpper().Contains(textoBuscar.
                    ToUpper())) || (ciudades[i].Pais.ToUpper().Contains(
                        textoBuscar.ToUpper())))
                {
                    Console.Write("{0}-{1}, {2}. ", i + 1,
                        ciudades[i].Nombre, ciudades[i].Pais);
                    if (ciudades[i].Poblacion == 0)
                    {
                        Console.WriteLine("Población desconocida.");
                    }
                    else
                    {
                        Console.WriteLine("Población: ", ciudades[i].Poblacion);
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

    static void Modificar(List<Ciudad> ciudades)
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
                Console.WriteLine("Nombre anterior: " +
                    ciudades[numRegistroModif - 1].Nombre);
                Console.Write("Nombre nuevo: ");
                string textoTemp = Console.ReadLine();
                if (textoTemp != "")
                {
                    while (textoTemp.Contains("  "))
                    {
                        textoTemp = textoTemp.Replace(" ", "  ");
                    }
                    ciudades[numRegistroModif - 1].Nombre = textoTemp.Trim();
                }

                Console.WriteLine("País anterior: " + 
                    ciudades[numRegistroModif - 1].Pais);
                Console.Write("País nuevo: ");
                textoTemp = Console.ReadLine();
                if (textoTemp != "")
                {
                    while (textoTemp.Contains("  "))
                    {
                        textoTemp = textoTemp.Replace(" ", "  ");
                    }
                    ciudades[numRegistroModif - 1].Pais = textoTemp.Trim();
                }

                Console.WriteLine("Población anterior: " +
                    ciudades[numRegistroModif - 1].Poblacion);
                Console.Write("Población nueva: ");
                textoTemp = Console.ReadLine();
                if (textoTemp != "")
                {
                    ciudades[numRegistroModif - 1].Poblacion = Convert.ToInt32(textoTemp);
                }
            }
        }
    }

    static void Insertar(List<Ciudad> ciudades)
    {
        Console.Write("Introduce la posición a insertar: ");
        int numRegistroInsertar = Convert.ToInt32(Console.ReadLine());
        if (numRegistroInsertar > ciudades.Count)
        {
            Console.WriteLine("Posición no válida.");
        }
        else
        {
            string nombre;
            do
            {
                Console.Write("Nombre de la ciudad: ");
                nombre = Console.ReadLine();
                if (nombre == "")
                {
                    Console.WriteLine("Debe introducir un nombre.");
                }
            }
            while (nombre == "");

            string pais;
            do
            {
                Console.Write("País: ");
                pais = Console.ReadLine();
                if (pais == "")
                {
                    Console.WriteLine("Debe introducir un país.");
                }
            }
            while (pais == "");

            Console.Write("Población: ");
            string poblacionTemp = Console.ReadLine();
            int poblacion;
            if (poblacionTemp == "")
            {
                poblacion = 0;
            }
            else
            {
                poblacion = Convert.ToInt32(poblacionTemp);
            }
            ciudades.Insert(numRegistroInsertar - 1, 
                new Ciudad(nombre, pais, poblacion));
        }
    }

    static void Eliminar(List<Ciudad> ciudades)
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
                        ciudades[numRegistroBorrar - 1].Nombre,
                        ciudades[numRegistroBorrar - 1].Pais);
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

    static void Ordenar(List<Ciudad> ciudades)
    {
        Console.WriteLine("1. Ordenar por nombre de la ciudad.");
        Console.WriteLine("2. Ordenar por nombre del país.");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
        char opcionOrdenacion = Convert.ToChar(Console.ReadLine());
        if (opcionOrdenacion == '1')
        {
            ciudades.Sort((c1, c2) => c1.Nombre.CompareTo(c2.Nombre));
        }
        else if (opcionOrdenacion == '2')
        {
            ciudades.Sort((c1, c2) => c1.Pais.CompareTo(c2.Pais));
        }
        else
        {
            Console.WriteLine("Opción no válida");
        }
    }

    static void EncontrarErrores(List<Ciudad> ciudades)
    {
        for (int i = 0; i < ciudades.Count; i++)
        {
            bool problemasEncontrados = false;
            // Dos símbolos de puntuación seguidos
            if (ciudades[i].Nombre.Contains("..")
                || ciudades[i].Nombre.Contains(",,")
                || ciudades[i].Nombre.Contains("..")
                || ciudades[i].Nombre.Contains(",,"))
                problemasEncontrados = true;

            // Tres letras consecutivas
            for (int letra = 0; letra < ciudades[i].Nombre.Length - 2; letra++)
            {
                if ((ciudades[i].Nombre[letra]
                            == ciudades[i].Nombre[letra + 1])
                        && (ciudades[i].Nombre[letra]
                            == ciudades[i].Nombre[letra + 2]))
                    problemasEncontrados = true;
            }

            // En  cualquiera de ambos casos, muestro
            if (problemasEncontrados)
            {
                Console.WriteLine("{0}-{1}, {2}. ", i + 1,
                    ciudades[i].Nombre, ciudades[i].Pais);
            }
        }
    }
}
