/* Crea una versión ampliada de las clases Persona y PersonaConEdad, en 
la que cada persona pueda tener una madre (omitiremos el padre y los 
hijos). Crea un método IndicarMadre(Persona p) para dar valor a ese 
nuevo atributo. Añade también un método MostrarFamilia, que muestre el 
nombre de la madre (si existe).
*/

using System;

class Persona
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
}

class PersonaConEdad : Persona
{
    public int Edad { get; set; }
    
    public PersonaConEdad(string nombre, string apellidos,
        int Edad) : base (nombre, apellidos)
    {
        this.Edad = Edad;
    }
    
    public PersonaConEdad(string nombre, string apellidos) 
        : this (nombre, apellidos, 18)
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
        
        personas[0] = new Persona("María", "López");
        personas[1] = new PersonaConEdad(
            "José", "Martínez", 20);
        personas[1].IndicarMadre( personas[0] );
        personas[2] = new PersonaConEdad(
            "Luis", "Pérez");
        
        foreach(Persona p in personas)
        {
            Console.WriteLine(p);
            p.MostrarFamilia();
            if (p is PersonaConEdad)
                Console.WriteLine("  Nacido en: " + 
                    ((PersonaConEdad) p).CalcularAnyoNacimiento());
        }
    }
}

// López, María
// Martínez, José - 20
//   Madre: María
//   Nacido en: 2004
// Pérez, Luis - 18
//   Nacido en: 2006
