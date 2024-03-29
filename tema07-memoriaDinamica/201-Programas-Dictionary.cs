﻿/*201. Crea un programa en C# que permita almacenar fichas de programas de 
ordenador, empleando un diccionario (en vez de una lista o un array). Para cada
programa, esta primera versión debe guardar los siguientes datos:

- Código (un texto breve que actuará como "clave").
- Nombre
- Descripción
- Versión
- Ubicación del backup

El programa debe permitir al usuario las siguientes operaciones:

1- Añadir datos de un nuevo programa. 

2- Mostrar los datos de un programa a partir de su código.

3- Mostrar código y nombre de todos los programas, haciendo una pausa tras 
cada 20.

4- Buscar los que contienen un cierto texto.

5- Modificar una ficha (a partir de su código)

6- Borrar una ficha (a partir de su código).

T- Terminar.*/

// Miguel Ángel (...)


using System;
using System.Collections.Generic;

// --------------------

class Programa
{
    private string codigo;
    private string nombre;
    private string descripcion;
    private string version;
    private string ubicacion;

    public Programa(string codigo, string nombre, string descripcion, 
        string version, string ubicacion)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.version = version;
        this.ubicacion = ubicacion;
    }

    public string GetNombre() { return nombre; }
    public string GetDescripcion() {  return descripcion; }
    public string GetVersion() { return version; }
    public string GetUbicacion() { return ubicacion; }

    public void SetNombre(string nombre) {  this.nombre = nombre; }
    public void SetDescripcion(string descripcion) 
    {
        this.descripcion = descripcion;
    }
    public void SetVersion(string version) { this.version = version; } 
    public void SetUbicacion(string ubicacion) { this.ubicacion= ubicacion; }

    public override string ToString()
    {
        return codigo + ": " + nombre + " (" + version + "), descripción: "
            + descripcion + ", ubicación: " + ubicacion;
    }
}

// --------------------

class GestorProgramas
{
    private Dictionary<string, Programa> programas;

    public GestorProgramas()
    {
        programas = new Dictionary<string, Programa>();
    }

    public void Ejecutar()
    {
        bool salir = false;
        do
        {
            string opcion = MenuPrincipal().ToUpper();
            Console.WriteLine();

            switch(opcion)
            {
                case "1": Anyadir(); break;
                case "2": MostrarDatos(); break;
                case "3": MostrarCodigo(); break;
                case "4": Buscar(); break;
                case "5": Modificar(); break;
                case "6": Borrar(); break;
                case "T": salir = true; break;
                default: Console.WriteLine("Opción incorrecta."); break;
            }

        } while (!salir);
    }

    static string MenuPrincipal()
    {
        Console.WriteLine();
        Console.WriteLine("1. Añadir datos de un nuevo programa.");
        Console.WriteLine("2. Mostrar datos de un programa.");
        Console.WriteLine("3. Mostrar el código de todos los programas.");
        Console.WriteLine("4. Buscar un programa.");
        Console.WriteLine("5. Modificar una ficha.");
        Console.WriteLine("6. Borrar una ficha.");
        Console.WriteLine("T. Terminar.");
        Console.WriteLine();
        return Pedir("Elige una opción: ");
    }

    void Anyadir()
    {
        string codigo = Pedir("Código: ");
        string nombre = Pedir("Nombre: ");
        string descripcion = Pedir("Descripción: ");
        string version = Pedir("Versión: ");
        string ubicacion = Pedir("Ubicación del backup: ");
        programas[codigo] = new Programa(codigo, nombre, descripcion,
            version, ubicacion);
    }

    string MostrarDatos()
    {
        string codigo = Pedir("Código del programa: ");
        if (programas.ContainsKey(codigo))
        {
            Console.WriteLine(programas[codigo]);
        }
        else
        {
            Console.WriteLine("El código no se ha encontrado.");
        }
        return codigo;
    }

    void MostrarCodigo()
    {
        int contador = 1;
        foreach (string codigo in programas.Keys)
        {
            Console.WriteLine("Código: {0}, Nombre del programa: {1}",
                codigo, programas[codigo].GetNombre());
            contador++;
            if (contador % 20 == 0)
            {
                Console.WriteLine();
                Pedir("Pulse Intro para continuar.");
                Console.WriteLine();
            }
        }
    }

    void Buscar()
    {
        bool encontrado = false;
        string txt = Pedir("Texto a buscar: ").ToUpper();
        foreach (string codigo in programas.Keys)
        {
            if (programas[codigo].GetNombre().ToUpper().Contains(txt) ||
                programas[codigo].GetDescripcion().ToUpper().Contains(txt) ||
                programas[codigo].GetVersion().ToUpper().Contains(txt) || 
                programas[codigo].GetUbicacion().ToUpper().Contains(txt))
            {
                encontrado = true;
                Console.WriteLine(programas[codigo]);
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No se han encontrado coincidencias.");
        }
    }

    void Modificar()
    {
        string codigo = Pedir("Código: ");
        if (programas.ContainsKey(codigo)) 
        {
            programas[codigo].SetNombre(ModificarNoVacio(
                programas[codigo].GetNombre(), "Nuevo nombre: ")) ;
            programas[codigo].SetDescripcion(ModificarNoVacio(
                programas[codigo].GetDescripcion(), "Nuevo nombre: ")) ;
            programas[codigo].SetVersion(ModificarNoVacio(
                programas[codigo].GetVersion(), "Nueva versión: ")) ;
            programas[codigo].SetUbicacion(ModificarNoVacio(
                programas[codigo].GetUbicacion(), "Nueva ubicación: "));
        }
    }
    void Borrar()
    {
        string codigo = MostrarDatos();
        if (programas.ContainsKey(codigo))
        {
            if (Pedir("Desea borrar la ficha (s/n)").ToUpper() == "S")
            {
                programas.Remove(codigo);
                Console.WriteLine("Ficha borrada.");
            }
        }
    }
    static string Pedir(string datoPedido)
    {
        Console.Write(datoPedido);
        return Console.ReadLine();
    }

    static string ModificarNoVacio(string valorAnterior, string datoPedido)
    {
        Console.WriteLine("Valor anterior (pulsa Intro para no modificarlo: " 
            + valorAnterior);
        string valor = Pedir(datoPedido);
        if (valor != "")
        {
            valor = valorAnterior;
        }
        return valor;
    }

    static void Main()
    {
        GestorProgramas g = new GestorProgramas();
        g.Ejecutar();
    }
}

   