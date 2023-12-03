/*
102. Crea una función "PedirConValorPorDefecto", que mostrará en pantalla el 
mensaje de aviso que se indique como primer parámetro, recibirá el valor por 
defecto en un segundo parámetro, leerá lo que el usuario introduzca en consola 
y devolverá el valor introducido por el usuario o, si éste es una cadena vacía, 
el valor por defecto. Úsala para crear una nueva versión simplificada del 
ejercicio 101 (videojuegos V4bis), en la que las estructuras como:

Console.Write("Título (antes era "+ juego[i].titulo +"): ");
nuevoDatoString = Console.ReadLine();
if(nuevoDatoString != "")
{
    juego[i].titulo = nuevoDatoString;
}
se conviertan en:

juego[i].titulo = PedirConValorPorDefecto("Título", juego[i].titulo);
*/

// Mario (...)

using System;

class Ejercicio102
{
    struct juegos
    {
        public string titulo;
    }
    
    static string PedirConValorPorDefecto (string peticion, string valor)
    {
        Console.Write(peticion+" (antes era "+valor+"): ");
        string nuevoDatoString = Console.ReadLine();
        if (nuevoDatoString != "")
        {
            valor = nuevoDatoString;
        }
        
        return valor;
    }
    
    static void Main()
    {
        const ushort CAPACIDAD = 1000;
        ushort cantidad = 0;
        juegos[] juego = new juegos[CAPACIDAD]; 
        
        juego[0].titulo = "Buscaminas";
        ushort i = cantidad;
        
        juego[i].titulo = PedirConValorPorDefecto("Título", juego[i].titulo);
        Console.WriteLine(juego[i].titulo);
    }
}
