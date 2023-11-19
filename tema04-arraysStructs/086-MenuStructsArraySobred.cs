/*86. Crea una versión mejorada del ejercicio anterior, que no reservará espacio
 * sólo para 3 datos, sino para 1000 (un "array sobredimensionado"), y 
 * mostrará un menú que permita al usuario añadir un nuevo dato, 
 * ver todos los existentes o salir.
 */
 
 //Noelia (...)

using System;

class Ejercicio086
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
        const byte SALIR = 0, ANYADIR = 1, VER = 2 ;
        const int MAXIMO = 1000;
        tipoJuego[] juegos = new tipoJuego[MAXIMO];
        byte opcion;
        int cantidad = 0;
        bool salir = false;
        

        Console.WriteLine("--BIBLIOTECA DE JUEGOS--");
        Console.WriteLine();

        do 
        {
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine(ANYADIR + ". Añadir un nuevo dato");
            Console.WriteLine(VER + ". Ver todos los datos");
            Console.WriteLine(SALIR + ". Salir");
  
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            
            switch (opcion)
            {
                case ANYADIR:
                    if (cantidad < MAXIMO)
                    {
                        Console.Write("Título del juego: ");
                        juegos[cantidad].titulo = Console.ReadLine();
                    
                        Console.Write("Plataforma del juego: ");
                        juegos[cantidad].plataforma = Console.ReadLine();
                    
                        Console.Write("Espacio ocupado (MB): ");
                        juegos[cantidad].espacioMB = Convert.ToInt64(Console.ReadLine());
                    
                        Console.WriteLine("Fecha de lanzamiento");
                        Console.Write("Mes: ");
                        juegos[cantidad].fecha.mes = Convert.ToByte(Console.ReadLine());
                        Console.Write("Año: ");
                        juegos[cantidad].fecha.anyo = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine();
                        
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("No caben más juegos");
                    }
                    Console.WriteLine();
                    break;
                    
                    
                case VER:
                    if (cantidad > 0)
                    {
                        for (int i =0; i < cantidad; i++)
                        {
                            Console.WriteLine("Título del juego: " + juegos[i].titulo);
                            Console.WriteLine("Plataforma del juego: " + juegos[i].plataforma);
                            Console.WriteLine("Espacio ocupado (MB): " + juegos[i].espacioMB);
                            Console.WriteLine("Fecha de lanzamiento: " + 
                            juegos[i].fecha.mes + ("/") + juegos[i].fecha.anyo);
                        }
                    }
                    else Console.WriteLine("No hay juegos para mostrar"); 
                    break;
                    
                case SALIR:
                    salir = true;
                    break;
                    
                default:
                    Console.WriteLine("Opción no válida");
                    break;    
            }
        }
        while (!salir);
    }
}
