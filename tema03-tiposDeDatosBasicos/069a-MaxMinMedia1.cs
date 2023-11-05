//  Mario (...)

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

class Estadisticas
{
    static void Main()
    {
        string datoCadena;
        // Nota del profesor:
        // Cuidado: prefijar un máximo y un mínimo que no sean parte 
        //   de los datos es MUY arriesgado
        // Sería más arriesgado aún hacer maximo = 0, minimo = 0
        double min = 100000000000, max = -1000000000000, suma = 0, media, datoNumerico;
        int contador = 1;
        
        do
        {
            Console.Write("Dato: ");
            datoCadena = Console.ReadLine();
            
            if (datoCadena != "fin")
            {
                datoNumerico = Convert.ToDouble(datoCadena);
                if (datoNumerico < min)
                    min = datoNumerico;
                if (datoNumerico > max)
                    max = datoNumerico;
                suma = suma + datoNumerico;
                media = suma / contador;
                contador++;
            
                Console.Write("Min = {0}, Max = {1}, ", min, max);
                Console.Write("Suma = {0}, Media = {1}", suma, media);
                Console.WriteLine();
            }
        }
        while (datoCadena != "fin");
        
        Console.Write("¡Hasta otra!");
    }
}
