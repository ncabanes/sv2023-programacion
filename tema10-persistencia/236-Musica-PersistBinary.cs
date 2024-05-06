/* 236. Crea una aplicación que permita llevar el control de una colección de
 * música en formato MP3. De cada canción o similar (que será un objeto de la
 * clase "Musica") querremos anotar el título (por ejemplo, "The bell"), el
 * intérprete ("Mike Oldfield"), el nombre del fichero ("thebell.mp3"), la
 * ubicación ("MikeOldfield/tubularBells"), el tamaño del fichero (en MB, quizá
 * con decimales, como en "3,070"). Otros detalles que podrían ser interesantes,
 * como la categoría, el álbum al que pertenece o la valoración personal, hemos
 * decidido aplazarlos para una versión posterior 2.0.
 * 
 * Tu aplicación debe mostrar un menú que permita:
 * 
 * 1. Añadir una nueva canción (al final de los datos existentes).
 * 
 * 2. Mostrar las canciones que contengan un cierto texto en el título o en el
 * autor.
 * 
 * 3. Modificar los datos de una canción a partir de su posición (la canción
 * número 1 sería la primera de la lista).
 * 
 * 4. Eliminar la canción que se encuentra en cierta posición.
 * 
 * 5. Ordenar alfabéticamente por título.
 * 
 * 6. Ordenar alfabéticamente por autor.
 * 
 * 0. Salir
 * 
 * Tu aplicación debe cargar datos al comenzar y guardar datos tras cada cambio, 
 * empleando serialización con un formateador binario.
 * 
 * VICTOR (...) */

// (Nota: funcionará bien desde Geany (C#5 y .Net 4), puede no funcionar
// desde VS 2022 según la plataforma de destino).

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class musica
{
    public string titulo;
    public string autor;
    public string nombreFichero;
    public string ruta;
    public float tamanyo;

    public musica(string titulo, string autor, string nombreFichero,
        string ruta, float tamanyo)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.nombreFichero = nombreFichero;
        this.ruta = ruta;
        this.tamanyo = tamanyo;
    }

    public string getTitulo() { return titulo; }
    public string getAutor() { return autor; }
    public string getNombreFichero() { return nombreFichero; }
    public string getRuta() { return ruta; }
    public float getTamanyo() { return tamanyo; }

    public void setTitulo(string titulo) { this.titulo = titulo; }
    public void setAutor(string autor) { this.autor = autor; }
    public void setNombreFichero(string nombreFichero)
    {
        this.nombreFichero = nombreFichero;
    }
    public void setRuta(string ruta) { this.ruta = ruta; }
    public void setTamanyo(float tamanyo) { this.tamanyo = tamanyo; }

    override public string ToString()
    {
        return "TÍTULO: " + titulo + " - AUTOR: " + autor
            + " - NOMBRE FICHERO: " + nombreFichero + " - RUTA: " + ruta
            + " - TAMAÑO: " + tamanyo + " MB";
    }
}

// --------

class Program
{
    static void Main(string[] args)
    {
        List<musica> canciones = cargar();

        bool salir = false;
        do
        {
            Console.WriteLine("   ---   MENU   ---   ");
            Console.WriteLine();
            Console.WriteLine("1 - Añadir nueva canción");
            Console.WriteLine("2 - Buscar canciones (por titulo o autor)");
            Console.WriteLine("3 - Modificar canción");
            Console.WriteLine("4 - Eliminar canción");
            Console.WriteLine("5 - Ordenar por título");
            Console.WriteLine("6 - Ordenar por autor");
            Console.WriteLine("0 - Salir");
            Console.WriteLine();
            Console.Write("Introduzca opción: ");
            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    anyadir(canciones);
                    break;

                case "2":
                    buscarTituloAutor(canciones);
                    break;

                case "3":
                    modificar(canciones);
                    break;

                case "4":
                    eliminar(canciones);
                    break;

                case "5":
                    ordenarTitulo(canciones);
                    break;

                case "6":
                    ordenarAutor(canciones);
                    break;

                case "0":
                    Console.WriteLine("¡Hasta luego!");
                    Console.WriteLine();
                    salir = true;
                    break;

                default:
                    Console.WriteLine("ERROR: opción incorrecta");
                    Console.WriteLine();
                    break;
            }
        }
        while (!salir);
    }

    public static string pedirString(string texto)
    {
        Console.Write(texto);
        return Console.ReadLine().ToUpper();
    }

    public static int pedirInt(string texto)
    {
        Console.Write(texto);
        string datoStr = Console.ReadLine();
        int datoInt = 0;
        if (datoStr != "")
        {
            try
            {
                datoInt = Convert.ToInt32(datoStr);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: solo se permiten números");
                Console.WriteLine();
            }
        }
        return datoInt;
    }

    public static float pedirFloat(string texto)
    {
        Console.Write(texto);
        string datoStr = Console.ReadLine();
        float datoFloat = 0;
        if (datoStr != "")
        {
            try
            {
                datoFloat = Convert.ToSingle(datoStr);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: solo se permiten números");
                Console.WriteLine();
            }
        }
        return datoFloat;
    }

    public static void anyadir(List<musica> canciones)
    {
        string titulo = pedirString("Título: ");
        string autor = pedirString("Autor: ");
        string nombreFichero = pedirString("Nombre fichero: ");
        string ruta = pedirString("Ruta fichero: ");
        float tamanyo = pedirFloat("Tamaño(MB): ");

        if (titulo != "" && autor != "" && nombreFichero != ""
            && ruta != "" && tamanyo > 0)
        {
            canciones.Add(new musica(
                titulo, autor, nombreFichero, ruta, tamanyo));
            Console.WriteLine();
            Console.WriteLine("Canción añadida correctamente");
            Console.WriteLine();
            guardar(canciones);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("ERROR: todos los campos son obligatorios");
            Console.WriteLine();
        }
    }

    public static void buscarTituloAutor(List<musica> canciones)
    {
        bool encontrado = false;

        if (canciones.Count == 0)
        {
            Console.WriteLine("ERROR: la lista está vacía");
        }
        else
        {
            string buscar = pedirString("Introduzca título o autor: ");
            Console.WriteLine();
            foreach (musica cancion in canciones)
            {
                if (cancion.getTitulo().Contains(buscar)
                    || cancion.getAutor().Contains(buscar))
                {
                    Console.WriteLine(cancion);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("No se han encontrado coincidencias");
            }
        }
        Console.WriteLine();
    }

    public static void modificar(List<musica> canciones)
    {
        if (canciones.Count == 0)
        {
            Console.WriteLine("ERROR: la lista está vacía");
            Console.WriteLine();
        }
        else
        {
            int i = 1;
            foreach (musica cancion in canciones)
            {
                Console.WriteLine((i++) + " - " + cancion);
            }
            Console.WriteLine();
            int posicion = pedirInt("Introduzca posición: ") - 1;
            Console.WriteLine();

            int cambios = 0;
            if (posicion >= 0 && posicion < canciones.Count)
            {
                Console.WriteLine(canciones[posicion]);
                Console.WriteLine();
                Console.WriteLine("Introduzca nuevos datos o deje en blanco "
                    + "para conservar los originales");
                Console.WriteLine();

                Console.WriteLine("Título original: "
                    + canciones[posicion].getTitulo());
                string titulo = pedirString("Nuevo título: ");
                if (titulo != "")
                {
                    canciones[posicion].setTitulo(titulo);
                    cambios++;
                }
                Console.WriteLine();

                Console.WriteLine("Autor original: "
                    + canciones[posicion].getAutor());
                string autor = pedirString("Nuevo autor: ");
                if (autor != "")
                {
                    canciones[posicion].setAutor(autor);
                    cambios++;
                }
                Console.WriteLine();

                Console.WriteLine("Nombre fichero original: "
                    + canciones[posicion].getNombreFichero());
                string nombreFichero = pedirString("Nuevo nombre fichero: ");
                if (nombreFichero != "")
                {
                    canciones[posicion].setNombreFichero(nombreFichero);
                    cambios++;
                }
                Console.WriteLine();

                Console.WriteLine("Ruta original: "
                    + canciones[posicion].getRuta());
                string ruta = pedirString("Nueva ruta: ");
                if (ruta != "")
                {
                    canciones[posicion].setRuta(ruta);
                    cambios++;
                }
                Console.WriteLine();

                Console.WriteLine("Tamaño original: "
                    + canciones[posicion].getTamanyo());
                int tamanyo = pedirInt("Nuevo tamaño: ");
                if (tamanyo > 0)
                {
                    canciones[posicion].setTamanyo(tamanyo);
                    cambios++;
                }
                Console.WriteLine();

                if (cambios > 0)
                {
                    guardar(canciones);
                }
            }
            else
            {
                Console.WriteLine("ERROR: no se han encontrado coincidencias");
                Console.WriteLine();
            }
        }
    }

    public static void eliminar(List<musica> canciones)
    {
        if (canciones.Count == 0)
        {
            Console.WriteLine("ERROR: la lista está vacía");
            Console.WriteLine();
        }
        else
        {
            int i = 1;
            foreach (musica cancion in canciones)
            {
                Console.WriteLine((i++) + " - " + cancion);
            }
            Console.WriteLine();
            int posicion = pedirInt("Introduzca posición: ") - 1;
            Console.WriteLine();
            if (posicion >= 0 && posicion < canciones.Count)
            {
                Console.WriteLine(canciones[posicion]);
                Console.WriteLine();
                string confirmacion = pedirString("Seguro que desea eliminar "
                    + "esta canción? (Y/N): ");
                if (confirmacion == "Y")
                {
                    Console.WriteLine();
                    Console.WriteLine("Borrado confirmado");
                    Console.WriteLine();
                    canciones.RemoveAt(posicion);
                    guardar(canciones);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Operación cancelada");
                    Console.WriteLine();
                }
            }
        }
    }

    public static void ordenarTitulo(List<musica> canciones)
    {
        if (canciones.Count == 0)
        {
            Console.WriteLine("ERROR: la lista está vacía");
            Console.WriteLine();
        }
        else
        {
            canciones.Sort((c1, c2) => c1.titulo.CompareTo(c2.titulo));
            foreach (musica cancion in canciones)
            {
                Console.WriteLine(cancion);
            }
            Console.WriteLine();
        }
    }

    public static void ordenarAutor(List<musica> canciones)
    {
        if (canciones.Count == 0)
        {
            Console.WriteLine("ERROR: la lista está vacía");
            Console.WriteLine();
        }
        else
        {
            canciones.Sort((c1, c2) => c1.autor.CompareTo(c2.autor));
            foreach (musica cancion in canciones)
            {
                Console.WriteLine(cancion);
            }
            Console.WriteLine();
        }
    }

    public static void guardar(List<musica> canciones)
    {
        try
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(
                "canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, canciones);
            stream.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: no se pudieron guardar los datos");
        }
    }

    public static List<musica> cargar()
    {
        List<musica> canciones = new List<musica>();

        if (File.Exists("canciones.bin"))
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(
                    "canciones.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                canciones = (List<musica>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: no se pudieron cargar los datos");
            }
        }
        else
        {
            Console.WriteLine("No existen datos guardados");
        }

        return canciones;
    }
}
