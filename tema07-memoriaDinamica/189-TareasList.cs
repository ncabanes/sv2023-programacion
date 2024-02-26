/*
 189. Crea una nueva versi�n del ejercicio 169 (Tareas),
partiendo de la versi�n oficial, empleando una lista en vez de un array para guardar los datos.
julio
 */


/*169. Crea un gestor b�sico de tareas, usando una clase "Tarea"
(descripci�n -texto-, prioridad -1 a 5-, completada -verdadero o
falso-). Esa clase "tarea" implementar� la interfaz IComparable, lo que
te obligar� a crear un m�todo "CompareTo", que permita comparar dos
tareas, para poder utilizar "Array.Sort" en vez de algoritmos lentos
como la "burbuja". En esta primera versi�n, el criterio de comparaci�n
ser� la descripci�n, de modo que las tareas se muestren ordenadas de la
A a la Z. El programa principal mostrar� un men� al usuario, mediante
el cual pueda:

1 - A�adir una nueva tarea.

2 - Ver todas las tareas pendientes.

3 - Marcar una tarea como completada, a partir de su posici�n en el
array (1 para la primera, 2 para la segunda, etc).

4 - Modificar una tarea (tambi�n a partir de su posici�n).

5 - Buscar entre todas las tareas que contengan un cierto texto (est�n
completadas o no).

6 - Ordenar las tareas alfab�ticamente  (nota: como el array estar�
sobredimensionado, deber�s usar la variante de Array.Sort que recibe
como par�metros una posici�n inicial y una cantidad de datos a ordenar:
"Array.Sort(tareas, 0, cantidad);" ).

0 - Salir.
*/

// Iv�n + Julio, retoques por Nacho

using System;
using System.Collections.Generic;

class Tarea : IComparable<Tarea>
{
    protected string descripcion;
    protected byte prioridad;
    protected bool completada;

    public string GetDescripcion() { return descripcion; }
    public byte GetPrioridad() { return prioridad; }
    public bool GetCompletada() { return completada; }
    public void SetDescripcion(string value) { descripcion = value; }
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
    static void Main()
    {
        byte opcion;

        List<Tarea> tareas = new List<Tarea>();

        do
        {
            MostrarMenu();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    AnadirTarea(tareas);
                    break;
                case 2:
                    VerPendientes(tareas);
                    break;
                case 3:
                    CompletarTarea(tareas);
                    break;
                case 4:
                    ModificarTarea(tareas);
                    break;
                case 5:
                    BuscarTarea(tareas);
                    break;
                case 6:
                    Ordenar(tareas);
                    break;
                /*case 7:
                    Mostrar(tareas);
                    break;
                */
                case 0:
                    Console.WriteLine("Hasta otra!");
                    break;
                default:
                    Console.WriteLine("Error: " +
                    "Opci�n incorrecta, vuelva a intentarlo.");
                    break;
            }

        } while (opcion != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. A�adir nueva tarea");
        Console.WriteLine("2. Ver tareas pendientes");
        Console.WriteLine("3. Marcar tarea como completada");
        Console.WriteLine("4. Modificar una tarea");
        Console.WriteLine("5. Buscar tarea");
        Console.WriteLine("6. Ordenar tareas");
        //Console.WriteLine("7. Mostrar todos los datos");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Elige una opci�n: ");
    }

    static string Pedir(string texto)
    {
        Console.Write(texto);
        return Console.ReadLine();
    }

    static void AnadirTarea(List<Tarea> tareas)
    {
        string descripcion = Pedir("Dime la descripci�n: ");
        byte prioridad = Convert.ToByte(Pedir("Dime la prioridad: "));
        tareas.Add(new Tarea(descripcion, prioridad, false));
    }

    static void VerPendientes(List<Tarea> tareas)
    {
        bool algunaEncontrada = false;
        for (int i = 0; i < tareas.Count; i++)
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

    static void CompletarTarea(List<Tarea> tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el �ndice de la tarea" +
            " que quieres completar: ")) - 1;
        if (tareas[indice].GetCompletada() == false)
        {
            tareas[indice].SetCompletada(true);

            Console.WriteLine("La tarea {0} se ha completado correctamente.",
                indice + 1);
        }
        else
            Console.WriteLine("Esta tarea ya est� completada.");
    }

    static void ModificarTarea(List<Tarea> tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el �ndice de la tarea" +
           " que quieres modificar: ")) - 1;

        tareas[indice].SetDescripcion(
            Pedir("Nueva descripci�n (era: " +
            tareas[indice].GetDescripcion() + "): "));

        tareas[indice].SetPrioridad(Convert.ToByte(
            Pedir("Nueva prioridad: (era: " +
            tareas[indice].GetPrioridad() + "): ")));

        PedirCompletada(tareas, indice);
    }

    static void BuscarTarea(List<Tarea> tareas)
    {
        string texto = Pedir("Dime el texto que deseas buscar: ");

        for (int i = 0; i < tareas.Count; i++)
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

    static void Ordenar(List<Tarea> tareas)
    {
        tareas.Sort();
        Console.WriteLine("Tareas ordenadas correctamente.");
    }

    static void PedirCompletada(List<Tarea> tareas, int indice)
    {
        string completada = Pedir("La tarea est� completada (1 = S�, 2 = No)? ");

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
