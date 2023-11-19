// Mario (...)
/*
 * Crea una variante del programa anterior, que pregunte al usuario cuántos
 * datos guardará en un primer bloque de números reales de simple precisión,
 * luego cuántos datos guardará en un segundo bloque, y finalmente pida los
 * datos en sí. Los debe guardar en un array de arrays. Después calculará y
 * mostrará el promedio de los valores que hay guardados en el primer subarray,
 * luego el promedio de los valores en el segundo subarray y finalmente
 * el promedio global.
*/

using System;
class Ex482
{
    static void Main ()
    {
        int array1, array2;
        float median1, median2, totalMedian;
        
        Console.Write ("Introduce la dimension del primer array: ");
        array1 = Convert.ToInt32 (Console.ReadLine ());
        Console.Write ("Introduce la dimension del segundo array: ");
        array2 = Convert.ToInt32 (Console.ReadLine ());
        
        float [][] singleNumbers;
        singleNumbers = new float [2][];
        singleNumbers[0] = new float [array1];
        singleNumbers[1] = new float [array2];
        
        median1 = median2 = 0;
        for (int i=0; i<singleNumbers.Length; i++)
        {
            for (int j=0; j<singleNumbers[i].Length; j++)
            {
                Console.Write ("Introduce numero para ["+i+"]["+j+"]: ");
                singleNumbers[i][j]=Convert.ToSingle (Console.ReadLine ());
                if (i==0)
                    median1+=singleNumbers[0][j];
                if (i==1)
                    median2+=singleNumbers[1][j];
            }
        }
        median1 = median1/singleNumbers[0].Length;
        median2 = median2/singleNumbers[1].Length;
        
        totalMedian = (median1+median2)/2;
        
        Console.WriteLine ("Media de la primera mitad de la matriz: "+median1);
        Console.WriteLine ("Media de la segunda mitad de la matriz: "+median2);
        Console.WriteLine ("Media de la matriz: "+totalMedian);
    }
}
