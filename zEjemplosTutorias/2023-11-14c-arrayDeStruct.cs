/*
Datos de hasta 100 personas. 
Nombre y email para cada una.
Menú que permita:
 - Añadir un nuevo dato
 - Ver todos
 - Salir
*/

using System;

class ArrayDeStruct 
{
    struct tipoPersona
    {
        public string nombre;
        public string email;
    }
        
    static void Main() 
    {
        const int MAXIMO = 100;
        tipoPersona[] personas = new tipoPersona[MAXIMO];
        int cantidad = 0;
        char opcion;
        
        do
        {
            Console.WriteLine("1- Añadir");
            Console.WriteLine("2- Ver");
            Console.WriteLine("S- Salir");
            opcion = Convert.ToChar(Console.ReadLine());
            
            switch(opcion)
            {
                case '1':
                    if (cantidad < MAXIMO)
                    {
                        Console.Write("Nombre? ");
                        personas[cantidad].nombre = Console.ReadLine();
                        Console.Write("Email? ");
                        personas[cantidad].email = Console.ReadLine();
                        cantidad ++;
                    }
                    break;
                    
                case '2':
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0} ({1})",
                            personas[i].nombre, personas[i].email);
                    }
                    break;
            }
        }
        while (opcion != 's' && opcion != 'S');
    }
}

/*
1- Añadir
2- Ver
S- Salir
1
Nombre? uno
Email? uno@uno
1- Añadir
2- Ver
S- Salir
1
Nombre? dos
Email? dos@dos
1- Añadir
2- Ver
S- Salir
2
uno (uno@uno)
dos (dos@dos)
1- Añadir
2- Ver
S- Salir
s
*/
