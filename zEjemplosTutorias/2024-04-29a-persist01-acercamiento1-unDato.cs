
// Crea una variante del ejemplo, en la que el número
// no sea un atributo con getters y setters, sino
// una propiedad.

using System;
using System.IO;

class EjemploPersistencia
{
    public int Numero { get; set; }

    public void Guardar(string nombreFich)
    {
        BinaryWriter fichSalida = new BinaryWriter(
            File.Open(nombreFich, FileMode.Create));
        fichSalida.Write(Numero);
        fichSalida.Close();
    }

    public void Cargar(string nombreFich)
    {
        BinaryReader fichEntrada = new BinaryReader(
            File.Open(nombreFich, FileMode.Open));
        Numero = fichEntrada.ReadInt32();
        fichEntrada.Close();
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
        e.Guardar("persist01.bin");
        e = new EjemploPersistencia();
        Console.WriteLine("Valor tras inicializar: " + e);
        e.Cargar("persist01.bin");
        Console.WriteLine("Valor tras cargar: " + e);
    }
}

// Valor inicial: 30
// Valor tras inicializar: 0
// Valor tras cargar: 30
