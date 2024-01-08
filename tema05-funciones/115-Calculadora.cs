/* Nombre: Andrés (...) */

/* Ejercicio 115. Parámetros por linea de comandos.
 * 
 * Crea un programa llamado "calculadora", que reciba dos números enteros y un
 * operador (+, -, *, /) en la línea de comandos y muestre el resultado de la
 * operación, como en este ejemplo:
 * calculadora 5 * 3
 * 15
 * 
 * Nota: A pesar de que los datos sean enteros, la división se calculará con
 * decimales, de modo que otro ejemplo de ejecución podría ser:
 * calculadora 15 / 2
 * 7,5 */
 
using System;
 
class calculadora {
    
    static void Main(string[] args) {
        
        if (args.Length < 3) {
            Console.WriteLine("Error en el número de parámetros.");
        } else {
            float numero1 = Convert.ToSingle(args[0]);
            char operador = Convert.ToChar(args[1]);
            float numero2 = Convert.ToSingle(args[2]);
            
            switch (operador){
                case '+':
                    Console.WriteLine(numero1 + numero2);
                    break;
                case '-':
                    Console.WriteLine(numero1 - numero2);
                    break;
                case '*':
                    Console.WriteLine(numero1 * numero2);
                    break;
                case '/':
                    if (numero2 == 0) {
                        Console.WriteLine("No se puede dividir entre \"0\" ");
                    } else {
                        Console.WriteLine(numero1 / numero2);
                    }
                    break;
                default:
                    Console.WriteLine("Error en el operador utilizado.");
                    break;
            }
        }
    }
}
