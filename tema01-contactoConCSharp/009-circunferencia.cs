/*
 * Crea un programa que permita calcular longitudes de circunferencias. 
 * El usuario introducirá el radio y se le responderá algo como 
 * "La longitud de un circunferencia de radio 2 m es de 12,56 m2". 
 * Recuerda que la fórmula es L = 2 * PI * radio. 
 * Debes usar {0} en vez de "Write". 
 * No puedes utilizar "using System;".
 * Debe contener un único comentario de múltiples líneas, que detalle tu 
 * nombre y el cometido del programa.
 * 
 * Noelia (...)
 */
 
 
class Ejercicio09
{
    static void Main()
    {
        int radio;
        
        System.Console.Write("Introduce radio: ");
        radio = System.Convert.ToInt32( System.Console.ReadLine() );
    
        System.Console.Write(
            "La longitud de un circunferencia de radio {0} m es de {1} m2", 
            radio, 2 * 3.14 * radio);
    }
}
