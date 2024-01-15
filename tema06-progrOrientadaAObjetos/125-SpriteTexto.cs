/*125. Crea una clase llamada "SpriteTexto", que representará una supuesta 
imagen de un juego en modo de consola. Sus atributos (públicos) serán las 
coordenadas x e y (números enteros) y el carácter que represente esa supuesta 
imagen. Tendrá un método (void) llamado "Dibujar", que mostrará ese carácter en 
la pantalla, en las coordenadas indicadas por sus atributos (puedes ayudarte de 
Console.SetCursorPosition para conseguir que el texto aparezca realmente en 
esas coordenadas). Crea una clase "PruebaDeSprite" (en el mismo fichero 
fuente), que tendrá un "Main" para probar la clase "SpriteTexto", creando una 
supuesta nave espacial formada por el carácter "A", en las coordenadas (40, 12) 
y que habrá de mostrarse. Deberás entregar sólo el fichero ".cs".*/

//Noelia (...)

using System;

class SpriteTexto
{
    public int x, y;
    public char caracter;
    
    public void Dibujar()
    {
        Console.SetCursorPosition(x,y);
        Console.Write(caracter);
    }
}

class PruebadeSprite
{
    static void Main()
    {
        SpriteTexto nave = new SpriteTexto();
        
        nave.x = 40;
        nave.y = 12;
        nave.caracter = 'A';
        
        nave.Dibujar();
    }
}



