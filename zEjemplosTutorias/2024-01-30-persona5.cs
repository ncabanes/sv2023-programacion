/* Crea un array que contenga clases Persona y PersonaConEdad, añade 3 
datos de ejemplo, recorre el array con un foreach e indica de qué tipo 
es cada objeto que extraes.
*/

using System;

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
       
    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
    }
    
    public override string ToString()
    {
        return Apellidos + ", " + Nombre;
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
}

class PruebaPersona 
{
    static void Main() 
    {
        Persona[] personas = new Persona[3];
        
        personas[0] = new Persona("Juan", "López");
        personas[1] = new PersonaConEdad(
            "José", "Martínez", 20);
        personas[2] = new PersonaConEdad(
            "Luis", "Pérez");
        
        foreach(Persona p in personas)
        {
            Console.WriteLine(p);
            if (p is PersonaConEdad)
                Console.WriteLine("  (tiene edad)");
        }
    }
}

// López, Juan
// Martínez, José - 20
//   (tiene edad)
// Pérez, Luis - 18
//   (tiene edad)
