/*
134. Implementa las clases que has diseñado en tu diagrama. Todavía no habrá 
detalles avanzados que veremos más adelante, como herencias o agregaciones. 
Aparecerán los nombres de los métodos, pero éstos estarán vacíos. Deberás 
entregar todo el proyecto de Visual Studio, que debe compilar correctamente 
aunque "no haga nada útil".
*/

class Juego
{
    static void Main()
    {
        Bienvenida bienvenida = new Bienvenida();
        Partida partida = new Partida(); 
        Bloque bloque = new Bloque();
        Pantalla pantalla = new Pantalla();
        Marcador marcador= new Marcador();
        Nivel nivel = new Nivel();
    }
}

class Bienvenida
{
    public void MostrarPuntuacion() { }
}

class Bloque
{
    private int colorCuadrado1;
    private int colorCuadrado2;
    private int colorCuadrado3;

    public int GetcolorCuadrado1() { return colorCuadrado1;  }
    public int GetcolorCuadrado2() { return colorCuadrado2; }
    public int GetcolorCuadrado3() { return colorCuadrado3; }

    public void setNuevoColorCuadrado1(int nuevoColor1) { colorCuadrado1 = nuevoColor1; }
    public void setNuevoColorCuadrado2(int nuevoColor2) { colorCuadrado2 = nuevoColor2; }
    public void setNuevoColorCuadrado3(int nuevoColor3) { colorCuadrado3 = nuevoColor3; }

    public void Mover() { }

    public void MoverIzquierda() { }
    public void MoverDerecha() { }
    public void MoverAbajo() { }

    public void DibujarBloque(int colorCuadrado1, int colorCuadrado2, int colorCuadrado3)
    { 
    
    }
}

class Marcador
{
    public void MostrarMarcador() { }
}

class Nivel
{
    public void MostrarNivel() { }
}

class Pantalla
{
    private int coordenadasX;
    private int coordenadasY;

    public int GetCoordenadasx() { return coordenadasX; }
    public int GetCoordenadasy() { return coordenadasY; }

    public void SetNuevasCoordenadasX (int nuevaX) { coordenadasX = nuevaX; }
    public void SetNuevasCoordenadasY(int nuevaY) { coordenadasY = nuevaY; }
}

class Partida
{
    public void Lanzar() { }
    public void Finalizar() { }
}

