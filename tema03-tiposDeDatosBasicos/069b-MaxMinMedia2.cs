/* 69. Escribe un programa que pida al usuario números reales de doble 
 * precisión y muestre su mínimo, máximo, suma y media después de cada 
 * paso. Terminará cuando introduzca la palabra "fin":

Dato: 5
Min = 5, Max = 5, Suma = 5, Media = 5
Dato: 2.2
Min = 2.2, Max = 5, Suma = 7.2, Media = 3.6
Dato: fin
¡Hasta otra!

Pista: deberás leer lo que introduzca el usuario como string, 
* y convertir a dato numérico sólo en caso de que no sea la palabra 
* "fin".
*/

// Juan Luis, retoques menores por Nacho

using System;

class Ejercicio69
{   
    static void Main ()
    {
        string dato;
        double datoReal, suma = 0, media; 
        double minimo = 0, maximo = 0; // Se sobreescriben con el 1er dato
        byte cantidadDatos = 0;
        
        do
        {    
            Console.Write("Dato: ");
            dato = Console.ReadLine();
    
            Console.WriteLine();
        
            if(dato != "fin")
            {
                datoReal = Convert.ToDouble(dato);
                
                if (cantidadDatos == 0)
                {
                    minimo = datoReal;
                    maximo = datoReal;
                }
            
                suma += datoReal;
                
                cantidadDatos++;
                media = suma/cantidadDatos;
                
                if (datoReal < minimo)
                    minimo = datoReal;
               
                if (datoReal > maximo)
                    maximo = datoReal;
                
                Console.Write("Min = {0} ", minimo);
                Console.Write("Max = {0} ", maximo);
                Console.Write("Suma = {0} ", suma);
                Console.Write("Media = {0} ", media);
            }
            
            Console.WriteLine();
        }
        while(dato != "fin");      
        
        Console.WriteLine("¡Hasta otra!");
    }    
}
