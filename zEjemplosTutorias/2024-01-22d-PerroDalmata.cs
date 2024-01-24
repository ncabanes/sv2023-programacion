/* Crea una nueva versión del array formado por varios perros. 
 * Emplea "virtual" y "override".
 */

using System;

class Perro
{
    public void Ladrar()
    {
        Console.WriteLine("Guau!");
    }
}


class Dalmata : Perro
{
    public new void Ladrar()
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
