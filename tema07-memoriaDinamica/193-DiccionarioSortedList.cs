/*193. Crea un diccionario simple de castellano a valenciano: el 
programa deberá contener al menos 15 palabras prefijadas. Mostrará un 
menú que permita añadir una nueva palabra (pedirá tanto la palabra en 
castellano como su traducción a valenciano), buscar la traducción de 
una palabra, ver la lista de todas las palabras almacenadas o salir. En 
esta primera versión debes usar una "SortedList".*/

//Noelia (...)


using System;
using System.Collections;

class Ejercicio193
{
    static void Main()
    {
        SortedList diccioCastVal = new SortedList();

       const string ANADIR = "1",BUSCAR = "2", VER = "3", SALIR = "S";
        string opcion;
        bool terminar = false;

        diccioCastVal.Add("rojo", "vermell");
        diccioCastVal.Add("naranja", "taronja");
        diccioCastVal.Add("amarillo", "groc");
        diccioCastVal.Add("verde", "verd");
        diccioCastVal.Add("azul", "blau");
        diccioCastVal.Add("violeta", "lila");
        diccioCastVal.Add("blanco", "blanc");
        diccioCastVal.Add("negro", "negre");
        diccioCastVal.Add("gris", "gris");
        diccioCastVal.Add("marrón", "marró");
        diccioCastVal.Add("rosa", "rosa");
        diccioCastVal.Add("morado", "morat");
        diccioCastVal.Add("turquesa", "turquesa");
        diccioCastVal.Add("beige", "beix");
        diccioCastVal.Add("celeste", "blau cel");

        do
        {
            Console.WriteLine();
            Console.WriteLine("DICCIONARIO CASTELLANO-VALENCIANO");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(ANADIR + ". Añadir nueva palabra");
            Console.WriteLine(BUSCAR + ". Buscar traduccion");
            Console.WriteLine(VER + ". Ver lista");
            Console.WriteLine(SALIR +  ". Salir");
            Console.WriteLine();
            Console.Write("Escoge una opción: ");
            opcion= Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch(opcion ) 
            {
                case "1":
                    Console.Write("Añade la palabra en castellano: ");
                    string castellano = Console.ReadLine();

                    if (diccioCastVal.ContainsKey(castellano))
                    {
                        Console.WriteLine("Esta palabra ya está almacenada");
                    }
                    else
                    {
                        Console.Write("Añade traducción al valenciano: ");
                        string valenciano = Console.ReadLine();

                        diccioCastVal.Add(castellano, valenciano);
                    }
                    break;

                case "2":
                    Console.Write("Introduce la palabra a traducir: ");
                    string traducirPalabra= Console.ReadLine();

                    if (diccioCastVal.ContainsKey (traducirPalabra))
                    {
                        Console.WriteLine(traducirPalabra +" = " + 
                            diccioCastVal[traducirPalabra]);
                    }
                    else
                    {
                        Console.WriteLine("Palabra no encontrada");
                    }
                    break;

                case "3":
                    Console.WriteLine("Lista castellano-valenciano:");
                    Console.WriteLine();
                    for (int i = 0; i < diccioCastVal.Count; i++)
                    {
                        Console.WriteLine(diccioCastVal.GetKey(i) + " = " + 
                            diccioCastVal[diccioCastVal.GetKey(i) ]);
                    }
                    Console.WriteLine();
                    break;

                case "S":
                    terminar = true;
                    Console.WriteLine("Fin del programa");
                    break;

                default:
                    Console.WriteLine("Esa opcion no es válida");
                    break;
            }
        }
        while  (!terminar);

    }
}
