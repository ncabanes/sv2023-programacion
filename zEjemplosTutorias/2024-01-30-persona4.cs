/* Crea un constructor alternativo para PersonaConEdad, que no recibirá 
edad, y la prefijará a 18 años, apoyándose en el constructor que sí la 
recibe.
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
        Persona p = new Persona("Juan", "López");
        Console.WriteLine(p);
        
        PersonaConEdad pe = new PersonaConEdad(
            "José", "Martínez", 20);
        Console.WriteLine(pe);
        
        PersonaConEdad pe18 = new PersonaConEdad(
            "Luis", "Pérez");
        Console.WriteLine(pe18);
    }
}

// López, Juan
// Martínez, José - 20
// Pérez, Luis - 18
