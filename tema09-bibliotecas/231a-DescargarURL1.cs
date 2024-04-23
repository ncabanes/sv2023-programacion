/*
231. Descarga de forma automatizada la versión HTML del libro "Learn Python the 
Hard Way" (al menos los 52 ejercicios), desde

https://learnpythonthehardway.org/book/
*/

// Mario (...)

using System;
using System.IO;
using System.Net;
using System.Collections.Generic;

class Ejercicio231
{
    static void Main()
    {
        WebClient cliente = new WebClient();
        List<string> lineas = new List<string>();
        string direccionBase = "https://learnpythonthehardway.org/book/";
        Stream conexion;
        StreamReader lector;
        StreamWriter escritor;
        string linea;
        for (int i = 0; i <= 52; i++)
        {
            string titulo = "Ejercicio " + i + ".txt";
            conexion = cliente.OpenRead(direccionBase + "ex" + i + ".html");
            lector = new StreamReader(conexion);
            while ( (linea = lector.ReadLine()) != null )
            {
                lineas.Add(linea);
            }
            lector.Close();

            escritor = File.CreateText(titulo);
            foreach (string l in lineas)
            {
                escritor.WriteLine(l);
            }
            escritor.Close();
        }
    }
}
