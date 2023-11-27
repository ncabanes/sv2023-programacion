/*91. Crea un programa que pida al usuario 10 números enteros largos, los 
guarde en un array llamados "datosOriginales", y luego:
- Los copie a un array "datos1", ordene este array mediante intercambio directo 
(ya sea ascendente, descendente o burbuja) y muestre el contenido de "datos1".
- Los copie a un array "datos2", ordene este array mediante selección directa y 
muestre el contenido de "datos2".
- Los copie a un array "datos3", ordene este array mediante inserción directa y 
muestre el contenido de "datos3".
- Compruebe si el dato 50 aparece en "datosOriginales", mediante búsqueda 
lineal.
- Compruebe si el dato 50 aparece en "datos3", mediante búsqueda binaria.*/

// Miguel Ángel (...)

using System;

class ordenacions
{
    static void Main()
    {
        long[] datosOriginales = new long[10];
        long aux, menor;
        int numBuscado = 50;
        
        
        for (int i = 0; i < datosOriginales.Length; i ++)
        {
            Console.Write("Dame un número para la posición {0}: ", i + 1);
            datosOriginales[i] = Convert.ToInt64(Console.ReadLine());
        }
        
        // Volcamos a un primer array auxiliar
        // Cuidado: no basta con "long[] datos1 = datosOriginales;" (es un alias)
        long[] datos1 = new long[10];
        for (int i = 0; i < 10; i++)
        {
            datos1[i] = datosOriginales[i];
        }
        
        // Intercambio directo
        for (int i = 0; i < datos1.Length - 1; i ++)
        {
            for (int j = i + 1; j < datos1.Length; j ++)
            {
                if ( datos1[i] > datos1[j] )
                {
                    aux = datos1[i];
                    datos1[i] = datos1[j];
                    datos1[j] = aux;
                }
            }
        }
        
        foreach (long dato in datos1)
        {
            Console.Write("{0} ",dato);
        }
        Console.WriteLine();
        
        
        // Volcamos a un segundo array auxiliar
        long[] datos2 = new long[10];
        for (int i = 0; i < 10; i++)
        {
            datos2[i] = datosOriginales[i];
        }
        
        // Selección directa
        for (int i = 0; i < datos2.Length - 1; i ++)
        {   
            menor = i;
            for (int j = i + 1; j < datos2.Length; j ++)
            {
                if ( datos2[j] < datos2[menor] )
                {
                    menor = j;
                }
            }
            if (i != menor)
            {
                aux = datos2[i];
                datos2[i] = datos2[menor];
                datos2[menor] = aux;
            }
            
        }
        
        foreach (long dato in datos2)
        {
            Console.Write("{0} ",dato);
        }
        Console.WriteLine();


        // Volcamos a un tercer array auxiliar
        long[] datos3 = new long[10];
        for (int i = 0; i < 10; i++)
        {
            datos3[i] = datosOriginales[i];
        }
        // Inserción directa
        for (int i = 1; i < datos3.Length; i ++)
        {   
            int j = i - 1;
            while ((j >= 0) && (datos3[j] > datos3[j+1]))
            {
                aux = datos3[j];
                datos3[j] = datos3[j + 1];
                datos3[j + 1] = aux;
                j--;
            }           
        }
        
        foreach (long dato in datos3)
        {
            Console.Write("{0} ",dato);
        }
        Console.WriteLine();
        
        // Búsqueda lineal
        bool encontradoL = false;
        for (int i = 0; i < datosOriginales.Length; i ++)
        {
            if (datosOriginales[i] == numBuscado)
            {
                encontradoL = true;
            }
        }
        
        if (encontradoL)
        {
            Console.WriteLine("El dato {0} se encuentra en el array", 
                numBuscado);
        }
        else
        {
            Console.WriteLine("El dato {0} no se encuentra en el array", 
                numBuscado);
        }
        
        
        // Búsqueda binaria
        bool encontradoB = false;
        int izda = 0, dcha = datos3.Length - 1;
        while (encontradoB != true && izda <= dcha)
        {
            int centro = izda + (dcha - izda) / 2;
            
            if (datos3[centro] == numBuscado)
            {
                encontradoB = true;
            }
            else if ( datos3[centro] < numBuscado)
            {
                izda = centro + 1;
            }
            else
            {
                dcha = centro - 1;
            }
                            
        }
        
        if (encontradoB)
        {
            Console.WriteLine("El dato {0} se encuentra en el array", 
                numBuscado);
        }
        else
        {
            Console.WriteLine("El dato {0} no se encuentra en el array", 
                numBuscado);
        }
        
    }
}
