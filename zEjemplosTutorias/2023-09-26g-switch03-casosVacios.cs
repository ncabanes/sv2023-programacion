// Par o impar, switch, con casos totalmente vacíos

using System;

class ParOImparSwitch3
{
    static void Main() 
    {
        int a;
        
        Console.WriteLine("Dime el número");
        a = Convert.ToInt32( Console.ReadLine() );
        
        switch(a)
        {
            case 1: 
            case 3: 
            case 5: Console.WriteLine("Es impar"); break;
            
            case 2: 
            case 4: 
            case 6: Console.WriteLine("Es par"); break;
            
            default: Console.WriteLine("Del 1 al 6, por favor"); break;
        }
    }
}

