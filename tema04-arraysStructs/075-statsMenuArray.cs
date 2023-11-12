/*75. Crea un array de números reales de simple precisión, con espacio para 10 
datos. Pide al usuario esos 10 datos y luego muestra un menú que le permita: 
Ver todos los datos en el orden en que se habían introducido, calcular y 
mostrar el máximo de los datos, calcular y mostrar el mínimo de los datos, 
buscar (ver si está almacenado) un cierto dato, salir. La opción de Buscar 
preguntará el dato que se quiere localizar y responderá si era parte de los 10 
datos iniciales o no lo era.*/

// Miguel Ángel (...), retoques menores por Nacho

using System;

class statsMenuArray
{
    static void Main()
    {
        const byte VER = 1, VER_MAXIMO = 2, VER_MINIMO = 3, BUSCAR = 4,
            SALIR = 0;
        byte opcion;
        float[] numeros = new float[10];
        float numero, min , max;
        bool encontrado;
        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Dame un número para meter en el array: ");
            numeros[i] = Convert.ToSingle(Console.ReadLine());
        }
        Console.WriteLine();
        
        do
        {
            Console.WriteLine(VER + ". Ver datos existentes");
            Console.WriteLine(VER_MAXIMO + ". Muestra el máximo de los datos");
            Console.WriteLine(VER_MINIMO + ". Muestra el mínimo de los datos");
            Console.WriteLine(BUSCAR + ". Buscar un dato");
            Console.WriteLine(SALIR + ". Salir");
            Console.WriteLine();
            Console.Write("Escoge una opción: ");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            
            switch(opcion)
            {
                case VER:
                    Console.Write("Los datos son: ");
                    foreach (float dato in numeros)
                    {
                        Console.Write(dato + " ");
                    }
                    Console.WriteLine();
                    break;
                    
                case VER_MAXIMO: 
                    max = numeros[0];
                    for (int i = 1; i < numeros.Length; i++)
                    {
                        if ( numeros[i] > max)
                        {
                            max = numeros[i];
                        }
                    }
                    Console.WriteLine("El máximo es: " + max);
                    break;
                    
                case VER_MINIMO:
                    min = numeros[0];
                    for (int i = 1; i < numeros.Length; i++)
                    {
                        if ( numeros[i] < min)
                        {
                            min = numeros[i];
                        }
                    }
                    Console.WriteLine("El mínimo es: " + min);
                    break;
                    
                case BUSCAR:
                    Console.Write("Número a buscar: ");
                    numero = Convert.ToSingle(Console.ReadLine());
        
                    encontrado = false;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if ( numeros[i] == numero )
                        {
                            encontrado = true;
                        }
                    }
                    if (encontrado)
                    {
                        Console.WriteLine("Encontrado");
                    }
                    else
                    {
                        Console.WriteLine("No encontrado.");
                    }
                    break;
                        
                case SALIR: 
                    break;
                
                default: 
                    Console.WriteLine("Opción no válida"); 
                    break;
            }
            Console.WriteLine();
        }
        while (opcion != SALIR);
    }
}
