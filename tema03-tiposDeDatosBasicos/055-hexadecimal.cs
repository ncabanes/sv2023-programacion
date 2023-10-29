/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2023-2024 */

/* Ejercicio 55. Numeros en hexadecimal.
 * 
 * Pide al usuario dos números enteros cortos
 * y muestra todos los números entre ellos, en hexadecimal, en la misma línea,
 * separados por un espacio.
 * 
 * Por ejemplo, si introduce 7 y 12, deberás mostrar "7 8 9 a b c".
 * 
 * El programa se debe comportar correctamente si introduce los números
 * en orden contrario, es decir, si primero indica 12 y 7 en vez de 7 y 12. */
 
 using System;
 
 class numerosCortosHexadecimal {
     
     static void Main() {
         
         short numero1, numero2, desde, hasta;
         
         Console.Write("Introduce el primero de los números: ");
         numero1 = Convert.ToInt16(Console.ReadLine());
         
         Console.Write("Introduce el segundo de los números: ");
         numero2 = Convert.ToInt16(Console.ReadLine());
         
         if (numero1 <= numero2) {
             desde = numero1;
             hasta = numero2;
         } else {
             desde = numero2;
             hasta = numero1;
         }
         
         for (short n = desde; n <= hasta; n++) {
             
             //Cambio de base hexadecimal normal.
             //Console.Write(Convert.ToString(n, 16));
             
             //Cambio de base hexadecimal abreviada en mayusculas.
             //Console.Write(n.ToString("X"));
             
             //Cambio de base hexadecimal abreviada en minúsculas.
             Console.Write(n.ToString("x"));

             Console.Write(" ");
         }
     }
 }
