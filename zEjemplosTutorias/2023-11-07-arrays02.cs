using System;

// Pide al usuario 5 números reales de doble precisión. 
// Después, usando "foreach", calcula su media y muestra 
// los que están por encima de la media.

class Arrays02 
{
    static void Main() 
    {
        double[] datos = new double[5];
        double suma, media;
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dime el dato "+ (i+1) + ": ");
            datos[i] = Convert.ToDouble( Console.ReadLine() );
        }
        
        /*
        suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += datos[i];
        }
        media = suma / 5;
        Console.WriteLine("La media es " + media);
        */
        
        suma = 0;
        foreach(double d in datos)
        {
            suma += d;
        }
        media = suma / 5;
        Console.WriteLine("La media es " + media);
        
        Console.WriteLine("Datos por encima de la media");
        foreach(double dato in datos)
        {
            if (dato > media)
                Console.WriteLine(dato);
        }
    }
}

/*
Dime el dato 1: 10
Dime el dato 2: 20
Dime el dato 3: 304
Dime el dato 4: 40
Dime el dato 5: 50,123
La media es 84,8246
Datos por encima de la media
304
*/
