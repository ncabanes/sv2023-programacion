/*235. Crea una nueva versión del ejercicio 209 (tareas + lista), partiendo de 
la versión oficial, en la que uses serialización JSON para cargar datos al 
comienzo de la sesión y guardar los datos tras cada modificación.

Javier (...)*/

// (Nota: no funcionará desde Geany (C# 5), sí desde VS 2022

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

[Serializable]
class Tarea : IComparable<Tarea>
{
    public Tarea() { }
    public Tarea(string descripcion, byte prioridad, bool completada)
    {
        this.descripcion = descripcion;
        this.completada = completada;
        this.prioridad = prioridad;
    }

    public string descripcion { get; set; }
    public byte prioridad { get; set; }
    public bool completada { get; set; }

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

        List<Tarea> tareas = Cargar();

        do
        {
            MostrarMenu();
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    AnadirTarea(tareas);
                    Guardar(tareas);
                    break;
                case 2:
                    VerPendientes(tareas);
                    break;
                case 3:
                    CompletarTarea(tareas);
                    Guardar(tareas);
                    break;
                case 4:
                    ModificarTarea(tareas);
                    Guardar(tareas);
                    break;
                case 5:
                    BuscarTarea(tareas);
                    break;
                case 6:
                    Ordenar(tareas);
                    Guardar(tareas);
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

    static void AnadirTarea(List<Tarea> tareas)
    {
        string descripcion = Pedir("Dime la descripción: ");
        byte prioridad = Convert.ToByte(Pedir("Dime la prioridad: "));
        tareas.Add(new Tarea(descripcion, prioridad, false));
    }

    static void VerPendientes(List<Tarea> tareas)
    {
        bool algunaEncontrada = false;
        for (int i = 0; i < tareas.Count; i++)
        {
            if (!tareas[i].completada)
            {
                Console.Write(i + 1);
                Console.WriteLine(": " + tareas[i]);
                algunaEncontrada = true;
            }
        }
        if (!algunaEncontrada)
            Console.WriteLine("No hay tareas pendientes.");
    }

    static void CompletarTarea(List<Tarea> tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el índice de la tarea" +
            " que quieres completar: ")) - 1;
        if (tareas[indice].completada == false)
        {
            tareas[indice].completada = true;

            Console.WriteLine("La tarea {0} se ha completado correctamente.",
                indice + 1);
        }
        else
            Console.WriteLine("Esta tarea ya está completada.");
    }

    static void ModificarTarea(List<Tarea> tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el índice de la tarea" +
           " que quieres modificar: ")) - 1;

        tareas[indice].descripcion =
            Pedir("Nueva descripción (era: " +
            tareas[indice].descripcion + "): ");

        tareas[indice].prioridad = Convert.ToByte(
            Pedir("Nueva prioridad: (era: " +
            tareas[indice].prioridad + "): "));

        PedirCompletada(tareas, indice);
    }

    static void BuscarTarea(List<Tarea> tareas)
    {
        string texto = Pedir("Dime el texto que deseas buscar: ");

        for (int i = 0; i < tareas.Count; i++)
        {
            if (tareas[i].descripcion.ToLower()
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
        string completada = Pedir("La tarea está completada (1 = Sí, 2 = No)? ");

        if (completada == "1")
            tareas[indice].completada = true;
        else
            tareas[indice].completada = false;
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

    public static void Guardar(List<Tarea> tareas)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(tareas);
            File.WriteAllText("tareas.json", jsonString);
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Ruta demasiado larga");
        }
        catch (IOException e)
        {
            Console.WriteLine("No se ha podido escribir: "
                + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error general: " + e.Message);
        }
        
    }

    public static List<Tarea> Cargar()
    {
        List<Tarea> tareas = new List<Tarea>();

        if (!File.Exists("tareas.json"))
        {
            
            return tareas;
        }
        try
        {
            string jsonString = File.ReadAllText("tareas.json");
            tareas = JsonSerializer.Deserialize<List<Tarea>>(jsonString);
            return tareas;

        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Ruta demasiado larga");
        }
        catch (IOException e)
        {
            Console.WriteLine("No se ha podido leer: "
                + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error general: " + e.Message);
        }
        return tareas;
    }

}

