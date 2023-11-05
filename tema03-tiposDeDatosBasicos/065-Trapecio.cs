/*65.Escribe un programa que pida un ancho y un alto (ambos serán "byte"),
  así como un carácter, y muestre un trapecio creciente como este:

  Introduzca el ancho menor deseado: 5
  Introduzca el alto deseado: 3
  Introduzca el carácter: *
    *****
   *******
  *********
*/

// Jorge (...)

using System;

class Ejercicio05
{
    static void Main()
    {
        byte ancho, alto;
        char caracter;

        Console.Write("Introduzca el ancho menor deseado: ");
        ancho = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduzca el alto deseado: ");
        alto = Convert.ToByte(Console.ReadLine());
        Console.Write("Introduzca el carácter: ");
        caracter = Convert.ToChar(Console.ReadLine());

        byte espacios = (byte) (alto-1);
        byte simbolos = ancho;
     
        for (byte fila = 1 ; fila <= alto; fila++)
        {
            for (byte columna = 1; columna  <=  espacios; columna++)
            {
                Console.Write(' ');
            }
            for (byte columna = 1; columna <= simbolos; columna++)
            {
                Console.Write(caracter); 
            }
            espacios--;
            simbolos += 2;
            Console.WriteLine(' ');
        }

    }
}
