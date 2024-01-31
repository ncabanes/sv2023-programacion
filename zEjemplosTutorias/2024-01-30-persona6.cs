/* Amplía la clase  PersonaConEdad, para añadir un método 
CalcularAnyoNacimiento, que deduzca el año en que nació, restando su 
edad del año actual.

Crea un array que contenga clases Persona y PersonaConEdad, añade 3 
datos de ejemplo, recorre el array con un foreach, mostrando los datos 
de cada una (usando ToString() y muestra el año de nacimiento de las 
que sean de tipo PersonaConEdad.

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
        
        personas[0] = new Persona("Juan", "López");
        personas[1] = new PersonaConEdad(
            "José", "Martínez", 20);
        personas[2] = new PersonaConEdad(
            "Luis", "Pérez");
        
        foreach(Persona p in personas)
        {
            Console.WriteLine(p);
            if (p is PersonaConEdad)
                Console.WriteLine("  Nacido en: " + 
                    ((PersonaConEdad) p).CalcularAnyoNacimiento());
        }
    }
}

// López, Juan
// Martínez, José - 20
//   Nacido en: 2004
// Pérez, Luis - 18
//   Nacido en: 2006
