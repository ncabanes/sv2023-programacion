// Programa que muestra un triángulo creciente alineado a la derecha
// Uso de for anidados
// Miguel Ángel (...)

using System;

class Ejercicio042
{
    static void Main()
    {
        int altura;
        int almohadillas = 1;
        int espacios; 
        
        Console.Write("Dame un tamaño para el triángulo: ");
        altura = Convert.ToInt32(Console.ReadLine());
        
        
        for (int fila=1; fila <= altura; fila++)
        {        
            espacios = altura - almohadillas;
            
            for (int columna=1; columna <= espacios; columna++)
            {
                Console.Write(" ");
            }
            for (int columna=1; columna <= almohadillas; columna++)
            {
                Console.Write("#");
            }
            almohadillas ++;
            Console.WriteLine();
        }
    }
    
}
