/*
Muestra las líneas que contienen la palabra 
"daw" en la página principal del IES San 
Vicente.
*/

using System;
using System.IO;
using System.Net;

class Prueba
{ 
    static void Main()
    {
        WebClient client = new WebClient();
        Stream conexion = client.OpenRead(
            "https://www.iessanvicente.com");
        StreamReader lector = new StreamReader(conexion);
        string linea;
        linea = lector.ReadLine();
        while (linea != null)
        {
            if (linea.ToUpper().Contains("DAW"))
                Console.WriteLine(linea);
            linea = lector.ReadLine();
        }
        conexion.Close();
        lector.Close();

    }
}

      //< li >< a href = "alu/daw/index.php" > Desarrollo de Aplicaciones Web, presencial y semipresencial (Grado Superior)</ a > (flexibilizado) </ li >
