/* Crea una función DibujarCuadrado. Recibirá el tamaño del lado y, 
opcionalmente, el carácter a utilizar (se tomará un asterisco si no se 
indica otro)

Pruebala desde Main.

*/

using System;

class Cuadrado1a
{
    static void DibujarCuadrado(int lado, char caracter='*')
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

*/
