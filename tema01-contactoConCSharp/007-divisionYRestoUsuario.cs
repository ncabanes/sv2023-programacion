class DivisionYResto
{
    static void Main()
    {
        int,numero2;
        int division, resto;
                    
        System.Console.WriteLine("Introduce el primer número");
        numero1= System.Convert.ToInt32( System.Console.ReadLine() );
        System.Console.WriteLine("Introduce el segundo número");
        numero2= System.Convert.ToInt32( System.Console.ReadLine() );

        division = numero1 / numero2;
        resto = numero1 % numero2;  
        
        System.Console.WriteLine(
            "El resultado de dividir {0} entre {1} es {2}, con resto {3}",
            numero1, numero2, division, resto);
    }
}
