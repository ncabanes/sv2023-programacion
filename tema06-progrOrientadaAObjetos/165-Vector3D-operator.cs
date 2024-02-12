/* 158.Crea una clase Vector3D que represente un vector en el espacio 
tridimensional (con coordenadas X, Y, Z). Debe tener:  -Un
constructor, que permita dar valores de X, Y, Z.  - Setters y getters 
en formato convencional.  - Un método "ToString", que devolvería algo 
como "<2, -3, 0.5>"  - Un método "GetModulo" para devolver la longitud 
(módulo) del vector (raíz cuadrada de x^2 + y^2 + z^2)  - Un método 
"Sumar", para sumar un vector (que se pasará como parámetro) al actual 
(el resultado será la suma componente a componente: < x1 + x2, y1 + y2, 
z1 + z2 >)  Crea un programa de prueba, que permita probar estas 
funcionalidades.

165. Crea una nueva versión de la clase Vector3D (ejercicio 158), con los 
siguientes cambios:

En vez de usar getters y setters convencionales, utiliza propiedades en 
formato compacto.
Sobrecarga el operador "+", de modo que se pueda sumar dos vectores usando 
dicho operador.
 
 */

// Mario (...), retoques por Nacho

using System;

class Vector3D
{
    public int X {  get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Vector3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return "<" + X + "," + Y + "," + Z + ">";
    }

    public double GetModulo()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public void Sumar(Vector3D v2)
    {
        X += v2.X;
        Y += v2.Y;
        Z += v2.Z;
    }
    
    public static Vector3D operator +(Vector3D v1, Vector3D v2)
    {
        return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }
}


class PruebaVector3D
{
    static void Main()
    {
        Vector3D[] vector = new Vector3D[2];
        vector[0] = new Vector3D(3, 2, 6);
        vector[1] = new Vector3D(5, 3, 1);

        Console.WriteLine("v1 es: " + vector[0]);
        Console.WriteLine("La longitud de v1 es: " + vector[0].GetModulo());

        Console.WriteLine("v2 es: " + vector[1]);

        vector[0].Sumar(vector[1]);
        Console.WriteLine("La suma de ambos es: " + vector[0]);
        
        Console.WriteLine("Y si volvemos a sumar el segundo: " + 
            (vector[0] + vector[1]) );
    }
}
