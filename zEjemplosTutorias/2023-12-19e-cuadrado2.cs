/* Añade una nueva llamada desde Main a la función anterior, con los 
parámetros en otro orden.
*/

using System;

class Cuadrado2 
{
    static void DibujarCuadrado(int lado=5, char caracter='*')
    {
        for (int fila = 0; fila < lado; fila++)
        {
            for (int columna = 0; columna < lado; columna++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
    }
    
    static void Main() 
    {
        DibujarCuadrado(10, '#');
        
        Console.WriteLine();
        DibujarCuadrado(12);
        
        Console.WriteLine();
        DibujarCuadrado();
        
        DibujarCuadrado(caracter: '#', lado: 10);
    }
}

/*
##########
##########
##########
##########
##########
##########
##########
##########
##########
##########

************
************
************
************
************
************
************
************
************
************
************
************

*****
*****
*****
*****
*****
##########
##########
##########
##########
##########
##########
##########
##########
##########
##########
*/
