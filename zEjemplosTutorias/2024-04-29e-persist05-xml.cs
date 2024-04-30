
// Crea una nueva variante usando datos en formato XML
// (con using System.Xml.Serialization).



using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

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
        XmlSerializer formatter = new XmlSerializer(
            dato.GetType());
        Stream fichero = new FileStream(nombre,
            FileMode.Create, FileAccess.Write,
            FileShare.None);
        formatter.Serialize(fichero, dato);
        fichero.Close();
    }


    public static EjemploPersistencia Cargar(string nombre)
    {
        EjemploPersistencia dato = new EjemploPersistencia();
        XmlSerializer formatter = new XmlSerializer(
            dato.GetType());
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
        EjemploPersistencia.Guardar("persist05.xml", e);
        e = new EjemploPersistencia();
        Console.WriteLine("Valor tras inicializar: " + e);
        e = EjemploPersistencia.Cargar("persist05.xml");
        Console.WriteLine("Valor tras cargar: " + e);
    }
}

// Valor inicial: 30 - 4,5( 3 4 5 6 7)
// Valor tras inicializar: 0 - 0()
// Valor tras cargar: 30 - 4,5(3 4 5 6 7)

/*
<?xml version="1.0"?>
<EjemploPersistencia xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Numero>30</Numero>
  <Numero2>4.5</Numero2>
  <Numeros>
    <int>3</int>
    <int>4</int>
    <int>5</int>
    <int>6</int>
    <int>7</int>
  </Numeros>
</EjemploPersistencia>


*/
