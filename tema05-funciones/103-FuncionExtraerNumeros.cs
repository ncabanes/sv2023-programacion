/* 103. Crea una función llamada "ExtraerNumeros", que reciba una cadena
 * formada por números enteros y espacios, como "23 45  67 89 " y 
 * devuelva un array con enteros largos, los que aparezcan como parte de
 * esa cadena, que en este caso serían {23, 45, 67, 89}. Ten en cuenta 
 * que la cadena inicial puede contener espacios iniciales, finales o 
 * redundantes, que deberás filtrar.
 */
 
using System;

namespace Ejercicio_103
{
    internal class Program
    {
        static int[] ExtraerNumeros(string nums)
        {
            nums = nums.Trim();
            while(nums.Contains("  "))
                nums = nums.Replace("  ", " ");

            string[] numsString = nums.Split();
            int[] result = new int[numsString.Length];
            for (int i = 0; i < numsString.Length; i++)
            {
                result[i] = Convert.ToInt32(numsString[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] numeros = ExtraerNumeros(" 12 32  43   534 3 2 ");
            foreach(int n in numeros)
                Console.Write(n + " ");
        }
    }
}
