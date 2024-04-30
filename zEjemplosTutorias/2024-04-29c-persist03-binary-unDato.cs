
// Crea una variante del primer ejercicio
// serializando datos.

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[Serializable]
class EjemploPersistencia
{
    public int Numero { get; set; }

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
        return Numero.ToString();
    }



    static void Main()
    {
        EjemploPersistencia e = new EjemploPersistencia();
        e.Numero = 30;
        Console.WriteLine("Valor inicial: " + e);
        EjemploPersistencia.Guardar("persist03.bin", e);
        e = new EjemploPersistencia();
        Console.WriteLine("Valor tras inicializar: " + e);
        e = EjemploPersistencia.Cargar("persist03.bin");
        Console.WriteLine("Valor tras cargar: " + e);
    }
}

// Valor inicial: 30
// Valor tras inicializar: 0
// Valor tras cargar: 30
