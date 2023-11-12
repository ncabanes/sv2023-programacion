/* 76. Crea una variante del ejercicio anterior en la que reserves espacio para 
1000 datos (reales de simple precisión), aunque el usuario típicamente 
introducirá muchos menos. El menú permitirá: Añadir un nuevo dato, ver todos 
los datos, calcular y mostrar el máximo de los datos, calcular y mostrar el 
mínimo de los datos, buscar un cierto dato, salir. La opción de Buscar 
preguntará el dato que se quiere localizar y responderá si está o no en el 
array. */

// Miguel Ángel (...), retoques menores por Nacho

using System;

class statsMenuArraySobredim
{
    static void Main()
    {
        const byte ANYADIR = 1, VER = 2, VER_MAXIMO = 3, VER_MINIMO = 4, 
            BUSCAR = 5, SALIR = 0;
        const ushort CAPACIDAD = 1000;
        byte opcion;
        float[] numeros = new float[CAPACIDAD];
        float numero, min , max;
        ushort datos = 0;
        bool encontrado;
        
        do
        {   
            Console.WriteLine(ANYADIR + ". Añadir un nuevo dato");
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
                case ANYADIR: 
                    if (datos < CAPACIDAD)
                    {
                        Console.Write("Dame un número para meter en el array: ");
                        numeros[datos] = Convert.ToSingle(Console.ReadLine());
                        datos ++;
                    }
                    else
                    {
                        Console.WriteLine(
                            "No hay hueco para añadir más números.");
                    }
                    break;
                    
                case VER: 
                    Console.Write("Los datos son: ");
                    for (int i = 0; i < datos ; i++)
                    {
                        Console.Write(numeros[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                    
                case VER_MAXIMO: 
                    max = (float) numeros[0];
                    for (int i = 1; i < datos; i++)
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
                    for (int i = 1; i < datos; i++)
                    {
                        if ( numeros[i] < min)
                        {
                            min = numeros[i];
                        }
                    }
                    Console.WriteLine("El mínimo es: " + min);
                    break;
                    
                case BUSCAR:
                    encontrado = false;
                    Console.Write("Número a buscar: ");
                    numero = Convert.ToSingle(Console.ReadLine());
        
                    for (int i = 0; i < datos; i++)
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
