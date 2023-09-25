/*
Vicente Descals Cabanes
Tablas de multiplicar
*/

using System; 

class TablaMultiplicar 
{
    static void Main() 
    {    
        int multiplicando;

        Console.Write("Escribe el número que quieres multiplicar ");
        multiplicando = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} x 0 = {1}", multiplicando, multiplicando*0);
        Console.WriteLine("{0} x 1 = {1}", multiplicando, multiplicando*1);
        Console.WriteLine("{0} x 2 = {1}", multiplicando, multiplicando*2);
        Console.WriteLine("{0} x 3 = {1}", multiplicando, multiplicando*3);
        Console.WriteLine("{0} x 4 = {1}", multiplicando, multiplicando*4);
        Console.WriteLine("{0} x 5 = {1}", multiplicando, multiplicando*5);
        Console.WriteLine("{0} x 6 = {1}", multiplicando, multiplicando*6);
        Console.WriteLine("{0} x 7 = {1}", multiplicando, multiplicando*7);
        Console.WriteLine("{0} x 8 = {1}", multiplicando, multiplicando*8);
        Console.WriteLine("{0} x 9 = {1}", multiplicando, multiplicando*9);
        Console.WriteLine("{0} x 10 = {1}", multiplicando, multiplicando*10);
    }
}
