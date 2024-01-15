/* 129. Crea una nueva versión de la clase "Pez". Sus atributos serán privados
 * y tendrá "getters" y "setters" que permitan cambiar el valor de éstos.
 * Modifica el programa y "Main" según sea necesario. Deberás entregar sólo el
 * fichero ".cs".
 * 
 * VÍCTOR (...) */

using System;

class Pez
{
    private string nombre, especie;

    public string GetNombre() { return nombre; }
    public string GetEspecie() { return especie; }

    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetEspecie(string nuevaEspecie) { especie = nuevaEspecie; }

    public void Nadar()
    {
        Console.WriteLine("Soy un pez de la especie " + especie + " llamado " +
            nombre + " y estoy nadando");
    }
}

class SimuladorDePecera
{
    static void Main()
    {
        Pez pescado = new Pez();

        Console.Write("Dime el nombre del pez: ");
        pescado.SetNombre(Console.ReadLine());
        Console.Write("Dime la especie del pez: ");
        pescado.SetEspecie(Console.ReadLine());

        
        string nombre = pescado.GetNombre();
        string especie = pescado.GetEspecie();
        Console.WriteLine(nombre);
        Console.WriteLine(especie);

        pescado.Nadar();
    }
}
