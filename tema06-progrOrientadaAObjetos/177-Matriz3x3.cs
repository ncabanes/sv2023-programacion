/*
154. Crea una clase "Matriz3x3", que representará una matriz de números reales,
con 3 filas y 3 columnas. Debe contener los siguientes métodos:

- Un constructor que reciba los tres valores de cada fila: Matriz3x3(f1a, f1b, 
f1c, f2a, f2b, f2c, f3a, f3b, f3c)

- Un segundo constructor sin argumentos, que establezca todos los valores a 0

- Multiplicar( n ), que multiplicará todos los elementos por un cierto valor.

- Sumar(m2) que sume una segunda matriz elemento a elemento.

- Debes sobrecargar el operador suma, para que también se puedan sumar "de manera
natural".

- ToString, que devolverá una cadena parecida a "  2   -7   5\n  -3   4   2\n  0 
6   -1".

- Mostrar, que escribirá la matriz en pantalla.

Deberá haber un getter con el formato Get(fila, columna) y un setter con el 
formato Set(fila, columna, valor)

El programa de prueba debe crear pedir al usuario de dos matrices A y B, 
multiplicar la segunda por dos, sumar A y B en un nueva matriz C y mostrar las 
tres matrices en pantalla, separadas por sendas líneas en blanco.
*/

using System;

class PruebaMatriz3x3
{
    static void Main()
    {
        Matriz3x3 m1 = new Matriz3x3(
            1, 1, 2, 
            3, 1, 2, 
            3, 1, 1);
        Matriz3x3 m2 = new Matriz3x3(
            0, 3, 1, 
            2, 0, 5, 
            1, 3, 0);

        Console.WriteLine("Primera matriz:");
        m1.Mostrar();
        Console.WriteLine("Segunda matriz:");
        m2.Mostrar();

        Console.WriteLine("Segunda matriz por 2:");
        m2.Multiplicar(2);
        m2.Mostrar();

        Console.WriteLine("Suma de ambas:");
        Matriz3x3 m3 = m1 + m2;
        Console.WriteLine(m3);
    }
}


class Matriz3x3
{
    public int[,] matriz = new int[3,3];

    public Matriz3x3(int f11, int f12, int f13, int f21, int f22, int f23,
                     int f31, int f32, int f33)
    {
        matriz[0, 0] = f11;
        matriz[0, 1] = f12;
        matriz[0, 2] = f13;
        matriz[1, 0] = f21;
        matriz[1, 1] = f22;
        matriz[1, 2] = f23;
        matriz[2, 0] = f31;
        matriz[2, 1] = f32;
        matriz[2, 2] = f33;
    }

    public Matriz3x3() : this(0,0,0,0,0,0,0,0,0)
    {

    }

    public int Get(byte fila, byte col)
    {
        return matriz[fila, col];
    }

    public void Set(byte fila, byte col, int valor)
    {
        matriz[fila, col] = valor;
    }

    public void Multiplicar(int n)
    {
        for (int fila = 0; fila < 3; fila++)       
            for (int col = 0; col < 3; col++)           
                matriz[fila,col] *= n;                  
    }

    public void Sumar(Matriz3x3 m2)
    {
        for (int fila = 0; fila < 3; fila++)
            for (int col = 0; col < 3; col++)
                matriz[fila, col] += m2.matriz[fila,col];
    }

    public static Matriz3x3 operator +(Matriz3x3 m1, Matriz3x3 m2)
    {
        Matriz3x3 m3 = new Matriz3x3();
        for (int fila = 0; fila < 3; fila++)
            for (int col = 0; col < 3; col++)
                m3.matriz[fila, col] = m1.matriz[fila, col] 
                    + m2.matriz[fila, col];
        return m3;
    }

    public override string ToString()
    {
        string cadena = "";
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
                cadena += matriz[fila, col] + "  ";
            cadena += "\n";
        }
        return cadena;
    }

    public void Mostrar()
    {
        Console.WriteLine(this);
    }
}
