// Par o impar, switch, delegando con "goto case"

using System;

class ParOImparSwitch2 
{
    static void Main() 
    {
        int a;
        
        Console.WriteLine("Dime el número");
        a = Convert.ToInt32( Console.ReadLine() );
        
        switch(a)
        {
            case 1: Console.WriteLine("Es impar"); break;
            case 2: Console.WriteLine("Es par"); break;
            case 3: goto case 1;
            case 4: goto case 2;
            case 5: goto case 1;
            case 6: goto case 2;
            default: Console.WriteLine("Del 1 al 6, por favor"); break;
        }
    }
}

