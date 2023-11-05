/*
64. Crea un programa que le pida al usuario dos números (reales de 
simple precisión) y una operación para realizar en ellos (+, -, *, x, 
·, /) y muestre el resultado de esa operación, como en este ejemplo:

Introduzca el primer número: 5
Introduzca la operación: ·
Introduzca el segundo número: 7
5 · 7 = 35

Es decir, la multiplicación se podrá indicar con un asterisco, con una 
x o con un punto a media altura (que está disponible en la tecla del 
número 3).
*/

// Francisco (...)

using System;

class Ejercicio64
{
    static void Main()
    {
        float num1, num2, resultado=0;
        char operacion;
        bool error=false;

        Console.Write("Introduce el primer número:");
        num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce la operacion:");
        operacion = Convert.ToChar(Console.ReadLine());
        Console.Write("Introduce el segundo número:");
        num2 = Convert.ToSingle(Console.ReadLine());

        // Código de operacion
        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
            case 'x':
            case '·':
                resultado = num1 * num2;
                break;
            case '/':
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operación desconocida.");
                error = true;
                break;
        }

        // Código de representación en pantalla
        if (!error)
        {
            Console.Write("{0} {1} {2} = {3}", num1, operacion, 
                num2, resultado);
        }
    }
}
