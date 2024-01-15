/*
Figuritas intocables
Nuestro amigo Maniatiquez tiene una extraña afición. Resulta que tiene un patio
de baldosas cuadradas de N (Ancho) por M (largo) baldosas. En cada una de esas
baldosas él puede o no poner una figura decorativa de animales. Pero nuestro
amigo impone una serie de restricciones para poner dichas figuras. Las figuras
no pueden estar tocando ninguno de los bordes de su patio. Además, las figuras
no pueden tener una figura en alguna baldosa contigua en cualquiera de las 8
direcciones posibles (Vertical, horizontal y diagonal). Tampoco será válida una
configuración que no tenga ninguna figura.

Nuestra tarea es realizar un programa que indique si una propuesta de
colocación de figuras es válida para nuestro amigo Maniatiquez.

Entrada

En la primera línea un entero C indicando el número de casos de prueba. Cada
caso de prueba tendrá una línea que indicará las dimensiones del patio de N
por M.
1 <= C <= 100
3 <= N <= 15
3 <= M <= 15
En las restantes M lineas, se representará el estado del patio. Cada baldosa
vacía se representará por una letra X. Cada figura colocada, se representará
mediante una letra F.

Salida

Por cada juego de prueba, se escribirá VALIDA si la configuración es válida, o
INVALIDA en caso contrario.

Ejemplo de entrada

5
4 4
XXXX
XXXX
XXXX
XXXX
3 3
XXX
XFX
XXX
3 3
XXX
FXX
XXX
4 3
XXXX
FXFX
XXXX
6 6
XXXXXX
XFXXFX
XXXXXX
XFXFXX
XXXXXX
XXXXXX

Ejemplo de salida

INVALIDA
VALIDA
INVALIDA
INVALIDA
VALIDA
Origen: ProgramaMe Regional Online 2014 - IES Serra Perenxisa (Torrent) -
Problema E
*/

// Mario (...)

using System;

class Reto10FigurasIntocables
{
    static void Main()
    {
        bool intocable;
        byte c = Convert.ToByte(Console.ReadLine());
        char[,] baldosas;

        for (byte i = 0; i < c; i++)
        {
            intocable = true;
            byte encontrado = 0;
            string[] patio = Console.ReadLine().Split();

            byte ancho = Convert.ToByte(patio[0]);
            byte largo = Convert.ToByte(patio[1]);

            baldosas = new char[largo, ancho];

            for (byte j = 0; j < largo; j++)
            {
                string entrada = Console.ReadLine();

                for (byte k = 0; k < ancho; k++)
                {
                    baldosas[j,k] = entrada[k];
                }
            }

            byte fila = 0;
            while (fila < largo && intocable)
            {
                byte columna = 0;
                while (columna < ancho && intocable)
                {
                    // Comprobamos que las figuras no esten en el borde
                    if (baldosas[0,columna]=='F' || baldosas[fila,0]=='F' ||
                        baldosas[largo-1,columna]=='F' || baldosas[fila,ancho-1]=='F')
                    {
                        intocable = false;
                    }
                    // Comprobamos que ninguna figura "toque" a otra
                    else if (baldosas[fila,columna] == 'F')
                    {
                        if (baldosas[fila, columna+1] == 'F' ||
                            baldosas[fila+1, columna-1] == 'F' ||
                            baldosas[fila+1, columna] == 'F' ||
                            baldosas[fila+1, columna+1] == 'F')
                        {
                            intocable = false;
                        }
                        encontrado++;
                    }
                    columna++;
                }
                fila++;
            }

            if (intocable && encontrado != 0)
            {
                Console.WriteLine("VALIDA");
            }
            else
            {
                Console.WriteLine("INVALIDA");
            }
        }
    }
}
