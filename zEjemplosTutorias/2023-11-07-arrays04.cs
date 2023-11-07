using System;

// Crea un array prefijado con los nombres de los 
// días de la semana. 
// Pregunta al usuario el nombre de un día y respóndele 
// si ese día existe.

class Arrays04
{
    static void Main() 
    {
        string[] diasSemana = {"lunes", "martes", "miércoles"};
        bool existe;
        int apariciones;
        
        Console.Write("Dime el nombre de un día: ");
        string nombre = Console.ReadLine();
        
        existe = false;
        for (int i = 0; i < diasSemana.Length; i++)
        {
            if (nombre == diasSemana[i])
                existe = true;
        }
        if (existe)
            Console.WriteLine("Bien!");
        else
            Console.WriteLine("No existe ese día");
        
        /* 
        // Primera forma de acelerar, no correcta
        for (int i = 0; i < diasSemana.Length; i++)
        {
            if (nombre == diasSemana[i])
            {
                existe = true;
                break;
            }
        }
        
        // Segunda forma de acelerar, no correcta
        for (int i = 0; i < diasSemana.Length && !existe; i++)
        {
            if (nombre == diasSemana[i])
                existe = true;
        }
        
        // Tercera forma de acelerar, correcta
        int j = 0;
        while ( j < diasSemana.Length && !existe)
        {
            if (nombre == diasSemana[j])
                existe = true;
            j++;
        }
        */
        
        apariciones = 0;
        for (int i = 0; i < diasSemana.Length; i++)
        {
            if (nombre == diasSemana[i])
                apariciones++;
        }
        if (apariciones > 0)
            Console.WriteLine("Bien! Existe {0} veces", apariciones);
        else
            Console.WriteLine("No existe ese día");
        
    }
}

/*
Dime el nombre de un día: lunes
Bien!
Bien! Existe 1 veces

Dime el nombre de un día: miercoles
No existe ese día
No existe ese día
*/
