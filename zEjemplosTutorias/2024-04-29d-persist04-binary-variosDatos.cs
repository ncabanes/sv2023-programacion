
// Crea una versión que guarde "de forma
// artesanal" tres atributos (o propiedades):
// un número entero, un real de doble
// precisión y una lista con 5 enteros.


using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[Serializable]
class EjemploPersistencia
{
    public int Numero { get; set; }
    public double Numero2 { get; set; }
    public List<int> Numeros { get; set; }

    public EjemploPersistencia()
    {
        Numeros = new List<int>();
    }



    public static void Guardar(string nombre, EjemploPersistencia dato)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream fichero = new FileStream(nombre,
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(fichero, dato);
        fichero.Close();
    }


    public static EjemploPersistencia Cargar(string nombre)
    {
        EjemploPersistencia dato;
        IFormatter formatter = new BinaryFormatter();
        Stream fichero = new FileStream(nombre,
            FileMode.Open, FileAccess.Read,
            FileShare.Read);
        dato = (EjemploPersistencia)formatter.Deserialize(fichero);
        fichero.Close();
        return dato;
    }

    public override string ToString()
    {
        string respuesta = Numero.ToString() + " - "
            + Numero2.ToString() + "(";
        foreach (int i in Numeros)
        {
            respuesta += " " + i;
        }
        respuesta += ")";
        return respuesta;
    }



    static void Main()
    {
        EjemploPersistencia e = new EjemploPersistencia();
        e.Numero = 30;
        e.Numero2 = 4.5;
        e.Numeros = new List<int>(new int[] { 3, 4, 5, 6, 7 });
        Console.WriteLine("Valor inicial: " + e);
        EjemploPersistencia.Guardar("persist04.bin", e);
        e = new EjemploPersistencia();
        Console.WriteLine("Valor tras inicializar: " + e);
        e = EjemploPersistencia.Cargar("persist04.bin");
        Console.WriteLine("Valor tras cargar: " + e);
    }
}

// Valor inicial: 30 - 4,5( 3 4 5 6 7)
// Valor tras inicializar: 0 - 0()
// Valor tras cargar: 30 - 4,5(3 4 5 6 7)

