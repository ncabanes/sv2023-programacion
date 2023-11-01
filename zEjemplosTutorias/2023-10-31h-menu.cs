// Contacto con los menús, usando
// - "números mágicos"
// - constantes
// - enumeraciones

using System;

class EjemploMenu
{
    enum opciones { SALIR, JUGAR, CARGAR }

    static void Main()
    {
        const int JUGAR = 1, CARGAR = 2;        

        Console.WriteLine("1- Jugar");
        Console.WriteLine("2- Cargar partida");
        Console.WriteLine("0- Salir");

        int opcion = Convert.ToInt32(Console.ReadLine());   

        switch (opcion)
        {
            case 1: //...
                break;

            case CARGAR: //...
                break;

            case (int) opciones.SALIR: // ...
                break;
        }
    }
}

