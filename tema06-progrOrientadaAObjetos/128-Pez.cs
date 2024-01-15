/* 128. Crea una clase llamada "Pez", que representará supuestamente uno de
 * tantos componentes que aparecerán en un simulador de una pecera que vamos a
 * desarrollar. Sus atributos (públicos) serán el nombre (una cadena de texto)
 * y la especie (otra cadena de texto). Tendrá un método llamado "Nadar", que
 * por ahora simplemente escribirá en pantalla "Soy un pez de la especie XXX,
 * llamado YYY y estoy nadando". Crea una clase "SimuladorDePecera" (en el mismo
 * fichero fuente), que tendrá un "Main" para probarlo. Deberás entregar sólo
 * el fichero ".cs".
 * 
 * VÍCTOR (...) */

using System;

class Pez
{
    public string nombre, especie;

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
        pescado.nombre = Console.ReadLine();
        Console.Write("Dime la especie del pez: ");
        pescado.especie = Console.ReadLine();

        pescado.Nadar();
    }
}
