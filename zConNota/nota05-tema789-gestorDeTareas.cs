/*
Queremos realizar un gestor de tareas según los siguientes requisitos:

Existirá una clase Tarea, con propiedades Fecha (DateTime), Descripcion 
(texto), Prioridad (1 a 5), Completada (booleano).

Esta clase tendrá un método ToString, que devuelva sus datos en un 
formato como el siguiente: "12/05/2024: Entregar ejercicio con nota 
(5)" (fecha, dos puntos, espacio, descripción, prioridad entre 
paréntesis), y un método Mostrar, que escriba ese texto en color cian 
si la tarea está sin completar, o en gris oscuro si ya está completada.

También tendrá un método booleano "Contiene", que comprobará si en su 
descripción aparece un cierto texto (independientemente de mayúsculas y 
minúsculas).

Finalmente, también tendrá un método "CompareTo", que permita ordenar 
las tareas por fecha, por prioridad si coincide la fecha y finalmente 
por descripción si coinciden los dos criterios anteriores.


Existirá una clase ListaDeTareas, que internamente será una List<Tarea> 
y que tendrá como métodos públicos un "void Anadir(Tarea t)", un "Tarea 
Obtener(int posicion)", un void "Completar(int posicion)", un void 
"Eliminar(int posicion)", un "string[] ObtenerTareasIncompletas()" y un 
"string[] ObtenerTareasQueContienen( string texto )".

Tras Añadir un dato nuevo, se ordenarán los datos existentes y se 
guardarán a fichero de texto (usando StreamWriter, en el formato que tú 
decidas). También se guardará tras cualquier modificación (en nuestro 
caso, tras Completar y tras Eliminar).

El constructor de la clase ListaDeTareas cargará los datos anteriores 
(si existen), usando StreamReader.

Esta clase "no tocará la consola". Toda la interacción con el usuario 
(pedir datos, mostrar resultados) se debe realizar a través de la 
siguiente clase (GestorDeTareas).


La clase Principal se llamará GestorDeTareas, sólo utilizará los 
métodos públicos de la clase ListaDeTareas, y mostrará un menú que 
permita al usuario: añadir una nueva tarea, ver las tareas sin 
completar, buscar las tareas que contienen un cierto texto (estén 
completadas o no), marcar una tarea como completada, eliminar una 
tarea, salir. Ésta será la clase que contenga el "Main".
*/

// ---------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;

// ---------------------------------------------

class Tarea : IComparable<Tarea>
{
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public byte Prioridad { get; set; }
    public bool Completada { get; set; }

    public Tarea(DateTime fecha, string descripcion, byte prioridad)
    {
        Fecha = fecha;
        Descripcion = descripcion;
        Prioridad = prioridad;
        Completada = false;
    }

    public void Mostrar()
    {
        if (Completada)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        Console.WriteLine(this);
        Console.ResetColor();
    }
        
    public int CompareTo(Tarea otra)
    {
        if (Fecha != otra.Fecha)
        {
            return Fecha.CompareTo(otra.Fecha);
        }
        else if (Prioridad != otra.Prioridad)
        {
            return Prioridad.CompareTo(otra.Prioridad);
        }
        else
        {
            return Descripcion.ToUpper().CompareTo(
                otra.Descripcion.ToUpper());
        }
    }

    public bool Contiene(string texto)
    {
        if (Descripcion.ToUpper().Contains(texto.ToUpper()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return Fecha.ToString("d") + ": " + Descripcion + 
            " (" + Prioridad + ")";
    }
}


// ---------------------------------------------


class ListaDeTareas
{
    private List<Tarea> listaTareas;

    public int errorDeLectura;
    public int ErrorDeLectura { get { return errorDeLectura; } }
    public int errorDeEscritura;
    public int ErrorDeEscritura { get { return errorDeEscritura; } }

    public ListaDeTareas()
    {
        listaTareas = new List<Tarea>();
        Cargar();
    }

    public void Anadir(Tarea tarea)
    {
        listaTareas.Add(tarea);
        listaTareas.Sort();
        Guardar();
    }

    public Tarea Obtener(int posicion)
    {
        return listaTareas[posicion];
    }

    public void Completar(int posicion)
    {
        listaTareas[posicion].Completada = true;
        Guardar();
    }

    public void Eliminar(int posicion)
    {
        listaTareas.RemoveAt(posicion);
        Guardar();
    }

    public string[] ObtenerTareasIncompletas()
    {
        List<string> incompletas = new List<string>();
        for (int i = 0; i < listaTareas.Count; i++)
        {
            if (!listaTareas[i].Completada)
            {
                incompletas.Add((i+1) + ". " + listaTareas[i].ToString());
            }
        }
        return incompletas.ToArray();
    }

    public string[] ObtenerTareasQueContienen(string texto)
    {
        List<string> contienen = new List<string>();
        for (int i = 0; i < listaTareas.Count; i++)
        {
            if (listaTareas[i].Contiene(texto))
            {
                contienen.Add((i + 1) + ". " + listaTareas[i].ToString());
            }
        }
        return contienen.ToArray();
    }

    private void Cargar()
    {
        errorDeLectura = 0;
        if (File.Exists("Tareas.txt"))
        {
            try
            {
                string linea;
                StreamReader fichero = File.OpenText("Tareas.txt");
                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                    {
                        string[] datos = linea.Split('#');
                        string[] datosFecha = datos[0].Split('/');
                        DateTime fecha = new DateTime(
                            Convert.ToInt16(datosFecha[2]),
                            Convert.ToInt16(datosFecha[1]),
                            Convert.ToInt16(datosFecha[0]));
                        Tarea tarea = new Tarea(fecha, datos[1],
                            Convert.ToByte(datos[2]));
                        tarea.Completada = datos[3] == "True";
                        listaTareas.Add(tarea);
                    }
                }
                while (linea != null);
                fichero.Close();
            }
            catch (PathTooLongException)
            {
                errorDeLectura = 1;
            }
            catch (IOException)
            {
                errorDeLectura = 2;
            }
            catch (Exception)
            {
                errorDeLectura = 3;
            }
        }
    }

    private void Guardar()
    {
        errorDeEscritura = 0;
        try
        {
            StreamWriter fichero = File.CreateText("Tareas.txt");
            foreach (Tarea tarea in listaTareas)
            {
                fichero.Write(tarea.Fecha.ToString("d") + "#");
                fichero.Write(tarea.Descripcion + "#");
                fichero.Write(tarea.Prioridad + "#");
                fichero.WriteLine(tarea.Completada);
            }
            fichero.Close();
        }
        catch (PathTooLongException)
        {
            errorDeEscritura = 1;
        }
        catch (IOException)
        {
            errorDeEscritura = 2;
        }
        catch (Exception)
        {
            errorDeEscritura = 3;
        }
    }
}



// ---------------------------------------------

class GestorDeTareas
{
    private ListaDeTareas lista;

    private GestorDeTareas()
    {
        lista = new ListaDeTareas();
    }

    static void Main()
    {
        GestorDeTareas g = new GestorDeTareas();
        g.Ejecutar();
    }

    private void Ejecutar()
    {
        bool salir = false;
        do
        {
            string opcion = Menu();
            Console.WriteLine();
            
            switch (opcion)
            {
                case "1": Anyadir(); break;
                case "2": VerIncompletas(); break;
                case "3": Buscar(); break;
                case "4": MarcarCompletada(); break;
                case "5": Eliminar(); break;
                case "0": salir = true; break;
                default: Console.WriteLine("Opción incorrecta."); break;
            }
        }
        while (!salir);
    }

    private static string Menu()
    {
        Console.WriteLine();
        Console.WriteLine("--------------MENÚ--------------");
        Console.WriteLine("1. Añadir tarea.");
        Console.WriteLine("2. Ver tareas incompletas.");
        Console.WriteLine("3. Buscar tareas.");
        Console.WriteLine("4. Marcar tarea como completada.");
        Console.WriteLine("5. Eliminar una tarea.");
        Console.WriteLine("0. Salir.");
        Console.WriteLine();
        return Pedir("Elige una opción: ");
    }

    private void Anyadir()
    {
        Tarea tarea = new Tarea(PedirFecha(), Pedir("Descripción: "),
            Convert.ToByte(PedirNumero("Prioridad (1-5): ", 1, 5)));
        lista.Anadir(tarea);
        Console.WriteLine();
        Console.Write("Tarea añadida: ");
        tarea.Mostrar();
        if (lista.ErrorDeEscritura != 0)
        {
            Console.WriteLine("No se ha podido guardar los cambios.");
        }
    }

    private void VerIncompletas()
    {
        string[] incompletas = lista.ObtenerTareasIncompletas();
        if (incompletas.Length > 0)
        {
            Console.WriteLine("Tareas incompletas: ");
            for (int i = 0; i < incompletas.Length; i++)
            {
                Console.WriteLine(incompletas[i]);
            }
        }
        else
        {
            Console.WriteLine("No hay tareas incompletas.");
        }
    }

    private void Buscar()
    {
        string textoBusqueda = Pedir("Texto a buscar: ");
        string[] contienen = lista.ObtenerTareasQueContienen(textoBusqueda);
        if (contienen.Length > 0)
        {
            Console.WriteLine("Tareas que contienen el texto: ");
            for (int i = 0; i < contienen.Length; i++)
            {
                Console.WriteLine(contienen[i]);
            }
        }
        else
        {
            Console.WriteLine("No se han encontrado coincidencias.");
        }
    }

    private void MarcarCompletada()
    {
        int posicion = PedirPosicionTarea("marcar como completada");
        if ( posicion >= 0)
        {
            lista.Completar(posicion);
            Console.WriteLine("Tarea marcada como completada.");
            if (lista.ErrorDeEscritura != 0)
            {
                Console.WriteLine("No se ha podido guardar los cambios.");
            }
        }
    }

    private void Eliminar()
    {
        int posicion = PedirPosicionTarea("eliminar");
        if (posicion >= 0)
        {
            lista.Eliminar(posicion);
            Console.WriteLine("Tarea eliminada.");
            if (lista.ErrorDeEscritura != 0)
            {
                Console.WriteLine("No se ha podido guardar los cambios.");
            }
        }
    }

    private int PedirPosicionTarea(string accion)
    {
        int posicion = -1;
        try
        {
            posicion = Convert.ToInt32(Pedir(
                "Posición de tarea a " + accion + ": ")) - 1;
            Tarea tarea = lista.Obtener(posicion);
            tarea.Mostrar();
            if (accion == "marcar como completada" && tarea.Completada)
            {
                Console.WriteLine("La tarea ya se encuentra completada.");
                posicion = -1;
            }
            else
            { 
                if (Pedir("¿Desea " + accion + " la tarea (s/n)? ").ToLower()
                    != "s")
                {
                    posicion = -1;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error, la posición debe ser un número" +
                "mayor que 0 e inferior al número de tareas almacenadas");
            posicion = -1;
        }
        return posicion;
    }

    private static string Pedir(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }

    private static short PedirNumero(string mensaje, short menor, short mayor)
    {
        bool correcto = false;
        short numero = 0;
        do
        {
            try
            {
                numero = Convert.ToInt16(Pedir(mensaje));
                if (numero >= menor && numero <= mayor)
                {
                    correcto = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Debe ser un número entre " + 
                    menor + " y " + mayor);
            }   
        }
        while (!correcto);
        return numero;
    }

    private static DateTime PedirFecha()
    {
        bool correcta = false;
        DateTime fecha = DateTime.Now;
        short anyo, mes = 0, dia = 0;
        Console.WriteLine("Fecha de la tarea.");
        short anyoActual = (short)DateTime.Now.Year;
        anyo = PedirNumero("Año: ", anyoActual, 3000);
        mes = PedirNumero("Mes: ", 1, 12);
        do 
        {
            try
            {
                dia = PedirNumero("Día: ", 1, 31);
                fecha = new DateTime(anyo, mes, dia);
                correcta = true;
            }
            catch (Exception)
            {
                Console.WriteLine("El mes {0} no tiene {1} días.",mes ,dia);
            }
        }
        while (! correcta);
        return fecha;
    }
}
