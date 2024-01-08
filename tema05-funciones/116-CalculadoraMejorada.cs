/* Nombre: Andrés Sánchez Montesinos.
 * Curso: 1º DAM. Semipresencial 2023-2024 */

/* Ejercicio 116. Calculadora con potencias y return.
 * 
 * Crea una versión mejorada de la "calculadora", que también permita calcular 
 * potencias (con el símbolo E, como abreviatura de "elevado a"), y que
 * devuelva códigos de error al sistema operativo: el código de error 0 si todo
 * ha sido correcto, el código 1 si se ha indicado un operador no válido o el
 * código 2 si alguno de los números no era válido, además de mostrar en
 * consola un mensaje de aviso adecuado:
 * 
 * calculadora 2 E 3
 * 8
 * calculadora 2 ** 3
 * Operador desconocido
 * calculadora 3 + Hola
 * Número no válido
 * 
 * Nota: el enunciado original de este ejercicio pedía usar el símbolo ^ para
 * la potencia, pero se trata de un carácter de escape en el intérprete de
 * comandos de Windows, por lo que para usarlo habría que hacer:
 * calculadora 2 "^" */

using System;

class calculadoraMejorada {
    
    static int Main(string[] args) {
        
        float numero1, numero2;
        
        try {
            numero1 = Convert.ToSingle(args[0]);
            numero2 = Convert.ToSingle(args[2]);
        } catch (Exception) {
            Console.WriteLine("Número no válido.");
            return 2;
        }
            
        string operador = Convert.ToString(args[1]);
        
        if (operador == "+" || operador == "-" || operador == "*" ||
                operador == "/" || operador == "E") {
                    
            if (args[1].Length > 1) {
                Console.WriteLine("Operador desconocido.");
                return 1;
            }
            
            switch(operador) {
                case "+":
                    Console.WriteLine(numero1 + numero2);
                    break;
                case "-":
                    Console.WriteLine(numero1 - numero2);
                    break;
                case "*":
                    Console.WriteLine(numero1 * numero2);
                    break;
                case "/":
                    if (numero2 == 0) {
                        Console.WriteLine("No se puede dividir entre \"0\" ");
                    } else {
                        Console.WriteLine(numero1 / numero2);
                    }
                    break;
                case "E":
                    float resultadoPotencia = 1;
                    
                    for (int i = 0; i < numero2; i++) {
                        resultadoPotencia *= numero1; 
                    }
                    
                    Console.WriteLine(resultadoPotencia);
                    break;
            }
        } else {
            Console.WriteLine("Operador desconocido.");
            return 1;
        }
        return 0;
    }
}
