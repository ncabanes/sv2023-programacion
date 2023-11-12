/*72. Crea un array que contenga los nombres de los meses, prefijando 
sus datos entre llaves. Muestra todos los meses en pantalla, desde el 
primero (enero) hasta el último (diciembre), en una misma línea y 
separados por espacios, usando "foreach". En la siguiente línea, 
muéstralos en orden inverso (de diciembre a enero), empleando "for". 
Finalmente, pide al usuario un número de mes (por ejemplo, el 3) y 
muestra su nombre (el 2 sería febrero). */

using System;

class Ejercicio_72
{
    static void Main()
    {
        string[]meses={"enero","febrero","marzo","abril","mayo","junio",
            "julio","agosto","septiembre","octubre","noviembre",
            "diciembre"};
            
        foreach(string mes in meses)
            Console.Write(mes+" ");
        Console.WriteLine();
        
        for(int i=11;i>=0;i--)
        {
            Console.Write(meses[i]+" ");
        }
        Console.WriteLine();
        
        Console.Write("Introduzca el numero de un mes: ");
        byte numero=Convert.ToByte(Console.ReadLine());
        Console.Write("Ha seleccionado el mes "+meses[numero-1]);
        
    }
}
            

