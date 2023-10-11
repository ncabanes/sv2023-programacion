using System;

class For02Anidado 
{
    static void Main() 
    {
        for(int tabla = 1; tabla <= 10; tabla++)
        {
            for (int numero = 0; numero <= 10; numero++)
            {
                Console.WriteLine("{0} x {1} = {2}",
                    tabla, numero, tabla*numero);
            }
            Console.WriteLine();
        }
    }
}

/*
Resultado:

(...)
8 x 7 = 56
8 x 8 = 64
8 x 9 = 72
8 x 10 = 80

9 x 0 = 0
9 x 1 = 9
9 x 2 = 18
(...)
9 x 8 = 72
9 x 9 = 81
9 x 10 = 90

10 x 0 = 0
10 x 1 = 10
10 x 2 = 20
10 x 3 = 30
10 x 4 = 40
10 x 5 = 50
10 x 6 = 60
10 x 7 = 70
10 x 8 = 80
10 x 9 = 90
10 x 10 = 100
 
*/
