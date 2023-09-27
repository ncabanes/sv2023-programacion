// Par o impar, switch, forma "larga"

using System;

class ParOImparSwitch1 
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
            case 3: Console.WriteLine("Es impar"); break;
            case 4: Console.WriteLine("Es par"); break;
            case 5: Console.WriteLine("Es impar"); break;
            case 6: Console.WriteLine("Es par"); break;
            default: Console.WriteLine("Del 1 al 6, por favor"); break;
        }
    }
}

