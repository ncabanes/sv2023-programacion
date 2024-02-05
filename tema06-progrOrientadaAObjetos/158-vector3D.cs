/* 158.Crea una clase Vector3D que represente un vector en el espacio 
tridimensional (con coordenadas X, Y, Z). Debe tener:  -Un
constructor, que permita dar valores de X, Y, Z.  - Setters y getters 
en formato convencional.  - Un método "ToString", que devolvería algo 
como "<2, -3, 0.5>"  - Un método "GetModulo" para devolver la longitud 
(módulo) del vector (raíz cuadrada de x^2 + y^2 + z^2)  - Un método 
"Sumar", para sumar un vector (que se pasará como parámetro) al actual 
(el resultado será la suma componente a componente: < x1 + x2, y1 + y2, 
z1 + z2 >)  Crea un programa de prueba, que permita probar estas 
funcionalidades.*/

//Javier (...); retoques menores por Nacho

using System;

class Vector3D
{
    protected int x, y, z;

    public void setX(int x) { this.x = x; }
    public void setY(int y) { this.y = y; }
    public  void setZ(int z) { this.z = z; }

    public int getX() { return x; }
    public int getY() { return y; }  
    public int getZ() { return z; }

    public Vector3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return "<"+x+","+y+","+z+">";
    }

    public double GetModulo()
    { 
        return Math.Sqrt(x * x + y * y + z * z);
    }

    public void Sumar(Vector3D v2)
    {
        this.x += v2.x;
        this.y += v2.y;
        this.z += v2.z;
    }


    class PruebaVector3D
    {
        static void Main()
        {
            Vector3D[] vector = new Vector3D[2];
            vector[0] = new Vector3D(3, 2, 6);
            vector[1] = new Vector3D(5, 3, 1);

            Console.WriteLine("v1 es: " + vector[0]);
            Console.WriteLine("La longitud de v1 es: "+vector[0].GetModulo());

            Console.WriteLine("v2 es: " + vector[1]);
            vector[0].Sumar( vector[1] );
            Console.WriteLine("La suma de ambos es: " + vector[0]);
        }
    }
}
