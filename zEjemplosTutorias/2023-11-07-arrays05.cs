using System;

// Prepara un array con espacio para hasta 1000 números enteros.
// Permite que el usuario introduzca tantos como quiera, 
// hasta terminar pulsando "Intro" sin ningún número.
// Cuando termine, mostrarás todos los números introducidos.

class Arrays05
{
    static void Main() 
    {
        const int MAXIMO = 1000;
        int[] numeros = new int[MAXIMO];
        int cantidad = 0;
        string respuesta;
        
        do
        {
            Console.Write("Dime un número (Intro para salir): ");
            respuesta = Console.ReadLine();
            
            if (respuesta != "")
            {
                numeros[cantidad] = Convert.ToInt32( respuesta );
                cantidad++;
            }
        }
        while (respuesta != "");
        
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(numeros[i] + " ");
        }
    }
}

/*
Dime un número (Intro para salir): 10
Dime un número (Intro para salir): 20
Dime un número (Intro para salir): 40
Dime un número (Intro para salir): 30
Dime un número (Intro para salir):
10 20 40 30
*/
