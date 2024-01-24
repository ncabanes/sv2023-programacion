/* Crea las clases Perro y (heredando de ella) Dalmata. Haz que ladren 
de forma distinta. Prueba a crear un único array que contenga objetos 
de ambas clases y comprueba si se comportan correctamente.


*/

using System;

class Perro
{
    public virtual void Ladrar()
    {
        Console.WriteLine("Guau!");
    }
}


class Dalmata : Perro
{
    public override void Ladrar()
    {
        Console.WriteLine("Woff!");
    }
}

// -------------------

class PruebaDePerros
{
    static void Main()
    {
        Perro [] misPerros = new Perro [2];

        misPerros[0] = new Perro();
        misPerros[1] = new Dalmata();
        
        misPerros[0].Ladrar();
        misPerros[1].Ladrar();

    }
}

// Guau!
// Woff!
