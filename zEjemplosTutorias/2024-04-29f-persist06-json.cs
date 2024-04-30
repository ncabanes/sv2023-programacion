
// Crea una última variante, que guarde datos en formato JSON.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;

[Serializable]
public class EjemploPersistencia
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
        string jsonString = JsonSerializer.Serialize(dato);
        File.WriteAllText(nombre, jsonString);
    }


    public static EjemploPersistencia Cargar(string nombre)
    {
        string jsonString = File.ReadAllText(nombre);
        EjemploPersistencia objeto =
             JsonSerializer.Deserialize<EjemploPersistencia>(jsonString);
        return objeto;
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
        EjemploPersistencia.Guardar("persist06.json", e);
        e = new EjemploPersistencia();
        Console.WriteLine("Valor tras inicializar: " + e);
        e = EjemploPersistencia.Cargar("persist06.json");
        Console.WriteLine("Valor tras cargar: " + e);
    }
}

// Valor inicial: 30 - 4,5( 3 4 5 6 7)
// Valor tras inicializar: 0 - 0()
// Valor tras cargar: 30 - 4,5(3 4 5 6 7)

/*
 {"Numero":30,"Numero2":4.5,"Numeros":[3,4,5,6,7]}
 */
