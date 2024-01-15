/*126. Crea una nueva versión de la clase "SpriteTexto". Sus atributos serán 
privados y tendrá "getters" y "setters" que permitan cambiar el valor de éstos. 
Además, tendrá un método "MoverDerecha" que incrementará la X en una unidad y 
otro "MoverIzquierda", que la disminuirá en una unidad. Modifica el programa y 
"Main" según sea necesario. Deberás entregar sólo el fichero ".cs".*/

//Noelia (...)

using System;

class SpriteTexto
{
    private int x, y;
    private char caracter;
    
    public int GetX() { return x; }
    public int GetY() {return y; }
    public int GetCaracter() {return caracter; }
    
    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }
    public void SetCaracter(char nuevoCaracter) { caracter = nuevoCaracter; }
    
    public void Dibujar()
    {
        Console.SetCursorPosition(x,y);
        Console.Write(caracter);
    }
    
    public void MoverDerecha()
    {
        x++;
    }
    
    public void MoverIzquierda()
    {
        x--;
    }
}

class PruebadeSprite
{
    static void Main()
    {
        SpriteTexto nave = new SpriteTexto();
        
        nave.SetX (40);
        nave.SetY (12);
        nave.SetCaracter('A');
    
        nave.MoverDerecha();
        nave.Dibujar();
       
        //nave.MoverIzquierda();
        //nave.Dibujar();
    }
}
