/* 228. Intenta romper la contraseña de un archivo comprimido, lanzando un
 * descompresor y verificando si el valor devuelto es 0. Tendrás un fichero
 * compartido llamado "c.7z" en Aules y en GitHub, cuya contraseña es un número
 * de 4 cifras (entre 0000 y 9999), y también tendrás el (des)compresor de
 * línea de comandos 7za.exe (la orden para descomprimir probando una
 * contraseña 1234 es "7za x c.7z -p1234").
 * 
 * VICTOR (...) 1ºDAM SEMI */

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string archivoComprimido = "c.7z";
        string programa = "7za.exe";
        int contrasenya = 0;
        bool encontrado = false;

        do
        {
            Console.WriteLine("Probando contraseña..." + contrasenya.ToString("0000"));

            ProcessStartInfo descompresor = new ProcessStartInfo(programa);
            descompresor.Arguments = "x "+archivoComprimido+" -p"+
                contrasenya.ToString("0000");

            Process proceso = Process.Start(descompresor);
            proceso.WaitForExit();

            if (proceso.ExitCode == 0)
            {
                encontrado = true;
            }
            else
            {
                contrasenya++;
            }
        }
        while (!encontrado && contrasenya <= 9999);

        if (encontrado)
        {
            Console.WriteLine("La contraseña es: " + contrasenya.ToString("0000"));
        }
        else
        {
            Console.WriteLine("Contraseña no encontrada.");
        }
    }
}
