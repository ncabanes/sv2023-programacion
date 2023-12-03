/*96. Crea una función llamada "AnimarMucho", que escriba "Voy a aprobar " 
seguido del texto indicado en un primer parámetro (string). Esa frase se 
repetirá tantas veces como se indique en un segundo parámetro (número entero). 
Aplícala a un programa de prueba, que pregunte el nombre de la asignatura (o 
módulo) que sabes que vas a aprobar y que muestre el mensaje 3 veces. En ese 
programa de prueba, tu función estará declarada antes de Main.*/
 
// Noelia (...)

using System;

class Ejercicio096
{
    static void AnimarMucho(string texto, int n)
    {
        for (int i = 0; i < n ; i++)
        {
            Console.WriteLine("Voy a aprobar " + texto);
        }  
    }
   
    static void Main()
    {
        Console.Write("Dime una asignatura o módulo: ");
        string modulo = Console.ReadLine();
        
        AnimarMucho(modulo,3 );
    }
}
    
    

