/*
121. Crea una función "Main" que permita probar las últimas 4 funciones. Debe
analizar los parámetros de la línea de comandos (que pueden estar en
mayúsculas, minúsculas o en mayúsculas y minúsculas mezcladas) y debe
comportarse de la siguiente manera:

Si el primer parámetro es "rec", seguido de dos números (rec 8 3), mostrará un
recuadro redondeado con ese ancho y ese alto.
Si el primer parámetro es "md", seguido de un número (md 34512), mostrará el
mayor dígito de ese número.
Si el primer parámetro es "ld", seguido de un texto (mm Hola3), mostrará la
cantidad de letras y dígitos de este texto.
Si el primer parámetro es "mc", seguido de una o varias palabras (mc hola.
que tal), mostrará las palabras con mayúsculas correctas ("Hola. Que tal").
Si no se usan parámetros, o si se especifica un primer parámetro incorrecto,
mostrará "Uso: rec / md / mm / mc" y regresará al sistema operativo con el
código de error 1. Por otra parte, si se usan menos parámetros de los esperado
(es decir, : "md" y ningún número, "rec" y menos de dos números, y así
sucesivamente), mostrará "Faltan parámetros" y regresará al sistema operativo
con el código de error 2. Si todo es correcto, regresará al sistema operativo
con código de error 0.
*/
// Mario (...)

using System;

class Ejercicio121
{
    static void MostrarRecuadroRedondeado(int ancho, int alto)
    {
        // primera fila
        if (ancho > 0 && alto > 0)
        {
            if (alto > 1)
            {
                Console.Write("/");
                for (int i = 0; i < ancho - 2; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("\\");
            }

            // centro
            for (int fila = 0; fila < alto - 2; fila++)
            {
                Console.Write("|");
                for (int columna = 0; columna < ancho - 2; columna++)
                {
                    Console.Write(" ");
                }
                if (ancho > 1)
                    Console.Write("|");
                Console.WriteLine();
            }

            // ultima fila
            if (alto > 1)
            {
                Console.Write("\\");
                for (int i = 0; i < ancho - 2; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("/");
            }
        }
    }

    static int ObtenerMayorDigito(long cifra)
    {
        string cifras = Convert.ToString(cifra);

        int mayor = cifras[0] - '0';

        for (int i = 1; i < cifras.Length; i++)
        {
            if (cifras[i] - '0' > mayor)
                mayor = cifras[i] - '0';
        }

        return mayor;
    }

    static void ContarLd(string frase, out int letras, out int num)
    {
        frase = frase.ToLower();
        letras = 0;
        num = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] >= 'a' && frase[i] <= 'z')
                letras++;
            if (frase[i] >= '0' && frase[i] <= '9')
                num++;
        }
    }

    static string MayusculasCorrectas(string cadena)
    {
        cadena = cadena.ToLower();

        string[] cadenaPartida1 = cadena.Split('.');
        for (int i = 0; i < cadenaPartida1.Length; i++)
        {
            cadenaPartida1[i] = cadenaPartida1[i].Substring(0, 1).ToUpper() +
                cadenaPartida1[i].Substring(1);
        }
        string mitad = String.Join(".", cadenaPartida1);

        // Nota del profesor: la siguiente línea es una forma sencilla...
        // pero que sólo funconará en versiones recientes de C#
        // (superiores a C#5, que permitan una cadena en "Split")
        string[] cadenaPartida2 = mitad.Split(". ");
        for (int i = 0; i < cadenaPartida2.Length; i++)
        {
            cadenaPartida2[i] = cadenaPartida2[i].Substring(0, 1).ToUpper() +
                cadenaPartida2[i].Substring(1);
        }
        string final = String.Join(". ", cadenaPartida2);

        return final;
    }

    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Uso: rec / md / ld / mc");
            return 1;
        }
        else
        {
            switch (args[0])
            {
                case "rec":
                    if (args.Length != 3)
                    {
                        Console.WriteLine("Faltan parámetros.");
                        return 2;
                    }
                    else
                    {
                        MostrarRecuadroRedondeado(Convert.ToInt32(args[1]),
                            Convert.ToInt32(args[2]));
                        return 0;
                    }

                case "md":
                    if (args.Length != 2)
                    {
                        Console.WriteLine("Faltan parámetros.");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine(ObtenerMayorDigito(Convert.ToInt32(args[1])));
                        return 0;
                    }

                case "ld":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Faltan parámetros.");
                        return 2;
                    }
                    else
                    {
                        int letras, cifras;
                        ContarLd(args[1], out letras, out cifras);
                        Console.WriteLine("Letras: " + letras + ", dígitos: " + cifras);
                        return 0;
                    }

                case "mc":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Faltan parámetros.");
                        return 2;
                    }
                    else
                    {
                        string frase = "";
                        for (int i = 1; i < args.Length; i++)
                        {
                            frase = frase + args[i] + " ";
                        }
                        Console.WriteLine(MayusculasCorrectas(frase));
                        return 0;
                    }

                default:
                    Console.WriteLine("Uso: rec / md / ld / mc");
                    return 1;
            }
        }
    }
}
