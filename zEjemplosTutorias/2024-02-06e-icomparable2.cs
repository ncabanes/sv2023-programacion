/* Mejora el ejercicio anterior:

A partir de las clases Persona y PersonaConEdad, implementa la interfaz 
IComparable. Detalla su método CompareTo, de modo que dos personas se 
ordenen por apellidos, y, en caso de coincidir los apellidos, por 
nombre. Añade tres personas de ejemplo, ordénalas y muestra el 
resultado.

*/

using System;

class Persona : IComparable<Persona>
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    protected Persona madre;

    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
    }

    public override string ToString()
    {
        return Apellidos + ", " + Nombre;
    }

    public void IndicarMadre(Persona p)
    {
        madre = p;
    }

    public void MostrarFamilia()
    {
        if (madre != null)
            Console.WriteLine("  Madre: " + madre.Nombre);
    }

    public int CompareTo(Persona otro)
    {
        if (Apellidos != otro.Apellidos)
            return Apellidos.CompareTo(otro.Apellidos);
        else
            return Nombre.CompareTo(otro.Nombre);
    }
}

class PersonaConEdad : Persona
{
    public int Edad { get; set; }

    public PersonaConEdad(string nombre, string apellidos,
        int Edad) : base(nombre, apellidos)
    {
        this.Edad = Edad;
    }

    public PersonaConEdad(string nombre, string apellidos)
        : this(nombre, apellidos, 18)
    {
    }

    /*
    public PersonaConEdad(string nombre, string apellidos) 
        : base (nombre, apellidos)
    {
        Edad = 18;
    }
    */

    public override string ToString()
    {
        return base.ToString() + " - " + Edad;
    }

    public int CalcularAnyoNacimiento()
    {
        return 2024 - Edad;
    }
}

class PruebaPersona
{
    static void Main()
    {
        Persona[] personas = new Persona[3];

        personas[0] = new Persona("María", "Pérez");
        personas[1] = new PersonaConEdad(
            "José", "Martínez", 20);
        personas[1].IndicarMadre(personas[0]);
        personas[2] = new PersonaConEdad(
            "Luis", "Martínez");

        Array.Sort(personas);

        foreach (Persona p in personas)
        {
            Console.WriteLine(p);
            p.MostrarFamilia();
            if (p is PersonaConEdad)
                Console.WriteLine("  Nacido en: " +
                    ((PersonaConEdad)p).CalcularAnyoNacimiento());
        }
    }
}

// Martínez, José - 20
//   Madre: María
//   Nacido en: 2004
// Martínez, Luis - 18
//   Nacido en: 2006
// Pérez, María

