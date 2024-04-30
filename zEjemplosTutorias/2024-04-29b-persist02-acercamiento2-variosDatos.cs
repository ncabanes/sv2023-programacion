
// Crea una versión que guarde "de forma
// artesanal" tres atributos (o propiedades):
// un número entero, un real de doble
// precisión y una lista con 5 enteros.


using System;
using System.Collections.Generic;
using System.IO;

class EjemploPersistencia
{
    public int Numero { get; set; }
    public double Numero2 { get; set; }
    public List<int> Numeros { get; set; }

    public EjemploPersistencia()
    {
        Numeros = new List<int>();
    }

    public void Guardar(string nombreFich)
    {
        BinaryWriter fichSalida = new BinaryWriter(
            File.Open(nombreFich, FileMode.Create));
        fichSalida.Write(Numero);
        fichSalida.Write(Numero2);
        fichSalida.Write(Numeros.Count);
        foreach (int i in Numeros)
        {
            fichSalida.Write(i);
        }
        fichSalida.Close();
    }

    public void Cargar(string nombreFich)
    {
        BinaryReader fichEntrada = new BinaryReader(
            File.Open(nombreFich, FileMode.Open));
        Numero = fichEntrada.ReadInt32();
        Numero2 = fichEntrada.ReadDouble();
        int cantidad = fichEntrada.ReadInt32();
        Numeros = new List<int>();
        for (int i = 0; i < cantidad; i++)
        {
            Numeros.Add(fichEntrada.ReadInt32());
        }
        fichEntrada.Close();
    }

    public override string ToString()
    {
        string respuesta = Numero.ToString() +" - "
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
        e.Numeros = new List<int>(new int[]{ 3, 4, 5, 6, 7});
        Console.WriteLine("Valor inicial: " + e);
        e.Guardar("persist02.bin");
        e = new EjemploPersistencia();
        Console.WriteLine("Valor tras inicializar: " + e);
        e.Cargar("persist02.bin");
        Console.WriteLine("Valor tras cargar: " + e);
    }
}

// Valor inicial: 30 - 4,5( 3 4 5 6 7)
// Valor tras inicializar: 0 - 0()
// Valor tras cargar: 30 - 4,5(3 4 5 6 7)
