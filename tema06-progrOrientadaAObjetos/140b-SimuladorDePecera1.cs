/*
140. Crea una nueva versión de la clase "Pez" (ejercicio 106), que incluya un 
constructor que prefije su nombre y su especie. También tendrá dos atributos x 
e y, que indiquen su posición en pantalla, para los cuales habrá getters y 
setters, y que se podrán fijar también desde un segundo constructor que dé 
valor a todos los atributos. Al tratarse de un simulador en modo texto, los 
atributos x e y serán internamente de tipo "byte", si bien su "getter" 
devolverá un número entero, y su "setter" recibirá un número entero (y lo mismo 
ocurrirá con el constructor). Habrá un método "Dibujar", que muestre un 
supuesto pez en pantalla (por ejemplo, "><=>"), en esas coordenadas x e y. El 
método "Nadar" incrementará la coordenada x. Añade un destructor que escriba 
"Aquí acabó la vida del pez". El programa de prueba creará un pez en las 
coordenadas 15, 15, y lo hará nadar (y lo dibujará) cada vez que se pulse una 
tecla, terminando la ejecución cuando esa tecla sea ESC.
*/

// Mario (...)

using System;

// ---------------

class Pez
{
    protected string nombre, especie;
    protected byte x, y;

    public string GetNombre() { return nombre; }
    public string GetEspecie() { return especie; }
    public int GetX() { return Convert.ToInt32(x); }
    public int GetY() { return Convert.ToInt32(y); }


    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetEspecie(string nuevaEspecie) { especie = nuevaEspecie; }
    public void SetX(int nuevaX) { x = (byte) nuevaX; }
    public void SetY(int nuevaY) { y = (byte) nuevaY; }

    public Pez()
    {
        nombre = "Pepe";
        especie = "salmon";
    }

    public Pez(string nuevoNombre, string nuevaEspecie, int nuevaX, int nuevaY)
    {
        nombre = nuevoNombre;
        especie = nuevaEspecie;
        x = (byte)nuevaX;
        y = (byte)nuevaY;
    }

    public void Nadar()
    {
        x++;
    }

    public void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("><(((º>");
    }

    ~Pez()
    {
        Console.Write("Aquí acabó la vida del pez");
    }
}

// ---------------

class SimuladorDePecera
{
    static void Main()
    {
        Pez pescado = new Pez("Juan", "sardina", 15, 15);

        bool salir = false;
        do
        {
            // Dibujado de pantalla
            Console.Clear();
            pescado.Dibujar();

            // Comprobación de teclas
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
            
            // Movimiento de elementos
            pescado.Nadar();
        }
        while (!salir);
    }
}
