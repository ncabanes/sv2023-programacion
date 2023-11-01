// Contacto con los "enum"

using System;

class ContactoEnum
{
    enum DiasSemana { LUNES=1, MARTES, MIERCOLES }

    static void Main()
    {
        Console.WriteLine(DiasSemana.MIERCOLES);
        Console.WriteLine((int) DiasSemana.MIERCOLES);
    }
}
//MIERCOLES
//3
