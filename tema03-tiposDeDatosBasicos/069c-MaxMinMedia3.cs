/*  69. Escribe un programa que pida al usuario números reales de doble 
    precisión y muestre su mínimo, máximo, suma y media después de cada 
    paso. Terminará cuando introduzca la palabra "fin":

    Dato: 5
    Min = 5, Max = 5, Suma = 5, Media = 5
    Dato: 2.2
    Min = 2.2, Max = 5, Suma = 7.2, Media = 3.6
    Dato: fin
    ¡Hasta otra!

    Pista: deberás leer lo que introduzca el usuario como string, y 
    convertir a dato numérico sólo en caso de que no sea la palabra 
    "fin".
*/

using System;

class EstadisticasV3
// Versión alternativa con lectura previa y "while" posterior, más repetitiva
{
    static void Main()
    {
        string datoCadena;
        double datoNumerico;
        double min = 0, max = 0, suma = 0; // Se cambia en la primera pasada
        int contador = 0;
        
        Console.Write("Dato: ");
        datoCadena = Console.ReadLine();
        
        if (datoCadena != "fin")
        {
            datoNumerico = Convert.ToDouble(datoCadena);
            // Tomamos los valores iniciales desde el primer dato
            min = max = suma = datoNumerico;
            contador++;
        
            Console.Write("Min = {0}, Max = {1}, ", min, max);
            Console.Write("Suma = {0}, Media = {1}", suma, suma/contador);
            Console.WriteLine();
            
            Console.Write("Dato: ");
            datoCadena = Console.ReadLine();
        }
        
        while (datoCadena != "fin")
        {
            datoNumerico = Convert.ToDouble(datoCadena);
            // En el segundo y sucesivos, ya sí comparamos
            if (datoNumerico < min) min = datoNumerico;
            if (datoNumerico > max) max = datoNumerico;
            suma += datoNumerico;
            contador++;
        
            Console.Write("Min = {0}, Max = {1}, ", min, max);
            Console.Write("Suma = {0}, Media = {1}", suma, suma/contador);
            Console.WriteLine();

            Console.Write("Dato: ");
            datoCadena = Console.ReadLine();
        }
        
        Console.Write("¡Hasta otra!");
    }
}
