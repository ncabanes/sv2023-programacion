/*85. Vamos a añadir un "struct anidado" al ejercicio anterior:
 *  Crea un "struct" para almacenar algunos datos de juegos de ordenador o consola,
 *  de momento sólo: título (cadena de texto), plataforma (cadena de texto), 
 * espacio ocupado (en MB, número entero) y fecha de lanzamiento (mes y año, 
 * en forma de struct anidado). 
 * Pide al usuario datos de 3 juegos (que serán parte de un array) y luego muéstralos.
 */
 
 //Noelia (...)

using System;

class Ejercicio085
{
    struct fechaLanzamiento
    {
        public byte mes;
        public short anyo;
    }
    
    struct tipoJuego
    {
        public string titulo;
        public string plataforma;
        public long espacioMB;
        public fechaLanzamiento fecha;
    }

    static void Main()
    {
        const int MAXIMO = 3;

        tipoJuego[] juegos = new tipoJuego[MAXIMO];

        Console.WriteLine("--BIBLIOTECA DE JUEGOS--");
        Console.WriteLine();

        for (int i = 0; i < MAXIMO; i++)
        {
            Console.WriteLine("Juego Nº" + (i+1) + ": ");
            Console.Write("Título del juego: ");
            juegos[i].titulo = Console.ReadLine();
            Console.Write("Plataforma del juego: ");
            juegos[i].plataforma = Console.ReadLine();
            Console.Write("Espacio ocupado (MB): ");
            juegos[i].espacioMB = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Fecha de lanzamiento");
            Console.Write("Mes: ");
            juegos[i].fecha.mes = Convert.ToByte(Console.ReadLine());
            Console.Write("Año: ");
            juegos[i].fecha.anyo = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
        }
        Console.WriteLine();
        
        Console.WriteLine("--Listado de juegos--");

        for (int i = 0; i < MAXIMO; i++)
        {
            Console.WriteLine("Juego Nº" + (i+1) + ": ");
            Console.WriteLine("Título del juego: " + juegos[i].titulo);
            Console.WriteLine("Plataforma del juego: " + juegos[i].plataforma);
            Console.WriteLine("Espacio ocupado (MB): " + juegos[i].espacioMB);
            Console.WriteLine("Fecha de lanzamiento: " + 
            juegos[i].fecha.mes + ("/") + juegos[i].fecha.anyo);
            Console.WriteLine();
        }

    }
}
