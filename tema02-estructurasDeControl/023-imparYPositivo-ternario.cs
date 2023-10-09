/*
23. Crea una variante del ejercicio anterior, en la que la variable se 
llamará "imparYpositivo", y recibirá el valor 1 si el número 
introducido por el usuario es positivo además de impar. En caso 
contrario (si no es positivo o no es impar), tendrá el valor 0.
*/

// Miguel Ángel (...), retoques por Nacho

using System;
class Ejercicio023
{
    static void Main()
    {
        int numero, imparYpositivo;
        
        Console.WriteLine("Introduce un número entero:");
        numero = Convert.ToInt32(Console.ReadLine());
        
        if ((numero%2 == 1) && (numero > 0))
        {
            imparYpositivo = 1; 
        }
        else 
        {
            imparYpositivo = 0;
        }
        
        Console.WriteLine("Impar y positivo: {0}", imparYpositivo);
        
        imparYpositivo = (numero%2 == 1) && (numero > 0) ? 1 : 0;
        
        Console.WriteLine("Impar y positivo: {0}", imparYpositivo);
    }
}
