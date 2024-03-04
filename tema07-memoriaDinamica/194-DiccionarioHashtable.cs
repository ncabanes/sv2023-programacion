/*194. Crea una variante del ejercicio anterior (diccionario simple de 
castellano a valenciano) que utilice una tabla Hash.*/

//Noelia(...)


using System;
using System.Collections;

class Ejercicio194
{
    static void Main()
    {
        Hashtable diccioCastVal = new Hashtable();

        const string ANADIR = "1", BUSCAR = "2", VER = "3", SALIR = "S";
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
            Console.WriteLine(SALIR + ". Salir");
            Console.WriteLine();
            Console.Write("Escoge una opción: ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcion)
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
                    string traducirPalabra = Console.ReadLine();

                    if (diccioCastVal.ContainsKey(traducirPalabra))
                    {
                        Console.WriteLine(traducirPalabra + " = " +
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

                    IDictionaryEnumerator miEnumerador = diccioCastVal.GetEnumerator();
                    while (miEnumerador.MoveNext())
                    {
                        Console.WriteLine(miEnumerador.Key + " = " + miEnumerador.Value);
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
        while (!terminar);

    }
}
