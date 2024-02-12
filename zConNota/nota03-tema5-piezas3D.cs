/*
Tercer ejercicio con nota (tema 5)

Una empresa que realiza piezas en 3D nos ha pedido crear un programa en C# que 
les permita almacenar hasta 1000 fichas de posibles diseños para sus clientes. 
Para cada pieza, se debe guardar los siguientes datos:

Nombre (por ejemplo, Dado24)
Tiempo (p.ej. 12, se refiere al tiempo de impresión en minutos)
Precio (p.ej. 4.5)
Detalles (un texto libre, por ejemplo "Dado de 24 lados con el número de cada 
lado en relieve")
El programa debe permitir al usuario las siguientes operaciones:

1 - Añadir un diseño. El nombre no debe estar vacío.

2 - Mostrar todos los diseños almacenados. Cada diseño debe aparecer en una 
línea, en formato de nombre, tiempo, precio y detalles; separados por un guion 
(por ejemplo, "1 - Dado24 - 12 minutos - 4.5 euros - Dado de 24 lados (...)."). 
El programa debe hacer una pausa después de mostrar cada bloque de 24 diseños, 
mostrar el mensaje "Pulse Intro para continuar" y esperar hasta que el usuario 
pulse Intro. Se debe avisar al usuario si no hay datos.

3 - Buscar diseños que contengan un determinado texto (como parte de su nombre 
o de sus detalles, sin distinción de mayúsculas y minúsculas). Los datos se 
deben mostrar en líneas separadas, con una línea en blanco adicional después de 
cada detalle. Se debe avisar al usuario si no se encuentra ninguno.

4 - Modificar un registro (el programa solicitará el número, mostrará el valor 
anterior de cada campo y el usuario podrá pulsar Intro para no modificar alguno 
de los datos). Se debe advertir al usuario (pero no volver a preguntarle) si 
introduce un número de registro incorrecto.

5 - Borrar un registro, en la posición indicada por el usuario. Se le debe 
avisar (pero no volver a preguntarle) si introduce un número de registro 
incorrecto. Se debe mostrar el dato que se va a borrar y pedir confirmación.

6 - Ordenar los datos alfabéticamente por nombre + precio.

7 - Eliminar espacios sobrantes (espacios iniciales, finales y duplicados en 
todos los nombres y detalles. Por ejemplo, un detalle como "  Datos   de prueba  
" se convertirá en "Datos de prueba").

S - Salir (como esta versión preliminar del proyecto no almacena la 
información, se perderá).

-------------

El programa, en su manejo normal, devolverá un código de salida 0 al sistema 
operativo. Pero también se podrá lanzar indicando en línea de comandos un 
parámetro como "/max:100"; en ese caso, se limitará el tamaño máximo del array 
a 100 datos (o a la cantidad que se especifique después de "/max:"), y se 
devolverá el código 1 al sistema operativo cuando termine la ejecución del 
programa. Si se indica un parámetro que no sea "/max", se mostrará un mensaje 
de aviso que diga "Única opción aceptable: /max:n" y se volverá al sistema 
operativo inmediatamente, con el código 2.

Cada opción del menú principal (excepto Salir) DEBE estar extraída a una 
función, llamadas: Anyadir, MostrarTodos, Buscar, Modificar, Borrar, Ordenar, 
EliminarEspaciosSobrantes.

Por lo general, cada una de estas funciones deberá recibir como parámetros el 
array con los datos y el contador de cuántos datos hay almacenados (quizá como 
parámetro "ref", en los casos en que puede cambiar en el cuerpo de esa 
función), de modo que no existan variables globales, sino variables locales y 
datos pasados como parámetros.

Además, DEBES crear las siguientes funciones:

// Para simplificar el "Añadir"; será un WriteLine seguido de un ReadLine
string Pedir(string aviso) 

// Para simplificar el "Añadir" en el caso de datos que no deban estar vacíos
// Se encargará de pedir tantas veces como sea necesario
string PedirNoVacio(string aviso) 

// Para simplificar el "Modificar": pedirá el nuevo valor, y 
// conservará el anterior si se introduce una cadena vacía
string ModificarUnCampo(string nombreCampo, string valorAnterior)

// Para simplificar la opción de buscar: devolverá true si un
// cierto diseño contiene un cierto dato
bool Contiene(Disenyo v, string texto)

// Para simplificar la opción de buscar y la de eliminar
void MostrarUnDato(Disenyo[] datos, int pos)

También puedes crear las funciones adicionales que consideres convenientes, 
donde veas que tienes tareas repetitivas (por ejemplo, es recomendable crear 
una que elimine los espacios sobrantes de una cadena, para simplificar la 
opción 7; también puedes crear una que muestre los datos de un diseño en una 
misma línea, para simplificar la opción 2 del menú).
*/


using System;

class GestionDisenyos3D
{
    struct TipoDisenyo
    {
        public string nombre;
        public int tiempo;
        public double precio;
        public string detalles;
    }
    
    static int Main(string[] args)
    {
        const string ANYADIR = "1", MOSTRAR = "2", BUSCAR = "3", 
            MODIFICAR = "4", BORRAR = "5", ORDENAR = "6", 
            ELIMINARESPACIOS = "7", SALIR = "S";
        int codigoSalida = 0; 
        bool salir = false;
        int capacidad = 1000;
        
        if (args.Length == 1)
        {
            string[] fragmentosOpcion1 = args[0].Split(':');
            if (fragmentosOpcion1[0] == "/max")
            {
                capacidad = Convert.ToInt32(fragmentosOpcion1[1]);
                codigoSalida = 1;
            }
            else
            {
                Console.WriteLine("Única opción aceptable: /max:n");
                codigoSalida = 2;
                salir = true;
            }
        }
        
        TipoDisenyo[] datos = new TipoDisenyo[capacidad];
        int cantidad = 0;
        
        while(!salir)
        {
            Console.WriteLine("---OPCIONES---");
            Console.WriteLine(ANYADIR + ". Añadir un diseño");
            Console.WriteLine(MOSTRAR + ". Mostrar todos los diseños");
            Console.WriteLine(BUSCAR + ". Buscar diseños");
            Console.WriteLine(MODIFICAR + ". Modificar un diseño");
            Console.WriteLine(BORRAR + ". Borrar un diseño");
            Console.WriteLine(ORDENAR + ". Ordenar los diseños");
            Console.WriteLine(ELIMINARESPACIOS + ". Eliminar espacios sobrantes");
            Console.WriteLine(SALIR + ". Salir");
            Console.WriteLine();
            
            string opcion = Console.ReadLine().ToUpper();
            
            switch(opcion)
            {
                case "1":
                    Anyadir(datos, capacidad, ref cantidad);
                    break;
                    
                case "2":
                    MostrarTodos(datos, cantidad);
                    break;
                    
                case "3":
                    Buscar(datos, cantidad);
                    break;
                    
                case "4":
                    Modificar(datos, cantidad);
                    break;
                    
                case "5":
                    Borrar(datos, ref cantidad);
                    break;
                    
                case "6":
                    Ordenar(datos, cantidad);
                    break;
                    
                case "7":
                    EliminarEspaciosSobrantes(ref datos, cantidad);
                    break;
                    
                case "S":
                    Console.WriteLine("Hasta pronto.");
                    salir = true;
                    break;
                    
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine();
        }
        
        return codigoSalida;
    }
    
    // Funciones directas del menú
    
    static void Anyadir(TipoDisenyo[] datos , int capacidad, ref int cantidad)
    {
        if (cantidad < capacidad)
        {
            datos[cantidad].nombre = PedirNoVacio("Nombre: ");
            datos[cantidad].tiempo = Convert.ToInt32(Pedir("Tiempo (minutos): "));
            datos[cantidad].precio = Convert.ToDouble(Pedir("Precio: "));
            datos[cantidad].detalles = Pedir("Detalles: ");
            cantidad++;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más diseños.");
        }
    }
    
    static void MostrarTodos(TipoDisenyo[] datos, int cantidad)
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay diseños almacenados.");
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                MostrarEnUnaLinea(datos, i);
                if ((i + 1) % 24 == 0 && i != cantidad - 1)
                {
                    Console.WriteLine("Pulse Intro para continuar");
                    Console.ReadLine();
                }
            }
        }
    }

    static void Buscar(TipoDisenyo[] datos, int cantidad)
    {
        string texto = Pedir("Texto a buscar: ");

        bool encontrado = false;

        for (int i = 0; i < cantidad; i++)
        {
            if (Contiene(datos[i], texto))
            {
                MostrarUnDato(datos, i);
                Console.WriteLine();
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontraron coincidencias.");
        }
    }

    static void Modificar(TipoDisenyo[] datos, int cantidad)
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay datos almacenados.");
        }
        else
        {
            Console.Write("Introduce el número de registro a modificar: ");
            int numRegistroModif  = Convert.ToInt32(Console.ReadLine());
            
            if (numRegistroModif  > cantidad || numRegistroModif < 1)
            {
                Console.WriteLine("Número de registro no válido.");
            }
            else
            {
                int pos = numRegistroModif - 1;
                Console.WriteLine("(Si no desea modificar un campo pulse INTRO.)");
                datos[pos].nombre = ModificarUnCampo("Nombre", datos[pos].nombre);
                datos[pos].tiempo =
                    Convert.ToInt32(ModificarUnCampo("Tiempo", datos[pos].tiempo.ToString()));
                datos[pos].precio =
                    Convert.ToDouble(ModificarUnCampo("Precio", datos[pos].precio.ToString()));
                datos[pos].detalles = ModificarUnCampo("Detalles", datos[pos].detalles);
            }
        }
    }

    static void Borrar(TipoDisenyo[] datos, ref int cantidad)
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay datos almacenados.");
        }
        else
        {
            Console.Write("Introduce el número de registro a borrar: ");
            int numRegistroBorrar = Convert.ToInt32(Console.ReadLine());
            
            if (numRegistroBorrar > cantidad || numRegistroBorrar < 1)
            {
                Console.WriteLine("Número de registro no válido.");
            }
            else
            {
                int pos = numRegistroBorrar - 1;
                MostrarUnDato(datos, pos);
                
                Console.WriteLine();
                Console.Write("Confirmar borrado? (\"si\" para borrar)");
                string confirmar = Console.ReadLine().ToUpper();
                
                if (confirmar == "SI")
                {
                    for (int i = pos; i < cantidad; i++)
                    {
                        datos[i] = datos[i+1];
                    }
                    cantidad--;
                    
                    Console.WriteLine("Registro borrado.");
                }
            }
        }
    }

    static void Ordenar(TipoDisenyo[] datos, int cantidad)
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay datos almacenados.");
        }
        else
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (datos[i].nombre.ToUpper().CompareTo(
                        datos[j].nombre.ToUpper()) > 0 || 
                            (datos[i].nombre.ToUpper().CompareTo(
                            datos[j].nombre.ToUpper()) == 0 &&
                            datos[i].precio > datos[j].precio))
                    {
                        TipoDisenyo datosTemp = datos[i];
                        datos[i] = datos[j];
                        datos[j] = datosTemp;
                    }
                }
            }
        }
    }

    static void EliminarEspaciosSobrantes(ref TipoDisenyo[] datos, int cantidad)
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay datos almacenados.");
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                datos[i].nombre = EliminarEspacios(datos[i].nombre);
                datos[i].detalles = EliminarEspacios(datos[i].detalles);
            }
            Console.WriteLine("Eliminados espacios sobrantes.");
        }
    }

    // Funciones adicionales

    static string Pedir(string aviso)
    {
        Console.Write(aviso);
        return Console.ReadLine();
    }

    static string PedirNoVacio(string aviso)
    {
        string dato;
        do
        {
            dato = Pedir(aviso);
        }
        while (dato == "");
        return dato;
    }

    static string ModificarUnCampo(string nombreCampo, string valorAnterior)
    {
        Console.Write(nombreCampo + ": (" + valorAnterior + "): ");
        string nuevoValor = Console.ReadLine();
        if (nuevoValor == "")
        {
            return valorAnterior;
        }
        else
        {
            return nuevoValor;
        }
    }

    static bool Contiene(TipoDisenyo v, string texto)
    {
        if (v.nombre.ToLower().Contains(texto.ToLower()) ||
            v.detalles.ToLower().Contains(texto.ToLower()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void MostrarEnUnaLinea(TipoDisenyo[] datos, int pos)
    {
        Console.WriteLine((pos+1) + " - " + datos[pos].nombre + " - " +
            datos[pos].tiempo + " minutos - " + datos[pos].precio + " euros - " + 
            datos[pos].detalles);
    }
    
    static void MostrarUnDato(TipoDisenyo[] datos, int pos)
    {
        Console.WriteLine("Nº: " + (pos+1));
        Console.WriteLine(datos[pos].nombre);
        Console.WriteLine(datos[pos].tiempo + " minutos");
        Console.WriteLine(datos[pos].precio + " euros");
        Console.WriteLine(datos[pos].detalles);
    }

    static string EliminarEspacios(string texto)
    {
        texto = texto.Trim();
        while (texto.Contains("  "))
        {
            texto = texto.Replace("  ", " ");
        }
        return texto;
    }
}
