/*
 179. Amplía el ejercicio anterior con:

- Una clase Punto2D, cuyo único constructor sólo aceptará X e Y (y fijará Z a 0).

- Un array de 4 puntos, cuyos datos pedirás al usuario. 
Los tres primeros serán Punto3D y el último será un Punto2D.

- Finalmente, calcularás (y mostrarás) la distancia del primer punto a los 3 restantes,
e  informarás al usuario de cuál es el punto más cercano.

 */

// julio

using System;


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

    public virtual bool Contiene(double distancia)
    {
        return false;
    }
}


class Punto2D : Punto3D
{
    public Punto2D(double x, double y) : base(x, y, 0) { }
    
    public override string ToString()
    {
        return "(" + X + ", " + Y + ")";
    }
}


class PruebaPunto2D
{
    static void Main(string[] args)
    {
        Punto3D[] puntos = new Punto3D[4];

        Console.WriteLine("Introduce los puntos");

        for (int i = 0; i < 4; i++)
        {
            Console.Write((i + 1) + "X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write((i + 1) + "Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (i != 3)
            {
                Console.Write((i + 1) + "Z: ");
                double z = Convert.ToDouble(Console.ReadLine());
                puntos[i] = new Punto3D(x, y, z);
            }
            else
            {
                puntos[i] = new Punto2D(x, y);
            }
        }

        double menorDistancia = puntos[0].DistanciaA(puntos[1]);
        int indicePuntoMasCercano = 1;


        for (int i = 1; i < 4; i++)
        {

            double distancia = puntos[0].DistanciaA(puntos[i]);

            Console.WriteLine("Distantia del " + puntos[0] + "  al punto " + puntos[i] + " = " + puntos[0].DistanciaA(puntos[i]));

            if (distancia < menorDistancia)
            {
                menorDistancia = distancia;
                indicePuntoMasCercano = i;
            }
        }

        Console.WriteLine("Punto mas cercano " + puntos[indicePuntoMasCercano]);
    }
}
