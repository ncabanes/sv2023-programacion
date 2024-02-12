
/*169. Crea un gestor básico de tareas, usando una clase "Tarea"
(descripción -texto-, prioridad -1 a 5-, completada -verdadero o
falso-). Esa clase "tarea" implementará la interfaz IComparable, lo que
te obligará a crear un método "CompareTo", que permita comparar dos
tareas, para poder utilizar "Array.Sort" en vez de algoritmos lentos
como la "burbuja". En esta primera versión, el criterio de comparación
será la descripción, de modo que las tareas se muestren ordenadas de la
A a la Z. El programa principal mostrará un menú al usuario, mediante
el cual pueda:

1 - Añadir una nueva tarea.

2 - Ver todas las tareas pendientes.

3 - Marcar una tarea como completada, a partir de su posición en el
array (1 para la primera, 2 para la segunda, etc).

4 - Modificar una tarea (también a partir de su posición).

5 - Buscar entre todas las tareas que contengan un cierto texto (estén
completadas o no).

6 - Ordenar las tareas alfabéticamente  (nota: como el array estará
sobredimensionado, deberás usar la variante de Array.Sort que recibe
como parámetros una posición inicial y una cantidad de datos a ordenar:
"Array.Sort(tareas, 0, cantidad);" ).

0 - Salir.
*/

// Iván (...), retoques por Nacho

using System;

class Tarea : IComparable<Tarea>
{
    protected string descripcion;
    protected byte prioridad;
    protected bool completada;

    public string GetDescripcion() {  return descripcion; }
    public byte GetPrioridad() {  return prioridad; }
    public bool GetCompletada() {  return completada; }
    public void SetDescripcion(string value) {  descripcion = value; }
    public void SetPrioridad(byte value) { prioridad = value; }
    public void SetCompletada(bool value) { completada = value; }

    public Tarea() { }
    public Tarea(string descripcion, byte prioridad, bool completada)
    {
        this.descripcion = descripcion;
        this.completada = completada;
        this.prioridad = prioridad;
    }

    public override string ToString()
    {
        return descripcion + " (" +
            prioridad + ") " +
            (completada ? "Completada" : "Pendiente");
    }
    public int CompareTo(Tarea otra)
    {
        return descripcion.CompareTo(otra.descripcion);
    }
}

// --------------------------

class GestorDeTareas
{
    const int CAPACIDAD = 1000;
    
    static void Main()
    {
        byte opcion;
        int contador = 0;

        Tarea[] tareas = new Tarea[CAPACIDAD];

        do
        {
            MostrarMenu();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    AnadirTarea(tareas, ref contador);
                    break;
                case 2:
                    VerPendientes(tareas, contador);
                    break;
                case 3:
                    CompletarTarea(tareas);
                    break;
                case 4:
                    ModificarTarea(tareas);
                    break;
                case 5:
                    BuscarTarea(tareas, contador);
                    break;
                case 6:
                    Ordenar(tareas, contador);
                    break;
                /*case 7:
                    Mostrar(tareas, contador);
                    break;
                */
                case 0:
                    Console.WriteLine("Hasta otra!");
                    break;
                default: Console.WriteLine("Error: " +
                    "Opción incorrecta, vuelva a intentarlo.");
                    break;
            }

        } while (opcion != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Añadir nueva tarea");
        Console.WriteLine("2. Ver tareas pendientes");
        Console.WriteLine("3. Marcar tarea como completada");
        Console.WriteLine("4. Modificar una tarea");
        Console.WriteLine("5. Buscar tarea");
        Console.WriteLine("6. Ordenar tareas");
        //Console.WriteLine("7. Mostrar todos los datos");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
    }

    static string Pedir(string texto)
    {
        Console.Write(texto);
        return Console.ReadLine();
    }

    static void AnadirTarea(Tarea[] tareas, ref int contador)
    {
        if (contador < CAPACIDAD)
        {
            tareas[contador] = new Tarea();

            tareas[contador].SetDescripcion(Pedir("Dime la descripción: "));
            tareas[contador].SetPrioridad(Convert.ToByte(
                Pedir("Dime la prioridad: ")));
            //PedirCompletada(tareas, contador);

            contador++;
        }
        else
            Console.WriteLine("No caben más tareas");
    }

    static void VerPendientes(Tarea[] tareas, int contador)
    {
        bool algunaEncontrada = false;
        for (int i = 0; i < contador; i++)
        {
            if (! tareas[i].GetCompletada())
            {
                Console.Write(i + 1);
                Console.WriteLine(": " + tareas[i]);
                algunaEncontrada = true;
            }
        }
        if (! algunaEncontrada)
            Console.WriteLine("No hay tareas pendientes.");
    }
    
    static void CompletarTarea(Tarea[] tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el índice de la tarea" +
            " que quieres completar: ")) - 1;
        if (tareas[indice].GetCompletada() == false)
        {
            tareas[indice].SetCompletada(true);

            Console.WriteLine("La tarea {0} se ha completado correctamente.",
                indice + 1);
        }
        else
            Console.WriteLine("Esta tarea ya está completada.");
    }

    static void ModificarTarea(Tarea[] tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el índice de la tarea" +
           " que quieres modificar: ")) - 1;

        tareas[indice].SetDescripcion(
            Pedir("Nueva descripción (era: "+
            tareas[indice].GetDescripcion() +"): "));
            
        tareas[indice].SetPrioridad(Convert.ToByte(
            Pedir("Nueva prioridad: (era: "+
            tareas[indice].GetPrioridad() +"): ")));
            
        PedirCompletada(tareas, indice);
    }

    static void BuscarTarea(Tarea[] tareas, int contador)
    {
        string texto = Pedir("Dime el texto que deseas buscar: ");

        for (int i = 0; i < contador; i++)
        {
            if (tareas[i].GetDescripcion().ToLower()
                .Contains(texto.ToLower()))
            {
                Console.WriteLine("-Dato {0}:", i + 1);
                Console.WriteLine(tareas[i]);
                Console.WriteLine();
            }
        }
    }

    static void Ordenar(Tarea[] tareas, int contador)
    {
        Array.Sort(tareas, 0, contador);

        Console.WriteLine("Tareas ordenadas correctamente.");
    }

    static void PedirCompletada(Tarea[] tareas, int indice)
    {
        string completada = Pedir("La tarea está completada (1 = Sí, 2 = No)? ");

        if (completada == "1")
            tareas[indice].SetCompletada(true);
        else
            tareas[indice].SetCompletada(false);
    }

    /*static void Mostrar(Tarea[] tareas, int contador)
    {
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("-Dato {0}:", i+1);
            Console.WriteLine(tareas[i]);
            Console.WriteLine();
        }
    }
    */
}

