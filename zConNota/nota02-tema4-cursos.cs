/*
Ejercicio con nota 2 (tema 4) - Noviembre 2023

Vamos a crear un programa en C# para gestionar los cursos de una academia. El
programa estará preparado para que pueda almacenar hasta 5000 cursos. 

Para cada curso, debe permitir al usuario almacenar la siguiente información:

    • Nombre del curso

    • Fecha comienzo (un texto como "2023-11-22")

    • Horas de duración (un número entre 5 y 50, quizá con un cifra decimal,
      como en 12.5)

    • Terminado o no (booleano)



Esta versión mostrará un menú con las opciones:

1. Añadir un curso.

2. Ver cursos no terminados.

3. Marcar un curso como terminado.

4. Buscar entre los cursos existentes.

5. Modificar los datos de un curso.

6. Borrar un curso.

7. Ordenar datos.

S. Salir.

Es decir, debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un nuevo curso (al final de los datos existentes). Ni el nombre ni 
la fecha deben estar vacíos. Si se introduce una cadena vacía para la duración, 
ésta se guardará como 10. No se pedirá si está terminado, sino que se dará por 
sentado que no es así.

2 - Ver cursos no terminados, mirando el correspondiente campo booleano. Debe 
mostrar el número de registro (contando desde 1), el nombre, la fecha y la 
duración, en la misma línea, haciendo una pausa después de cada 22 líneas en 
pantalla.

3 - Marcar un curso como terminado, a partir de su número de registro. Se le 
debe avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto (no existente). Debe mostrar los datos del curso que se va a marcar 
como terminado y solicitar confirmación antes de hacerlo.

4 - Buscar cursos que contengan un determinado texto (búsqueda parcial, en el 
nombre o en la fecha, sin distinción de mayúsculas y minúsculas). Debe mostrar 
el número de registro, el nombre, la fecha de comienzo y la duración, en la 
misma línea, haciendo una pausa después de cada 22 líneas en pantalla.

5 - Modificar un registro: pedirá al usuario su número (por ejemplo, 1 para la 
primera ficha), mostrará el valor anterior de cada campo (por ejemplo, dirá: 
"Nombre anterior: Ejercicios de programación") y permitirá escribir un nuevo 
valor para ese campo, o bien pulsar Intro para dejarlo sin modificar. Se debe 
avisar al usuario (pero no volver a pedir) si introduce un número de registro 
incorrecto. El campo "terminado" no se modificará.

6 - Borrar un registro, en la posición indicada por el usuario. Se le debe 
avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto. Debe mostrar el registro que se va a eliminar y solicitar 
confirmación antes de la eliminación.

7 - Ordenar los datos. Se preguntará al usuario si desea ordenar por nombre del 
curso (alfabéticamente, de la A a la Z) o por fecha (descendente, del curso más 
reciente al más antiguo). En caso de ordenar por fecha, si coincide la fecha de 
2 o más cursos, éstos se ordenarán de menor a mayor cantidad de horas.

S - Salir de la aplicación (como no guardamos la información en fichero, los 
datos se perderán).


El menú deberá repetirse hasta que el usuario escoja la opción "S" (que será 
aceptable tanto en mayúsculas como en minúsculas).


La estructura repetitiva del programa debe ser adecuada, y emplear un booleano 
de control. El fuente debe estar correctamente tabulado y resultar fácil de 
leer.

Debes entregar exclusivamente el fichero ".cs" (no todo el proyecto), sin 
comprimir, que deberá tener un comentario con tu nombre al principio. Haz que 
el nombre del fichero también incluya tu nombre.
*/

using System;

class EjercicioTema4
{
    struct TipoCurso
    {
        public string nombre;
        public string fecha;
        public float duracion;
        public bool terminado;
    }
    
    static void Main()
    {
        const string ANYADIR = "1", VER = "2", MARCAR = "3", BUSCAR = "4", 
            MODIFICAR = "5", BORRAR = "6", ORDENAR = "7", SALIR = "S";
        
        const ushort CAPACIDAD = 5000;
        TipoCurso[] cursos = new TipoCurso[CAPACIDAD];
        string opcion;
        ushort contadorNoTerminados = 0, numDatos = 0;
        bool salir = false;
        
        do
        {
            Console.WriteLine(ANYADIR + ". Añadir un curso.");
            Console.WriteLine(VER + ". Ver cursos no terminados.");
            Console.WriteLine(MARCAR + ". Marcar un curso como terminado.");
            Console.WriteLine(BUSCAR + ". Buscar entre los cursos existentes.");
            Console.WriteLine(MODIFICAR + ". Modificar los datos de un curso.");
            Console.WriteLine(BORRAR + ". Borrar un curso.");
            Console.WriteLine(ORDENAR + ". Ordenar datos.");
            Console.WriteLine(SALIR + ". Salir.");
            Console.WriteLine();
            Console.Write("Escoge una opción: ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            switch (opcion)
            {
                case ANYADIR:
                    if (CAPACIDAD == numDatos)
                    {
                        Console.WriteLine("El array está lleno.");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Nombre: ");
                            cursos[numDatos].nombre = Console.ReadLine();
                            if (cursos[numDatos].nombre == "")
                            {
                                Console.WriteLine("Debe introducir un nombre.");
                            }
                        }
                        while (cursos[numDatos].nombre == "");
                        
                        do
                        {
                            Console.Write("Fecha comienzo (AAAA-MM-DD): ");
                            cursos[numDatos].fecha = Console.ReadLine();
                            if (cursos[numDatos].fecha == "")
                            {
                                Console.WriteLine("Debe introducir una fecha.");
                            }
                        }
                        while (cursos[numDatos].nombre == "");
                        
                        Console.Write("Duración (horas): ");
                        string duracionTemp = Console.ReadLine();
                        if (duracionTemp == "")
                        {
                            cursos[numDatos].duracion = 10;
                        }
                        else
                        {
                            cursos[numDatos].duracion = 
                                Convert.ToSingle(duracionTemp);
                        }
                        
                        cursos[numDatos].terminado = false;
                        
                        contadorNoTerminados ++;
                        numDatos ++;
                    }
                    break;
                    
                case VER:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos.");
                    }
                    else if (contadorNoTerminados == 0)
                    {
                        Console.WriteLine("Todos los cursos estan terminados.");
                    }
                    else
                    {
                        ushort contadorPausaVer = 0;
                        for (int i = 0; i < numDatos; i ++)
                        {
                            if (cursos[i].terminado == false)
                            {
                                Console.Write((i + 1) + cursos[i].nombre +
                                    ", fecha comienzo: " + cursos[i].fecha + 
                                    ", duración: " + cursos[i].duracion + 
                                    " horas.");
                                Console.WriteLine();
                                contadorPausaVer ++;
                            }
                            if (contadorPausaVer % 22 == 0)
                            {
                                Console.Write("Pulse INTRO para continuar.");
                                Console.ReadLine();
                            }
                        }
                    }
                    break;
                
                case MARCAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos.");
                    }
                    else if (contadorNoTerminados == 0)
                    {
                        Console.WriteLine("Todos los cursos estan terminados.");
                    }
                    else
                    {
                        Console.Write("Número de registro: ");
                        ushort numRegistroMarcar = 
                            Convert.ToUInt16(Console.ReadLine());
                        if (numRegistroMarcar < numDatos)
                        {
                            Console.WriteLine("Número de registro no válido");
                        }
                        else
                        {
                            Console.Write(cursos[numRegistroMarcar - 1].nombre + 
                                ", fecha comienzo: " + 
                                cursos[numRegistroMarcar - 1].fecha + 
                                ", duración: " + 
                                cursos[numRegistroMarcar - 1].duracion + 
                                " horas.");
                            Console.WriteLine();
                            Console.Write("Confirme que desea marcar como" +
                                " terminado (s/n) : ");
                            string opcionMarcado = Console.ReadLine().ToUpper();
                            if (opcionMarcado == "S")
                            {
                                cursos[numRegistroMarcar - 1].terminado = true;
                                contadorNoTerminados --;
                            }
                        }
                    }
                    break;
                    
                case BUSCAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos.");
                    }
                    else
                    {
                        ushort contadorPausaBuscar = 0;
                        bool encontrado = false;
                        
                        Console.Write("Introduce el texto a buscar: ");
                        string textoBuscar = Console.ReadLine().ToUpper();
                        
                        for (int i = 0; i < numDatos; i ++)
                        {
                            if (cursos[i].nombre.ToUpper().Contains(textoBuscar)
                                || cursos[i].fecha.ToUpper().
                                Contains(textoBuscar))
                            {
                                Console.Write((i + 1) + cursos[i].nombre + 
                                    ", fecha comienzo: " + cursos[i].fecha +  
                                    ", duración: " + cursos[i].duracion + 
                                    " horas.");
                                Console.WriteLine();
                                
                                contadorPausaBuscar ++;
                                encontrado = true;
                                if (contadorPausaBuscar % 22 == 0)
                                {
                                    Console.WriteLine(
                                        "Pulsa INTRO para continuar");
                                    Console.ReadLine();
                                }
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine(
                                "No se encuentran coincidencias.");
                        }
                    }
                    break;
                    
                case MODIFICAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos.");
                    }
                    else
                    {
                        Console.Write("Número de registro: ");
                        ushort numRegistroModif = 
                            Convert.ToUInt16(Console.ReadLine());
                        if (numRegistroModif > numDatos)
                        {
                            Console.WriteLine("Número de registro no válido");
                        }
                        else
                        {
                            string modificacionTemp;
                            Console.WriteLine("Modifique o deje vacío y pulse" +
                                " INTRO para mantener los datos");
                            Console.WriteLine("Nombre anterior: {0}", 
                                cursos[numRegistroModif - 1].nombre);
                            Console.WriteLine("Nuevo nombre: ");
                            modificacionTemp = Console.ReadLine();
                            if (modificacionTemp != "")
                            {
                                cursos[numRegistroModif - 1].nombre = 
                                    modificacionTemp;
                            }
                            
                            Console.WriteLine("Fecha de comienzo anterior: {0}", 
                                cursos[numRegistroModif - 1].fecha);
                            Console.WriteLine("Nueva fecha de comienzo: ");
                            modificacionTemp = Console.ReadLine();
                            if (modificacionTemp != "")
                            {
                                cursos[numRegistroModif - 1].fecha = 
                                    modificacionTemp;
                            }
                            
                            Console.WriteLine("Duración anterior: {0}", 
                                cursos[numRegistroModif - 1].duracion);
                            Console.WriteLine("Nueva duracion: ");
                            modificacionTemp = Console.ReadLine();
                            if (modificacionTemp != "")
                            {
                                cursos[numRegistroModif - 1].duracion = 
                                    Convert.ToSingle(modificacionTemp);
                            }
                        }
                    }
                    break;
                
                case BORRAR:
                    if (numDatos == 0)
                    {
                        Console.WriteLine("No hay datos.");
                    }
                    else
                    {
                        Console.Write("Número de registro: ");
                        ushort numRegistroBorrar = 
                            Convert.ToUInt16(Console.ReadLine());
                        if (numRegistroBorrar > numDatos)
                        {
                            Console.WriteLine("Número de registro no válido");
                        }
                        else
                        {
                            Console.Write(cursos[numRegistroBorrar - 1].nombre + 
                                ", fecha comienzo: " + 
                                cursos[numRegistroBorrar - 1].fecha + 
                                ", duración: " + 
                                cursos[numRegistroBorrar - 1].duracion + 
                                " horas.");
                            Console.WriteLine();
                            Console.Write("Confirme que desea borrar (s/n): ");
                            string opcionBorrado = Console.ReadLine().ToUpper();
                            if (opcionBorrado == "S")
                            {
                                if (cursos[numRegistroBorrar - 1].terminado 
                                    == false)
                                {
                                    contadorNoTerminados --;
                                }
                                for (int i = numRegistroBorrar - 1; i < 
                                    numDatos-1; i ++)
                                {
                                    cursos[i] = cursos[i + 1];
                                }
                                numDatos --;
                                
                                if (numDatos == 0)
                                {
                                    Console.WriteLine(
                                        "Se ha borrado el último dato");
                                }
                            }
                        }
                    }
                    break;
                
                case ORDENAR:
                    if (numDatos > 2)
                    {   
                        TipoCurso datosTemp;
                        
                        Console.WriteLine("1. Ordenar por nombre.");
                        Console.WriteLine("2. Ordenar por fecha.");
                        Console.Write("Escoge una opción: ");
                        string opcionOrdenar = Console.ReadLine();
                        if (opcionOrdenar == "1")
                        {
                            for (int i = 0; i < numDatos - 1; i ++)
                            {
                                for (int j = i + 1; j < numDatos; j ++)
                                {
                                    if (cursos[i].nombre.ToUpper().CompareTo(
                                        cursos[j].nombre.ToUpper()) > 0)
                                    {
                                        datosTemp = cursos[i];
                                        cursos[i] = cursos[j];
                                        cursos[j] = datosTemp;
                                    }
                                }
                            }
                        }
                        else if (opcionOrdenar == "2")
                        {
                            for (int i = 0; i < numDatos - 1; i ++)
                            {
                                for (int j = i + 1; j < numDatos; j ++)
                                {
                                    if (cursos[i].fecha.ToUpper().CompareTo(
                                        cursos[j].fecha.ToUpper()) < 0 || 
                                        (cursos[i].fecha.ToUpper() ==
                                        cursos[j].fecha.ToUpper() && 
                                        cursos[i].duracion > 
                                        cursos[j].duracion))
                                    {
                                        datosTemp = cursos[i];
                                        cursos[i] = cursos[j];
                                        cursos[j] = datosTemp;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida.");
                        }
                    }
                    break;
                    
                case SALIR:
                    salir = true;
                    break;
                
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.WriteLine();
        }
        while (!salir);
    }
}

