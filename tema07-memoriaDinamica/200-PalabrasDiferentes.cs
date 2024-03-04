/* 200. Crea un programa que calcule cuántas palabras diferentes hay en los
 * ficheros words.txt y words2.txt, que tienes compartidos en GitHub. Haz dos 
 * versiones: la primera usará un ArrayList o una lista con tipo, la segunda
 * empleará un diccionario. Nuevamente, si quieres medir tiempos exactos,
 * puedes emplear la estructura vista en el ejercicio 199. 
 * 
 * VICTOR (...), retoques por Nacho */

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void CompararList(string rutaFichero1, string rutaFichero2)
    {
        Console.WriteLine("Leyendo a lista...");
        DateTime comienzo = DateTime.Now;

        List<string>lineas1 = new List<string>(File.ReadAllLines(rutaFichero1));
        Console.WriteLine("Datos en la primera lista: " + lineas1.Count);
        List<string>lineas2 = new List<string>(File.ReadAllLines(rutaFichero2));
        Console.WriteLine("Datos en la segunda lista: " + lineas2.Count);

        Console.WriteLine("Guardando palabras no repetidas.");
        List<string> palabrasDiferentes = new List<string>();
        foreach (string palabra in lineas1)
        {
            if (!lineas2.Contains(palabra))
            {
                palabrasDiferentes.Add(palabra);
            }
        }

        Console.WriteLine("Cantidad de palabras diferentes = " +
            palabrasDiferentes.Count);

        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
    }
    
    
    static void CompararSortedList(string rutaFichero1, string rutaFichero2)
    {
        Console.WriteLine("Leyendo a SortedList...");
        DateTime comienzo = DateTime.Now;

        SortedList<string,string>lineas1 = new SortedList<string,string>();
        foreach(string linea in File.ReadAllLines(rutaFichero1))
            if (!lineas1.ContainsKey(linea))
                lineas1.Add(linea, linea);
        Console.WriteLine("Datos en la primera lista: " + lineas1.Count);
        
        Dictionary<string,string>lineas2 = new Dictionary<string,string>();
        foreach(string linea in File.ReadAllLines(rutaFichero2))
            if (!lineas2.ContainsKey(linea))
                lineas2.Add(linea, linea);
        Console.WriteLine("Datos en la segunda lista: " + lineas2.Count);

        Console.WriteLine("Guardando palabras no repetidas.");
        List<string> palabrasDiferentes = new List<string>();
        foreach (string palabra in lineas1.Keys)
        {
            if (!lineas2.ContainsKey(palabra))
            {
                palabrasDiferentes.Add(palabra);
            }
        }

        Console.WriteLine("Cantidad de palabras diferentes = " +
            palabrasDiferentes.Count);

        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
    }
    
    
    static void CompararDictionary(string rutaFichero1, string rutaFichero2)
    {
        Console.WriteLine("Leyendo a diccionario...");
        Da