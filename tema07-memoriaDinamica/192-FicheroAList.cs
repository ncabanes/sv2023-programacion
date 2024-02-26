/*
 192. Como ver�s con m�s detalle en el tema 8, una forma r�pida de leer todo el contenido 
de un fichero de texto es emplear "string[] lineas = File.ReadAllLines("nombreDeFichero.ext");" 
(necesitar�s a�adir tambi�n "using System.IO;"). Adem�s, puedes crear una lista a partir de ese array de strings,
ya sea recorriendo el array para a�adir a la lista de forma manual,
o bien con "List<string> lista = new List<string>(lineas);". 
Haz un programa que muestre un men�, mediante el cual el usuario pueda:

1 - Cargar un fichero

2 - Mostrar todo el contenido del fichero

3 - Mostrar parte del contenido, desde un n�mero de l�nea hasta otro n�mero de l�nea.

4 - Insertar una l�nea en cualquier posici�n.

5 - Borrar una l�nea en cualquier posici�n.

6 - Buscar las l�neas que contengan un cierto texto.

7 - Ordenar las l�neas alfab�ticamente.

T - Terminar.

(Como mejora opcional, puedes hacer que se guarde el resultado
en otro fichero cuando termine la ejecuci�n, con "File.WriteAllLines
("nombre2.ext", miLista.ToArray());").
*/

// julio

using System;
using System.Collections.Generic;
using System.IO;


class FicheroYLista
{
    static void Main()
    {
        string opcion;
        const string
            CARGAR = "1",
            MOSTRAR_TODO = "2",
            MOSTRAR_PARTE = "3",
            INSERTAR_LINEA = "4",
            BORRAR_LINEA = "5",
            BUSCAR = "6",
            ORDENAR = "7",
            TERMINAR = "T";

        List<string> lista = new List<string>();

        do
        {
            Console.WriteLine();
            Console.WriteLine(CARGAR + " - Cargar un fichero");
            Console.WriteLine(MOSTRAR_TODO + " - Mostrar todo el contenido del fichero");
            Console.WriteLine(MOSTRAR_PARTE + " - Mostrar parte del contenido, desde un n�mero de l�nea hasta otro n�mero de l�nea.");
            Console.WriteLine(INSERTAR_LINEA + " - Insertar una l�nea en cualquier posici�n.");
            Console.WriteLine(BORRAR_LINEA + " - Borrar una l�nea en cualquier posici�n.");
            Console.WriteLine(BUSCAR + " - Buscar las l�neas que contengan un cierto texto.");
            Console.WriteLine(ORDENAR + " - Ordenar las l�neas alfab�ticamente.");
            Console.WriteLine(TERMINAR + " - Terminar");
            Console.WriteLine();
            opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                case CARGAR: Cargar(ref lista); break;
                case MOSTRAR_TODO: MostrarTodo(lista); break;
                case MOSTRAR_PARTE: MostrarParte(lista); break;
                case INSERTAR_LINEA: Insertar(lista); break;
                case BORRAR_LINEA: Borrar(lista); break;
                case BUSCAR: Buscar(lista); break;
                case ORDENAR: Ordenar(lista); break;
                case TERMINAR: Console.WriteLine("Cerrando programa..."); break;
                default: Console.WriteLine("Elige una opci�n; "); break;
            }
        }
        while (opcion != TERMINAR);
    }

    private static void Cargar(ref List<string> lista)
    {
        string nombre = Pedir("Dime el nombre del fichero: ");
        string[] lineas = File.ReadAllLines(nombre);
        lista = new List<string>(lineas);
        Console.WriteLine("Cargado correctamente");

    }
    private static void MostrarTodo(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine((i+1) + ". " + lista[i]);
        }
    }

    private static void MostrarParte(List<string> lista)
    {
        Console.WriteLine("Indica un rango entre 1 y " + (lista.Count - 1));
        int n1 = Convert.ToInt32(Pedir("Primer n�mero: ")) - 1;
        int n2 = Convert.ToInt32(Pedir("Segundo n�mero: "));

        for (int i = n1; i < n2; i++)
        {
            Console.WriteLine(i + 1 + ". " + lista[i]);
        }
    }

    private static void Insertar(List<string> lista)
    {
        int posicionInsertar = Convert.ToInt32(
            Pedir("En que posicion quieres insertar el dato? de 1 a " + lista.Count + " ")) - 1;
        string datoInsertar = Pedir("Introduce el dato a insertar:");
        lista.Insert(posicionInsertar, datoInsertar);
        Console.WriteLine("linea insertada");
    }

    private static void Borrar(List<string> lista)
    {
        int posicionBorrar = Convert.ToInt32(
            Pedir("Que linea quieres borrar de 1 a " + lista.Count + ": ")) - 1;
        lista.RemoveAt(posicionBorrar);
        Console.WriteLine("L�nea borrada");
    }

    private static void Buscar(List<string> lista)
    {
        string datoBuscar = Pedir("Introduce texto buscar: ");

        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].ToUpper().Contains(datoBuscar.ToUpper()))
            {
                Console.WriteLine(i + 1 + ". " + lista[i]);
            }
        }
    }

    private static void Ordenar(List<string> lista)
    {
        lista.Sort();
        Console.WriteLine("Lista ordenada");
    }

    private static string Pedir(string aviso)
    {
        Console.Write(aviso);
        return Console.ReadLine();
    }
}
