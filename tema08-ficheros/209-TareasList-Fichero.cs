/* 209. Crea una nueva versión del ejercicio 189 (Tareas + lista), 
partiendo de la versión oficial, en la que se carguen los datos 
anteriores (si existen) al comenzar cada ejecución y se guarden los 
datos tras cada modificación (al añadir, modificar, ordenar, etc). Crea 
una función "Cargar" y una función "Guardar", para evitar código 
repetitivo. Nuevamente, elige tú el formato que desees para los datos, 
aunque en este caso no necesitarás guardar un contador. */

using System;
using System.IO;
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

    static void ModificarTarea(List<Tarea> tareas)
    {
        int indice = Convert.ToInt32(Pedir("Dime el índice de la tarea" +
           " que quieres modificar: ")) - 1;

        tareas[indice].SetDescripcion(
            Pedir("Nueva descripción (era: " +
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
    
    static void Guardar(List<Tarea> tareas)
    {
        try
        {
            StreamWriter f = File.CreateText("tareas.dat");
            foreach (Tarea t in tareas)
            {
                f.WriteLine(t.GetDescripcion() + "#" +
                    t.GetPrioridad() + "#" +
                    (t.GetCompletada()?"S":"N"));
            }
            f.Close();
        }
        catch(PathTooLongException) 
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
        List<Tarea> lista = new List<Tarea>();
        try
        {
            
            string linea;
            if (File.Exists("tareas.dat"))
            {
                StreamReader f = File.OpenText("tareas.dat");
                do
                {
                    linea = f.ReadLine();
                    if (linea != null)
                    {
                        string[] trozos = linea.Split('#');
                        string descripcion = trozos[0];
                        byte prioridad = Convert.ToByte(trozos[1]);
                        bool completada = trozos[2] == "S";

                        Tarea t = new Tarea(descripcion,
                            prioridad, completada);

                        lista.Add(t);
                    }
                }
                while (linea != null);
                f.Close();
            }
            
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
        return lista;
    }

}
