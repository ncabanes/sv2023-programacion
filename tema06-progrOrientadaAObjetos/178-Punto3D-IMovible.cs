/*
 178. Crea una interfaz IMovible, con un método "MoverA (double x, 
 double y, double z)".
Crea una clase "Punto3D", que representará un punto en el espacio 3D, 
con coordenadas (propiedades en formato corto, números reales) X, Y y 
Z. Debe implementar la interfaz IMovible y contener los siguientes 
métodos:

- Un único constructor, que establezca los valores de X, Y y Z

- MoverA (x, y, z), que cambiará las coordenadas en las que se encuentra el punto.

- DistanciaA (Punto3D p2), que permita calcular la distancia a otro punto.
Recuerda: es la raíz cuadrada de (x2-x1)2 + (y2-y1)2 + (z2-z1)2: https://es.wikipedia.org/wiki/Distancia_euclidiana


 */
 
// julio 
 
using System;

class pruebaPunto3D
{
    static void Main()
    {
        Punto3D p1 = new Punto3D(1, 0, -1);
        Console.WriteLine("Punto actual: " + p1);
        Console.WriteLine();

        Console.WriteLine("Introduce nuevas coordenadas: ");
        Console.Write("X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Z: ");
        double z = Convert.ToDouble(Console.ReadLine());

        Punto3D p2 = new Punto3D(x, y, z);
        Console.WriteLine("Distancia = " + p1.DistanciaA(p2));
        
        p1.MoverA(x, y, z);
        Console.WriteLine("Nueva ubicacion: " + p1);
        Console.WriteLine("Nueva distancia = " + p1.DistanciaA(p2));
    }
}

interface IMovible
{
    void MoverA(double x, double y, double z);
}

class Punto3D : IMovible
{
    public Punto3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }



    public double DistanciaA(Punto3D p2)
    {
        return Math.Sqrt( 
            Math.Pow(X - p2.X, 2) + 
            Math.Pow(Y - p2.Y, 2) + 
            Math.Pow(Z - p2.Z, 2));
    }
    
    public override string ToString()
    {
        return "(" + X + ", " + Y + ", " + Z + ")";
    }

    public void MoverA(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

}

