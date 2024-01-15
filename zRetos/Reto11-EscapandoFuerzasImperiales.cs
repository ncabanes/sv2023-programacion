/* Escapando de las fuerzas imperiales

Nuestros héroes, a bordo del Halcón Milenario y confiando en la pericia de Han 
Solo, están intentado escapar de las fuerzas rebeldes. Para despistar a las 
fuerzas imperiales, Han Solo quiere introducirse en un campo de asteroides.

Pero antes de tan arriesgada maniobra quiere saber si, una vez dentro, podrán 
salir de él o es mejor buscar una alternativa más prudente.

El campo de asteroides es una cuadrícula en el que el Halcón Milenario puede 
moverse en horizontal y en vertical, pero no en diagonal. Las casillas pueden 
ser transitables, o estar ocupadas por asteroides inmóviles.

Entrada

En primer lugar, la cantidad de casos de prueba.

Cada caso de prueba comienza con una pareja de números 1 ≤ F,C ≤ 20 indicando, 
respectivamente, el número de filas y columnas de la cuadrícula que representa 
el campo de asteroides.

A continuación irán F líneas, cada una con C caracteres. Un asterisco ('*') 
indica una celda con asteroide, y un punto ('.') indica una celda transitable. 
El Halcón Milenario entra al campo de asteroides en la celda identificada con 
la letra S, y necesita salir de él en la celda F. En el mapa, existirá una y 
solo una de cada una de esas letras y sus celdas deben considerarse 
transitables.

Ten en cuenta que, gracias al hiperespacio, las celdas S y F pueden estar en 
cualquier posición, no únicamente en los extremos.

Salida

Por cada caso de prueba el programa escribirá ""SI"" si es viable que el Halcón 
Milenario se adentre en el campo de asteroides porque hay al menos un camino 
desde el punto S al punto F siguiendo las reglas de movimiento de la nave. En 
otro caso, el programa escribirá ""NO"".


Entrada de ejemplo

3
2 2
SF
..
2 3
S*F
*..
3 3
.S.
**.
F..

Salida de ejemplo

SI
NO
SI

Origen: ProgramaMe 2016, Concurso de Navidad 6 - Escapando de las fuerzas 
imperiales (ligeramente modificado)*/

// Miguel Angel (...)

using System;

class EscapandoFuerzasImperiales
{
    static void Main()
    {
        byte casos = 1, numFilas, numColumnas, filaInicio = 0, columnaInicio = 0;
        string dimension;
        string patronLinea;
        char[,] mapa;
        bool esViable;
        casos = Convert.ToByte(Console.ReadLine());
        for (int i = 1; i <= casos; i ++)
        {
            dimension = Console.ReadLine();
            numFilas = Convert.ToByte(dimension.Split()[0]);
            numColumnas = Convert.ToByte(dimension.Split()[1]);
            mapa = new char[numFilas,numColumnas];
            for (byte j = 0; j < numFilas; j ++)
            {
                patronLinea = Console.ReadLine();
                for (byte k = 0; k < numColumnas; k ++)
                {
                    mapa[j,k] = patronLinea[k];
                    
                    if (mapa[j, k] == 'S')
                    {
                        filaInicio = j;
                        columnaInicio = k;
                    }
                }
                
            }
            esViable = false;
            ComprobarViable(mapa, filaInicio, columnaInicio, ref esViable);
            if (esViable)
            {
                Console.WriteLine("SI");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
    
    static char[,] clonar(char[,] mapa)
    {
        char[,] nuevo = new char[mapa.GetLength(0),mapa.GetLength(1)];
        for (byte i = 0; i < mapa.GetLength(0); i++)
        {
            for (byte j = 0; j < mapa.GetLength(1); j++)
            {
                nuevo[i,j] = mapa[i,j];
            }
        }
        return nuevo;
    }
    
    static void ComprobarViable(char[,] mapa, byte fila, byte columna, ref bool esViable)
    {   
        if (mapa[fila,columna] == 'F')
        {
            esViable = true;
        }
        else if (mapa[fila,columna] != '*' && mapa[fila,columna] != 'x')
        {
            mapa[fila, columna] = 'x';
            
            if (fila > 0)
            {
                ComprobarViable(clonar(mapa), (byte) (fila - 1), columna, ref esViable);
            }
            if (fila < mapa.GetLength(0) - 1)
            {
                ComprobarViable(clonar(mapa), (byte) (fila + 1), columna, ref esViable);
            }
            if (columna > 0)
            {
                ComprobarViable(clonar(mapa), fila, (byte) (columna - 1), ref esViable);
            }
            if (columna < mapa.GetLength(1) - 1)
            {
                ComprobarViable(clonar(mapa), fila, (byte) (columna + 1), ref esViable);
            }
        }
    }
}
